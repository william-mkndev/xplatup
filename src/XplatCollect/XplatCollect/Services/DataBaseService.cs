using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;

namespace XplatCollect.Services
{
    public class DataBaseService<TModel> : IDataBaseService<TModel>
    {
        private readonly IDataBaseAccessService dataBaseAccessService;

        public DataBaseService(IDataBaseAccessService dataBaseAccessService)
        {
            this.dataBaseAccessService = dataBaseAccessService;
        }

        public void Create(List<TModel> items)
        {
            using (var db = new LiteDatabase(DbPath()))
            {
                var collection = db.GetCollection<TModel>();
                collection.InsertBulk(items);
            }
        }

        public void Create(TModel item)
        {
            using (var db = new LiteDatabase(DbPath()))
            {
                var collection = db.GetCollection<TModel>();
                collection.Insert(item);
            }
        }

        public List<TModel> GetAll()
        {
            using (var db = new LiteDatabase(DbPath()))
            {
                var collection = db.GetCollection<TModel>();
                return collection.FindAll().ToList();
            }
        }

        public List<TModel> Filter(Func<TModel, bool> predicate)
        {
            using (var db = new LiteDatabase(DbPath()))
            {
                var collection = db.GetCollection<TModel>();
                return collection.FindAll().Where(predicate).ToList();
            }
        }

        private string DbPath()
            => dataBaseAccessService.GetDataBasePath();
    }
}
