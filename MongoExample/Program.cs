using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace MongoExample
{
    class Program
    {
        static string dbName = "Notes";
        static string collectionName = "NotesList";

        static void Main(string[] args)
        {
            string connectionString =
              @"mongodb://yourazureconnection";

            MongoClientSettings settings = MongoClientSettings.FromUrl(
              new MongoUrl(connectionString)
            );

            settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            var mongoClient = new MongoClient(settings);

            var database = mongoClient.GetDatabase(dbName);
            var NotesCollection = database.GetCollection<NoteModel>(collectionName);

            ShowSearch(NotesCollection);
        }

        static void InsertRecords(IMongoCollection<NoteModel> collection)
        {
            collection.InsertOne(new NoteModel() { Body = "Test1 Body", Title = "Test1" });
            collection.InsertMany(new List<NoteModel>()
            {
                new NoteModel() { Body = "Test2 Body", Title = "Test2" },
                new NoteModel() { Body = "Test3 Body", Title = "Test3" },
            });
        }

        static async Task ShowSearch(IMongoCollection<NoteModel> collection)
        {
            var completedStatusDocumentsFilter = Builders<NoteModel>.Filter.Where(document => document.Title.Contains("Test1"));

            var statusDocuments = collection.Find(completedStatusDocumentsFilter).ToList();

            foreach (var note in statusDocuments)
            {
                Console.WriteLine(note.Id + "\t" + note.Title);
            }
            Console.ReadKey();
        }
    }
}