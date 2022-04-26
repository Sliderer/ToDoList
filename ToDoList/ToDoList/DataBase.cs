using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Diagnostics;
using MongoDB.Bson;

namespace ToDoList
{
    class DataBase
    {
        public static string connectionURL = "mongodb+srv://SlideDru8gs:Aa05072004@todolist.tkuiq.mongodb.net/ToDoList?retryWrites=true&w=majority";
        public static string dataBaseName = "ToDoList";

        private MongoDB dataBase;

        public DataBase()
        {
            dataBase = new MongoDB();
        }

        public void AddNote(Note note)
        {
            dataBase.Insert("Notes", note);   
        }
    }

    class MongoDB {
        private IMongoDatabase dataBase;

        public MongoDB()
        {
            var settings = MongoClientSettings.FromConnectionString(DataBase.connectionURL);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            dataBase = client.GetDatabase(DataBase.dataBaseName);
        }

        public void Insert<T>(string collectionName, T obj)
        {
            var collection = dataBase.GetCollection<T>(collectionName);
            collection.InsertOne(obj);
        }
    }
}
