using CommonClassLibrary;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RepositoryInterfaces;
using System.ComponentModel;

namespace DbClassLibrary
{
    public class MyDbContext : DbContext, IRepository
    {
        /// <summary>
        /// Периодичность калибровки СИ
        /// </summary>
        [DisplayName("Таблица периодичности калибровки СИ")]
        public DbSet<CalibrationPeriod> CalibrationPeriods { get; set; } = null!;

        /// <summary>
        /// Типы средств измерений
        /// </summary>
        public DbSet<DeviceType> DeviceTypes { get; set; } = null!;

        /// <summary>
        /// Заводы производители
        /// </summary>
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;

        /// <summary>
        /// Единицы измерения
        /// </summary>
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; } = null!;

        /// <summary>
        /// Подразделения
        /// </summary>
        public DbSet<Department> Departments { get; set; } = null!;

        /// <summary>
        /// Состояние прибора
        /// </summary>
        public DbSet<DeviceState> DeviceStates { get; set; } = null!;


        /// <summary>
        /// Пользователи
        /// </summary>
        public DbSet<User> Users { get; set; } = null!;

        /// <summary>
        /// Поверители
        /// </summary>
        public DbSet<Calibrator> Calibrators { get; set; } = null!;

        /// <summary>
        /// Средства измерений
        /// </summary>
        public DbSet<MeasuringInstrument> MeasuringInstruments { get; set; } = null!;

        /// <summary>
        /// Калибровка
        /// </summary>
        public DbSet<Calibration> Calibrations { get; set; } = null!;


        /// <summary>
        /// Ремонт
        /// </summary>
        public DbSet<Repair> Repairs { get; set; } = null!;


        /// <summary>
        /// Перемещение СИ
        /// </summary>
        public DbSet<Moving> Movings { get; set; } = null!;


        /// <summary>
        /// Извещения о непригодности к применению
        /// </summary>
        public DbSet<Unsuitability> Unsuitabilities { get; set; } = null!;

        /// <summary>
        /// Свидетельства о поверке
        /// </summary>
        public DbSet<Сertificate> Сertificates { get; set; } = null!;

        /// <summary>
        /// Изображение СИ
        /// </summary>
        public DbSet<Photo> Photos { get; set; } = null!;



        /// <summary>
        /// Создать новую БД
        /// </summary>
        public void CreateNewDB()
        {
            Database.EnsureDeleted(); //удалить БД , если она есть на сервере
            Database.EnsureCreated(); //создать новую БД, если её нет
        }


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        //public MyDbContext()
        //{
        ///*    // CreateNewDB();

        //    var serverConnectionSettings = Conteiner.GetInstance().GetRepInstance<IServerConnectionSettings>();
        //    if (serverConnectionSettings == null) throw new NullReferenceException("Отсутствует зарегистрированный класс для " + nameof(IServerConnectionSettings));

