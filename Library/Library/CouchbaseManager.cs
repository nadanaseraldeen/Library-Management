using System.Threading.Tasks;
using Couchbase;
using Couchbase.KeyValue;
using Couchbase.Management.Users;
using System;
using Newtonsoft.Json.Linq;
using Couchbase.Query;
using Couchbase.Core.Sharding;
using Amazon.DynamoDBv2.Model;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Library
{
    public class CouchbaseManager
    {
        private static IBucket _bucket;
        private static ICluster _cluster;

        public CouchbaseManager()
        {
            Task.Run(async () => await InitializeCouchbase()).Wait();
        }
  
        private const string ClusterUri = "localhost";
        private const string BucketName = "Library";
        private const string Username = "Nada";
        private const string Password = "2342002Nada";

        // Initialaize and connect on the Couchbase Database
        public async Task InitializeCouchbase()
        {
            var clusterOptions = new ClusterOptions
            {
                UserName = Username,
                Password = Password
            };

            var connectionString = $"couchbase://{ClusterUri}";
            var cluster = await Cluster.ConnectAsync(connectionString, clusterOptions);
            _bucket = await cluster.BucketAsync(BucketName);
        }

        // Create librarian in Admin form and store in librarians collection in _default scope
        internal async void CreateLibrarian(Librariann l)
        {
            l.ID = Guid.NewGuid().ToString(); 
            await _bucket.Scope("_default").Collection("librarians").UpsertAsync(l.ID.ToString(), l);

        }

        // This method is to retrieve the maximum ID in the libraries collection. When a new library is added, the ID is increased
        public async Task<int> GetMaxLibraryId()
        {
            var query = "SELECT MAX(id) AS maxId FROM Library._default.libraries";
            var result = await _bucket.Cluster.QueryAsync<dynamic>(query);

            await foreach (var row in result)
            {
                var maxId = row.maxId;
                if (maxId != null)
                {
                    return Convert.ToInt32(maxId);
                }
            }
            return 0;
        }

        // Create library in Admin form and store in libraries collection in _default scope
        internal async void CreateLibrary(Libraryy li)
        {
            int maxId = await GetMaxLibraryId();
            int newId = maxId + 1;
            li.ID = newId;
            await _bucket.Scope("_default").Collection("libraries").UpsertAsync(li.ID.ToString(), li);
        }

        // This method is to retrieve the maximum ID in the catalogs collection. When a new catalog is added, the ID is increased
        public async Task<int> GetMaxCatalogId()
        {
            var query = "SELECT MAX(id) AS maxId FROM Library._default.catalogs";
            var result = await _bucket.Cluster.QueryAsync<dynamic>(query);

            await foreach (var row in result)
            {
                var maxId = row.maxId;
                if (maxId != null)
                {
                    return Convert.ToInt32(maxId);
                }
            }
            return 99; //The ID start from 100
        }

        // Create catalog in Admin form and store in catalogs collection in _default scope
        internal async void CreateCatalog(Catalog c1)
        {
            int maxId = await GetMaxCatalogId();
            int newId = maxId + 1;
            c1.ID = newId;
            await _bucket.Scope("_default").Collection("catalogs").UpsertAsync(c1.ID.ToString(), c1);
        }

        // This method to retrieve all IDs from libraries collection to add this in comboBox
        public async Task<List<int>> GetLibraryIds()
        {
            try
            {
                var query = "SELECT id FROM Library._default.libraries";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query);

                var libraryIds = new List<int>();
                await foreach (var row in result)
                {
                    libraryIds.Add(Convert.ToInt32(row.id));
                }

                return libraryIds;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching library IDs: {ex.Message}");
            }
        }

        // This method is to retrieve the maximum ID in the patrons collection. When a new patron is added, the ID is increased
        public async Task<int> GetMaxPatronId()
        {
            var query = "SELECT MAX(id) AS maxId FROM Library._default.patrons";
            var result = await _bucket.Cluster.QueryAsync<dynamic>(query);

            await foreach (var row in result)
            {
                var maxId = row.maxId;
                if (maxId != null)
                {
                    return Convert.ToInt32(maxId);
                }
            }
            return 2400; // The ID start from 2401
        }

        // Create patron in Admin form and store in patrons collection in _default scope
        internal async void CreatePatron(Patronn p)
        {
            int maxId = await GetMaxPatronId();
            int newId = maxId + 1;
            p.ID = newId;
            await _bucket.Scope("_default").Collection("patrons").UpsertAsync(p.ID.ToString(), p);
        }

        // This method is to ensure that the username and password are present in the database and are correct
        public async Task<bool> LibrarianLogin(string usernameLib, int passwordLib)
        {
            try
            {
                var query = $"SELECT * FROM Library._default.librarians";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query);

                await foreach (var row in result.Rows)
                {
                    var librarian = row["librarians"];
                    if (librarian["username"] == usernameLib && librarian["password"] == passwordLib)
                    {
                        return true; // Login successful
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while authenticating: {ex.Message}");
                return false;
            }
        }
    }
}



