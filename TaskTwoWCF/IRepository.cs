using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoWCF
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        void CreateTable();
        void CreateItem(T item);
        void UpdateItem(T item);
        void Save();
    }
}