        //    var option = serverConnectionSettings.GetDbContextOptionsBuilder<MyDbContext>();
        //    MyDbContext(option);
        //    //var info = serverConnectionSettings?.GetSettings();
        //*/
        //}


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="options"></param>
        public MyDbContext(DbContextOptions options)
            : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder
            //       //.UseLazyLoadingProxies()        // подключение lazy loading
            //       .UseSqlServer("Server=KOMP2021;Database=DbMeasuringDevices;Trusted_Connection=True;");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Сertificate>()
            .HasOne(p => p.MeasuringInstrument)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Calibration>()
            //.HasOne(p => p.MeasuringInstrument)
            //.WithMany()
            //.OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Calibration>()
   .HasOne(x => x.MeasuringInstrument)
   .WithMany(x => x.Calibrations)
   .HasForeignKey(x => x.MeasuringInstrumentId)
   .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Unsuitability>()
            .HasOne(p => p.MeasuringInstrument)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Moving>()
            .HasOne(p => p.TakeDepartment)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Moving>()
            .HasOne(p => p.GiveDepartment)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);




            modelBuilder.Entity<User>().Navigation(e => e.Department).AutoInclude();
            modelBuilder.Entity<Calibrator>().Navigation(e => e.Department).AutoInclude();
            modelBuilder.Entity<Calibration>().Navigation(e => e.Calibrator).AutoInclude();
            modelBuilder.Entity<Calibration>().Navigation(e => e.MeasuringInstrument).AutoInclude();
            modelBuilder.Entity<Moving>().Navigation(e => e.GiveDepartment).AutoInclude();
            modelBuilder.Entity<Moving>().Navigation(e => e.TakeDepartment).AutoInclude();
            modelBuilder.Entity<Сertificate>().Navigation(e => e.Calibrator).AutoInclude();
            modelBuilder.Entity<Unsuitability>().Navigation(e => e.Calibrator).AutoInclude();

            modelBuilder.Entity<MeasuringInstrument>().Navigation(e => e.Department).AutoInclude();
            modelBuilder.Entity<MeasuringInstrument>().Navigation(e => e.CalibrationPeriod).AutoInclude();
            modelBuilder.Entity<MeasuringInstrument>().Navigation(e => e.Manufacturer).AutoInclude();
            modelBuilder.Entity<MeasuringInstrument>().Navigation(e => e.DeviceType).AutoInclude();
            modelBuilder.Entity<MeasuringInstrument>().Navigation(e => e.MeasurementUnit).AutoInclude();
            modelBuilder.Entity<MeasuringInstrument>().Navigation(e => e.DeviceState).AutoInclude();
            modelBuilder.Entity<MeasuringInstrument>().Navigation(e => e.Photo).AutoInclude();

            //не работает , приводит к зависанию, похоже из-за зацикливания ссылок
            //  modelBuilder.Entity<CalibrationPeriod>().Navigation(e => e.MeasuringInstruments).AutoInclude();
            // modelBuilder.Entity<DeviceType>().Navigation(e => e.MeasuringInstruments).AutoInclude();
            //  modelBuilder.Entity<Manufacturer>().Navigation(e => e.MeasuringInstruments).AutoInclude();
            /*   modelBuilder.Entity<MeasurementUnit>().Navigation(e => e.MeasuringInstruments).AutoInclude();
               modelBuilder.Entity<Department>().Navigation(e => e.MeasuringInstruments).AutoInclude();
               modelBuilder.Entity<DeviceState>().Navigation(e => e.MeasuringInstruments).AutoInclude();
            */


            //Уникальность индексов
            // modelBuilder.Entity<CalibrationPeriod>().HasIndex(u => u.Period).IsUnique();

            //modelBuilder.Entity<CalibrationPeriod>(entity => {
            //    entity.HasIndex(e => e.Period).IsUnique();
            //});
        }




        //------------------------------------------------------------------





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
            set
            {
                isDbAvailable = value;
                // OnPropertyChanged();
            }
        }



        public async Task AddToDbAsync<T>(T item) where T : class
        {
            if (item == null) throw new ArgumentNullException("Не передан объект для добавления в БД :" + nameof(item));

            if (!CheckConnection())
            {
                //await Task.Delay(7000);
                throw new AccessViolationException("Добавить запись невозможно т.к. БД недоступна!");
            }

            try
            {
                // Debug.WriteLine("--DelSelectedProduct: " + Thread.CurrentThread.ManagedThreadId);

                //  using (MyDbContext db = new MyDbContext())
                {
                    this.Add(item);
                    //await this.AddAsync(item);

                    //db.SaveChanges();
                    await this.SaveChangesAsync();
                }
            }
            catch (DbUpdateException ex) when ((ex.InnerException as SqlException)?.Number == 2601)
            {
                // var exs = ex.InnerException as SqlException;

                //StringBuilder errorMessages = new StringBuilder();

                //for (int i = 0; i < exs.Errors.Count; i++)
                //{

                //    errorMessages.Append("Index #" + i + "\n" +
                //        "Message: " + exs.Errors[i].Message + "\n" +
                //        "LineNumber: " + exs.Errors[i].LineNumber + "\n" +
                //        "Source: " + exs.Errors[i].Source + "\n" +
                //        "Procedure: " + exs.Errors[i].Procedure + "\n");
                //}

                throw new ArgumentException("Невозможно добавить запись в БД, т.к. значение неуникальное: "
                                            + Environment.NewLine
                                            + ex?.InnerException?.Message);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw new IOException("При добавлении записи в БД возникла ошибка: " + ex.Message
                    + Environment.NewLine + "Внутренне исключение:" + ex?.InnerException?.Message);
                else
                    throw new IOException("При добавлении записи в БД возникла ошибка: " + ex.Message);
            }
        }


        public async Task<bool> UpdateInDbAsync<T>(T item) where T : class
        {
            if (item == null) throw new ArgumentNullException("Не передан объект, который надо изменить в БД :" + nameof(item));

            if (!CheckConnection())
                throw new AccessViolationException("Изменить невозможно т.к. БД недоступна!");

            try
            {
                // using (MyDbContext db = new MyDbContext())
                {
                    //проверяем есть ли в БД этот клиент - с таким же Id, как и у отредактированного
                    //if (!db.Set<T>().Contains(item))

                    //T? exist = await this.Set<T>().FindAsync(item);
                    //if (exist == null)
                    if (!this.Set<T>().Contains(item))
                    {
                        //await Task.Delay(7000);
                        //OnClientUpdated(this, EventArgs.Empty);
                        throw new AccessViolationException("Изменить невозможно т.к. записи уже нет в БД! \nДанные обновлены.");
                    }
                    else
                    {
                        this.Update(item);
                        // this.Entry(exist).CurrentValues.SetValues(item);

                        await this.SaveChangesAsync();
                        return true;
                        //db.Update(item);
                        //db.SaveChanges();
                    }
                }
                //OnClientUpdated(this, EventArgs.Empty);
            }
            catch (DbUpdateException ex) when ((ex.InnerException as SqlException)?.Number == 2601)
            {
                throw new ArgumentException("Невозможно изменить запись в БД, т.к. значение неуникальное: " + (ex?.InnerException?.Message));
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw new IOException("При изменении записи в БД возникла ошибка: " + ex.Message
                    + Environment.NewLine + "Внутренне исключение:" + ex?.InnerException?.Message);
                else
                    throw new IOException("При изменении записи в БД возникла ошибка: " + ex.Message);
            }

        }



        public void Find<T, B>(T item)
            where T : class, ICloneable
            where B : class
        {
            /*
                        //https://docs.microsoft.com/ru-ru/ef/ef6/saving/change-tracking/property-values
                        var entity = this.Entry<T>(item).Property("Id").CurrentValue;

                        //entity.CurrentValues.SetValues(entity.OriginalValues);
                        //entity.State = EntityState.Unchanged;

                        this.Model.FindEntityType(clrEntityType);

                        var es = this.Set<B>();
                        var r = es.GetType().GetProperties(). //.Where(p => p.PropertyType == typeof(B)).ToList().ForEach(p => p.Name);

                        int i = 1;
                        foreach (var prop in r)
                        {
                            Debug.Print(i+") "+prop.Name);
                            i++;
                        }
            */
        }








        //public async void DeleteInDb<T>(T item) where T : class
        public async Task<bool> DeleteInDbAsync<T>(T item) where T : class
        {
            if (item == null)
                throw new ArgumentNullException("Не передан объект, который надо удалить в БД :" + nameof(item));

            if (!CheckConnection())
                throw new AccessViolationException("Удалить объект невозможно т.к. БД недоступна!");

            try
            {
                //using (MyDbContext db = new MyDbContext())
                {

                    // if (!db.Set<T>().Contains(item))
                    if (!this.Set<T>().Contains(item))
                    {
                        // OnClientUpdated(this, EventArgs.Empty);
                        throw new AccessViolationException("Удалить объект невозможно т.к. его уже нет в БД! \nДанные обновлены.");
                    }

                    //удаляем объект
                    this.Remove(item);
                    await this.SaveChangesAsync();
                    return true;
                    //db.Remove(item);
                    //db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new IOException("При удалении из БД возникла ошибка: " + ex.Message);
            }
        }



        //public IEnumerable<T> ReadFromDb<T>() where T : class

        public async Task<List<T>> ReadFromDbAsync<T>() where T : class
        {


            if (!CheckConnection())
                throw new AccessViolationException("Данные получить невозможно т.к. БД недоступна!");

            try
            {
                if (typeof(IMiDependence).IsAssignableFrom(typeof(T)))
                {
                    //todo загружает все СИ, надо переделать чтобы фильтровал
                    //пришлось сделать так, т.к. не работает
                    //modelBuilder.Entity<CalibrationPeriod>().Navigation(e => e.MeasuringInstruments).AutoInclude();
                    //вызывает зацикливание
                    //this.MeasuringInstruments.Load();

                    //подгружаем только нужные СИ
                    //var list2 = await this.Set<T>().Include("MeasuringInstruments").ToListAsync(); //Async
                    var list2 = await this.Set<T>().Include(nameof(MeasuringInstruments)).ToListAsync(); //Async
                    return list2;
                }


                var list = await this.Set<T>().ToListAsync(); //Async

                return list;

            }
            catch (Exception ex)
            {
                throw new IOException("При чтении данных из БД возникла ошибка: " + ex.Message);
            }
        }

        /// <summary>
        /// Отмена изменений
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        public void UnChanged<T>(T item) where T : class
        {
            var entity = this.Entry<T>(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;
        }






        public List<T> ReadFromDb<T>(Func<T, bool> predicate) where T : class
        {
            if (!CheckConnection())
                throw new AccessViolationException("Данные получить невозможно т.к. БД недоступна!");

            try
            {
                //using (DBMagazineContext db = new DBMagazineContext(Options))
                // using (MyDbContext db = new MyDbContext())
                {
                    //return db.Set<T>().ToList();

                    //todo сделать выборку НЕ всеех записей - д.б. выборка на стороне сервера 
                    var list = this.Set<T>().Where(predicate).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw new IOException("При чтении данных из БД возникла ошибка: " + ex.Message);
            }
        }










        /*

        public async Task UpdateInDbAsync<T> (T item) where T : class
        {
            if (item == null) throw new ArgumentNullException("Не передан объект, который надо изменить в БД :" + nameof(item));

            if (!CheckConnection())
            {
                throw new AccessViolationException("Изменить невозможно т.к. БД недоступна!");
            }

            try
            {
                // using (MyDbContext db = new MyDbContext())
                {
                    //проверяем есть ли в БД этот клиент - с таким же Id, как и у отредактированного
                    //if (!db.Set<T>().Contains(item))

                    var exist= this.Set<T>().ContainsAsync(item);
                    //var exist2 = await this.Set<T>().FindAsync(item);

                    if (exist.Result ==false)
                    {
                        //OnClientUpdated(this, EventArgs.Empty);
                        throw new AccessViolationException("Изменить невозможно т.к. записи уже нет в БД! \nДанные обновлены.");
                    }

                    this.Update(item);
                    await this.SaveChangesAsync();
                    //db.Update(item);
                    //db.SaveChanges();
                }
                //OnClientUpdated(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                throw new IOException("При изменении в БД возникла ошибка: " + ex.Message);
            }
        }


        */







        /// <summary>
        /// Проверка доступности (наличия соединения) БД
        /// </summary>
        /// <returns>true - БД доступна. false - БД недоступна</returns>
        public bool CheckConnection()
        {
            try
            {
                // using (MyDbContext db = new MyDbContext())
                //using (DBMagazineContext db = new DBMagazineContext(Options))
                {
                    IsDbAvailable = this.Database.CanConnect();
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