using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryInterfaces
{
    public interface IRepository: IDisposable
    {
        /// <summary>
        /// Свойство. Показывает доступна ли БД
        /// </summary>
        public bool IsDbAvailable {  get; set; }


        //public void AddToDb<T>(T item) where T : class;
        public Task AddToDbAsync<T>(T item) where T : class;



        //public void UpdateInDb<T>(T item) where T : class;
        public Task<bool> UpdateInDbAsync<T>(T item) where T : class;



        //public IEnumerable<T> ReadFromDb<T>() where T : class;
        public Task<List<T>> ReadFromDbAsync<T>() where T : class;

        //public Task<List<T>> ReadFromDbAsync<T>(Func<T, bool> predicate) where T : class;
        public List<T> ReadFromDb<T>(Func<T, bool> predicate) where T : class;





        public Task<bool> DeleteInDbAsync<T>(T item) where T : class;

        /*
        public IEnumerable<T> FindAll();
        public IEnumerable<T> FindByName(string name);
        public IEnumerable<T> FindById(int id);
        */


        public void UnChanged<T>(T item) where T : class;


       // public void Find<T, B>(T item);
    }
}
