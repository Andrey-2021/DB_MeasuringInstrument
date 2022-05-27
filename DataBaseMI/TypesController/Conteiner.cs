namespace TypesController
{
    public class Conteiner
    {
        /// <summary>
        /// Словарь зарегистрированных типов
        /// </summary>
        Dictionary<Type, Type> _registeredTypes = new Dictionary<Type, Type>();

        /// <summary>
        /// Единственный экземпляр этого класса  
        /// </summary>
        private static Conteiner instance;

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

        /// <summary>
        /// Решистрация пары Interface И Class
        /// </summary>
        public void Register<TInterface, TConcrete>() where TConcrete : class
        {
            var interfaceType = typeof(TInterface);

            if (!interfaceType.IsInterface) throw new ArgumentException("Попытка регистрации неизвестного типа! Должен быть интерфейс!");

            if (_registeredTypes.ContainsKey(interfaceType))
            {
                //throw new InvalidOperationException($"Тип {vmType.FullName} уже был зарегистрирован");
                
                _registeredTypes.Remove(interfaceType); //удалили
            }
            _registeredTypes[interfaceType] = typeof(TConcrete);
        }



        /// <summary>
        /// Создать экземпляр 
        /// </summary>
        /// <param name="interfaceName">ViewModel, для которой нужно создать экземпляр окно</param>
        /// <returns></returns>
        //private Object?  GetInstance(Type interfaceName)
         private Object? GetInstance(Type interfaceName)
        {
            //if (viewModel == null) throw new ArgumentNullException("ViewModel == null");

            //var viewModelType = viewModel.GetType();
            if (!_registeredTypes.ContainsKey(interfaceName)) 
                throw new ArgumentException($"Этот тип {interfaceName.FullName} не зарегистрирован!");

            Type instanceType = null;
            _registeredTypes.TryGetValue(interfaceName, out instanceType);

            if (instanceType == null) 
                throw new ArgumentException($"Не зарегистрирован тип соответствующий входящему типу {interfaceName.FullName}");

            var instance = Activator.CreateInstance(instanceType);

            return instance;
        }

    }
}