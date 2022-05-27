using CommonInterface;
using ViewInterfaces;
using ViewInterfaces.Common;

namespace ConteinerLibrary
{
    /// <summary>
    /// Контейнер
    /// </summary>
    public class Conteiner
    {
        /// <summary>
        /// Единственный экземпляр этого класса  
        /// </summary>
        private static Conteiner? instance;

        /// <summary>
        /// Конструктор
        /// </summary>
        private Conteiner()
        {
        }
        /// <summary>
        /// Получить экземпляр этого класса 
        /// </summary>
        /// <returns>экземпляр этого класса </returns>
        public static Conteiner GetInstance()
        {
            if (instance == null)
                instance = new Conteiner();
            return instance;
        }


        #region -----------------------   Формы --------------------------------------------------------

        /// <summary>
        /// Словарь зарегистрированных типов
        /// </summary>
        Dictionary<Type, Type> _registeredForms = new Dictionary<Type, Type>();

        /// <summary>
        /// Регистрация пары Interface И Class
        /// </summary>
        public void RegisterForm<TKey, TForm>() where TForm : IView
        {
            var keyType = typeof(TKey);
            if (typeof(TForm).IsInterface) throw new ArgumentException($"Попытка регистрации интерфейса { typeof(TForm)} в качестве Формы! Должен быть class!");
            
            if (_registeredForms.ContainsKey(keyType)) //если в словаре уже есть пара с таким ключом, тогда
                _registeredForms.Remove(keyType); //удаляем её

            _registeredForms[keyType] = typeof(TForm); //сохранение (регистрация) пары в словаре(Dictionary)
        }

        /// <summary>
        /// Получить экземпляр формы (окна)
        /// </summary>
        /// <typeparam name="TKey">Запрашиваемый тип формы</typeparam>
        /// <returns>Экземпляр формы</returns>
        public TKey? GetFormInstance<TKey>() where TKey : IView
        {
            var keyType = typeof(TKey);
            if (!keyType.IsInterface)
                throw new ArgumentException($"Попытка передачи в качестве интерфейса типа {keyType}! \nTInterface - должен быть интерфейс!");
            if (!_registeredForms.ContainsKey(keyType))
                throw new ArgumentException($"Этот тип {keyType.FullName} не зарегистрирован!");

            Type? instanceType = null;
            _registeredForms.TryGetValue(keyType, out instanceType); //пытаемся получить из Словаря для запрашеваемого типа TKey, соответствующий ему тип
            if (instanceType == null) //если получить не удалось
                throw new ArgumentException($"Не зарегистрирован тип соответствующий входящему типу {keyType.FullName}");

            var instance = Activator.CreateInstance(instanceType); //Создаём экземпляр класса
            

            return (TKey?)instance;
        }

        /// <summary>
        /// Получить экземпляр формы (окна), которая используется для ввода новых данных или редактирования выбранных данных
        /// </summary>
        /// <typeparam name="TClass">Запрашиваемы тип формы</typeparam>
        /// <param name="args">Аргументы передаваемые в конструктор создаваемого класса формы</param>
        /// <returns>Экземпляр окна(Form)</returns>
        public IDbBaseViewForAddOrEdit<TClass>? GetAddOrEditFormInstance<TClass>(params object?[]? args)
        {
            var interfaceType = typeof(TClass);
            Type? instanceType = null;
            _registeredForms.TryGetValue(interfaceType, out instanceType);

            if (instanceType == null) //если для этого типа нет своего отдельного Презентера AddOrEdit
                throw new ArgumentException($"Не зарегистрирован тип соответствующий входящему типу {interfaceType.FullName}");
            //    return null;

            var instance = Activator.CreateInstance(instanceType, args);
            return (IDbBaseViewForAddOrEdit<TClass>?)instance;
        }
        #endregion


        #region -----------------------   Другие классы --------------------------------------------------------

        /// <summary>
        /// Словарь зарегистрированных типов
        /// </summary>
        Dictionary<Type, Type> _registeredClasses = new Dictionary<Type, Type>();

        /// <summary>
        /// Регистрация пары классов
        /// </summary>
        public void ClassRegister<TInterface, TConcrete>()
        {
            var interfaceType = typeof(TInterface);

            if (_registeredClasses.ContainsKey(interfaceType)) //Если в словаре уже зарегистрирован такой ключ
                _registeredClasses.Remove(interfaceType); //удалили запись

            _registeredClasses[interfaceType] = typeof(TConcrete); //ркгистрируем пару
        }

        /// <summary>
        /// Создать экземпляр класса
        /// </summary>
        /// <typeparam name="Tclass">Тип запрашиваемого класса</typeparam>
        /// <param name="args">Аргументы передаваемые в конструктор создаваемого экземпляра класса</param>
        /// <returns>Экземпляр класса</returns>
        public Tclass? GetClassInstance<Tclass>(params object?[]? args)
        {
            var interfaceType = typeof(Tclass);
            Type? instanceType = null;
            _registeredClasses.TryGetValue(interfaceType, out instanceType);

            if (instanceType == null)
                throw new ArgumentException($"Не зарегистрирован тип соответствующий входящему типу {interfaceType.FullName}");

            var instance = Activator.CreateInstance(instanceType, args);//Создаём экземпляр класса
            return (Tclass?)instance;
        }


        /// <summary>
        /// Создать экземпляр Presentera для запрашиваемого типа
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="args">Аргументы передаваемые в конструктор создаваемого экземпляра класса</param>
        /// <returns>Экземпляр класса или null, если создать экземпляр не удалось</returns>
        public IPresenterForAddOrEdit<TClass>? GetAddOrEditPresenterInstance<TClass>(params object?[]? args)
        {
            var interfaceType = typeof(TClass);
            Type? instanceType = null;
            _registeredClasses.TryGetValue(interfaceType, out instanceType);

            if (instanceType == null) //если для этого типа нет своего отдельного Презентера AddOrEdit
                return null;
            //throw new ArgumentException($"Не зарегистрирован тип соответствующий входящему типу {interfaceType.FullName}");

            var instance = Activator.CreateInstance(instanceType, args);
            return (IPresenterForAddOrEdit<TClass>?)instance;
        }
        #endregion
    }
}
