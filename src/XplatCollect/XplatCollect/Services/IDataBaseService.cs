using System;
using System.Collections.Generic;

namespace XplatCollect.Services
{
    public interface IDataBaseService<TModel>
    {
        void Create(List<TModel> items);
        void Create(TModel item);
        List<TModel> GetAll();
        List<TModel> Filter(Func<TModel, bool> predicate);
    }
}