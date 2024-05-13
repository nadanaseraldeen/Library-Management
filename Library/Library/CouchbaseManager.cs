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
using System.Net;
using Couchbase.Core.IO.Operations;
using Newtonsoft.Json;

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
            return 0; //The ID start from 1
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
        
        // This method is to retrieve the maximum ID in the books collection. When a new book is added, the ID is increased
        public async Task<int> GetMaxBookId()
        {
            var query = "SELECT MAX(bookID) AS maxId FROM Library._default.books";
            var result = await _bucket.Cluster.QueryAsync<dynamic>(query);

            await foreach (var row in result)
            {
                var maxId = row.maxId;
                if (maxId != null)
                {
                    return Convert.ToInt32(maxId);
                }
            }
            return 0; //The ID start from 1
        }

        // Create book in librarian form and store in books collection in _default scope
        internal async void CreateBook(BookItem b)
        {
            int maxId = await GetMaxBookId();
            int newId = maxId + 1;
            b.BookID = newId;
            b.PatronID = null;
            await _bucket.Scope("_default").Collection("books").UpsertAsync(b.BookID.ToString(), b);
        }

        // This method to retrieve all IDs from catalogs collection to add this in comboBox
        public async Task<List<int>> GetCatalogIds()
        {
            try
            {
                var query = "SELECT id FROM Library._default.catalogs";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query);
                var catalogsIds = new List<int>();
                await foreach (var row in result)
                {
                    catalogsIds.Add(Convert.ToInt32(row.id));
                }

                return catalogsIds;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching catalog IDs: {ex.Message}");
            }
        }

        // This method to retrieve all IDs from books collection to add this in comboBox
        public async Task<List<int>> GetBookIds()
        {
            try
            {
                var query = "SELECT bookID FROM Library._default.books";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query);
                var booksIds = new List<int>();
                await foreach (var row in result)
                {
                    booksIds.Add(Convert.ToInt32(row.bookID));
                }

                return booksIds;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching book IDs: {ex.Message}");
            }
        }

        // Method to retrieve a specified doc to update
        internal async Task<dynamic> GetDocumentUpdateById(string selectedBookId)
        {
                var query = $"SELECT * FROM Library._default.books";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query, QueryOptions.Create().Parameter(selectedBookId));

                await foreach (var row in result.Rows)
                {
                    var book = row["books"];
                    if (book["bookID"] == selectedBookId)
                    {
                        return row;
                    }
                }
                return null;
        }

        // To upload the update doc to the database in books collection
        internal async Task UpdateDocument(string selectedBookId, BookItem book)
        {
            var result = await _bucket.Scope("_default").Collection("books").UpsertAsync(selectedBookId, book);
        }

        // Method to retrieve a specified doc to delete
        internal async Task<bool> GetDocumentRemById(string selectedBookId)
        {
              var query = $"SELECT * FROM Library._default.books WHERE bookID = {selectedBookId}";
              var result = await _bucket.Cluster.QueryAsync<dynamic>(query);

              await foreach (var row in result.Rows)
              {
                      return true; 
              }
              return false;
        }

        // To delete a book from the database in the book collection
        internal async Task RemoveDocument(string documentId)
        {
            await _bucket.Scope("_default").Collection("books").RemoveAsync(documentId);
        }

        // To search for a book by its title or ISBN
        internal async Task<bool> BookExists(string bookTitleOrISBN)
        {       
                var query = $"SELECT title,isbn FROM Library._default.books WHERE title = '{bookTitleOrISBN}' OR isbn = '{bookTitleOrISBN}'";
                 var result = await _bucket.Cluster.QueryAsync<dynamic>(query, QueryOptions.Create().Parameter(bookTitleOrISBN));

                await foreach (var row in result.Rows)
                {
                        return true;
                }
                return false;             
        }

        // Retrieve the author name of a specific book
        public async Task<List<string>> GetAuthorForBook(string bookID)
        {          
                var query = $"SELECT authorName FROM Library._default.books WHERE bookID = {bookID}";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query, QueryOptions.Create().Parameter(bookID));
                var authors = new List<string>();

                await foreach (var row in result.Rows)
                {
                    var authorName = row["authorName"]?.ToString(); 
                    if (!string.IsNullOrEmpty(authorName))
                    {
                        authors.Add(authorName); 
                    }
                }
                return authors;        
        }

        // Retrieve the names of books in English
        public async Task<List<string>> GetEnglishBookTitles()
        {
                var query = "SELECT title FROM `Library`.`_default`.`books` WHERE `language` = 'English'";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query);
                var englishTitles = new List<string>();

                await foreach (var row in result.Rows)
                {
                    string title = row["title"].ToString(); 
                    englishTitles.Add(title);
                }
                return englishTitles;
        }

        // This method to retrieve all IDs from patrons collection to add this in comboBox
        public async Task<List<int>> GetPatronIds()
        {
            try
            {
                var query = "SELECT id FROM Library._default.patrons";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query);
                var patronsIds = new List<int>();
                await foreach (var row in result)
                {
                    patronsIds.Add(Convert.ToInt32(row.id));
                }

                return patronsIds;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching patron IDs: {ex.Message}");
            }
        }

        // Method to retrieve a specified doc in patrons collection to update
        internal async Task<dynamic> GetDocumentPatronUpdateById(string selectedPatronId)
        {
                var query = $"SELECT * FROM Library._default.patrons WHERE id = {selectedPatronId}";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query, QueryOptions.Create().Parameter(selectedPatronId));
                await foreach (var row in result.Rows)
                {
                    return row;
                }
                return null;
        }

        // To upload the update doc to the database in patrons collection
        internal async Task UpdatePatronDocument(string selectedPatronId, Patronn p)
        {
            var result = await _bucket.Scope("_default").Collection("patrons").UpsertAsync(selectedPatronId, p);
        }

        //Method of retrieving a specific document to borrow for a specific patron
        internal async Task<dynamic> GetDocumentBorrow(string bookID)
        { 
                var query = $"SELECT * FROM Library._default.books";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query, QueryOptions.Create().Parameter(bookID));

                await foreach (var row in result.Rows)
                {
                    var book = row["books"];
                    if (book["bookID"] == bookID)
                    {
                        return row;
                    }
                }
                return null;  
        }

        // To update the book doc to add the borrower ID for this book
        public async Task UpdateBorrowDocument(string bookId, string patronId)
        {
                var document = await GetDocumentBorrow(bookId);
                if (document == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

               dynamic book = document;
               var bookItem = new BookItem
                {
                    PatronID = Convert.ToInt32(patronId)
                };

                // Update only PatronID
                book["books"]["patronID"] = bookItem.PatronID;
                var result = await _bucket.Scope("_default").Collection("books").UpsertAsync(bookId, book["books"]);

                MessageBox.Show($"Book with ID: {bookId} borrowed successfully.");
        }

        // To update the book doc to remove the borrower ID for this book
        internal async Task UnborrowDocument(string bookId)
        {
                var document = await GetDocumentBorrow(bookId);
                if (document == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                dynamic book = document;
                book["books"]["patronID"] = null;
                var result = await _bucket.Scope("_default").Collection("books").UpsertAsync(bookId, book["books"]);    
                MessageBox.Show($"Book with ID: {bookId} unborrowed successfully.");
        }

        // Retrieve all patron names from patrons collection
        public async Task<List<string>> GetPatronNames()
        {
              var query = $"SELECT name FROM Library._default.patrons";
              var result = await _bucket.Cluster.QueryAsync<dynamic>(query);
              var patrons = new List<string>();

              await foreach (var row in result.Rows)
              {
                  var patronName = row["name"]?.ToString(); 
                  if (!string.IsNullOrEmpty(patronName))
                  {
                      patrons.Add(patronName); 
                  }
              }
              return patrons;
        }

        // This method to retrieve all author names from books collection to add this in comboBox
        public async Task<List<string>> GetAuthorNames()
        {
            try
            {
                var query = "SELECT authorName FROM Library._default.books";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query);
                var authorNames = new HashSet<string>(); // HashSet<string> to avoid adding duplicate author names

                await foreach (var row in result.Rows)
                {
                    string authorName = row["authorName"].ToString(); 
                    authorNames.Add(authorName);
                }
                return authorNames.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching author names: {ex.Message}");
            }
        }

        // Retrieve the title of books by a specific author
        public async Task<List<string>> GetBooksByAuthor(string selectAuthorName)
        {
                var query = $"SELECT title FROM Library._default.books WHERE authorName = '{selectAuthorName}'";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query);

                var bookTitles = new List<string>();
                await foreach (var row in result.Rows)
                {
                    string title = row["title"].ToString(); 
                    bookTitles.Add(title);
                }
                return bookTitles;
        }

        // Retrieve the names of patrons whose account status is frozen
        public async Task<List<string>> GetFrozenPatronNames()
        {
                var query = "SELECT name FROM Library._default.patrons WHERE state = 'Frozen'";
                var result = await _bucket.Cluster.QueryAsync<dynamic>(query);
                var frozenPatronNames = new List<string>();

                await foreach (var row in result.Rows)
                {
                    string name = row["name"].ToString(); 
                    frozenPatronNames.Add(name);
                }
                return frozenPatronNames;
        }

 
    }
}




