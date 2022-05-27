using DbClassLibrary;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DbRepository<T> where T : class // IBaseRepository<T> where T:class
    {

        /// <summary>
        /// Флаг, показывает доступна ли БД
        /// </summary>
        bool isDbAvailable = false;

        /// <summary>
        /// Свойство. Показывает доступна ли БД
        /// </summary>
        public bool IsDbAvailable
        {
            get
            {
                return isDbAvailable;
            }
            private set
            {
                isDbAvailable = value;
                // OnPropertyChanged();
            }
        }



        public DbRepository()
        {

        }


        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException("Не передан объект для добавления в БД :"+nameof(item));

            if (!CheckConnection())
            {
                throw new AccessViolationException("Добавить запись невозможно т.к. БД недоступна!");
            }

            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.Add(item);

                 //   db.CalibrationPeriods.AddAsync(record);
                    db.SaveChanges();
                    //OnClientUpdated(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                throw new IOException("При добавлении записи в БД возникла ошибка: " + ex.Message);
            }

        }



        public void Delete(T item)
        {
            if (item == null) throw new ArgumentNullException("Не передан объект, который надо удалить в БД :" + nameof(item));

            if (!CheckConnection())
            {
                throw new AccessViolationException("Удалить объект невозможно т.к. БД недоступна!");
            }

            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    if (!db.Set<T>().Contains(item))
                    {
                        // OnClientUpdated(this, EventArgs.Empty);
                        throw new AccessViolationException("Удалить объект невозможно т.к. его уже нет в БД! \nДанные обновлены.");
                    }

                    db.Remove(item);
                    db.SaveChanges();
                    //OnClientUpdated(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                throw new IOException("При удалении из БД возникла ошибка: " + ex.Message);
            }
        }

        public IEnumerable<T> Read()
        {
            if (!CheckConnection())
                throw new AccessViolationException("Данные получить невозможно т.к. БД недоступна!");

            try
            {
                //using (DBMagazineContext db = new DBMagazineContext(Options))
                using (MyDbContext db = new MyDbContext())
                {
                    return db.Set<T>().ToList();
                    //listFromDB = db.CalibrationPeriods.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new IOException("При чтении данных из БД возникла ошибка: " + ex.Message);
            }
        }

        public void Update(T item)
        {
            if (item == null) throw new ArgumentNullException("Не передан объект, который надо изменить в БД :" + nameof(item));

            if (!CheckConnection())
            {
                throw new AccessViolationException("Изменить невозможно т.к. БД недоступна!");
            }

            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    //проверяем есть ли в БД этот клиент - с таким же Id, как и у отредактированного
                    if (!db.Set<T>().Contains(item))
                    {
                        //OnClientUpdated(this, EventArgs.Empty);
                        throw new AccessViolationException("Изменить невозможно т.к. записи уже нет в БД! \nДанные обновлены.");
                    }

                    db.Update(item);
                    db.SaveChanges();
                }
                //OnClientUpdated(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                throw new IOException("При изменении в БД возникла ошибка: " + ex.Message);
            }
        }



        /// <summary>
        /// Проверка доступности (наличия соединения) БД
        /// </summary>
        /// <returns>true - БД доступна. false - БД недоступна</returns>
        public bool CheckConnection()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                //using (DBMagazineContext db = new DBMagazineContext(Options))
                {
                    IsDbAvailable = db.Database.CanConnect();
                }

                return IsDbAvailable;
            }
            catch (Exception) //если произошла какая-то ошибка
            {
                IsDbAvailable = false;
                return false;
            }
        }
    }
}
