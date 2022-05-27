using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс формы главного окна
    /// </summary>
    public interface IMainFormView:IView
    {
        /// <summary>
        /// Показать Базу данных СИ
        /// </summary>
        public event EventHandler ShowMeasuringInstrument;

        /// <summary>
        /// Показать паспорт
        /// </summary>
        public event EventHandler ShowPasports;

        /// <summary>
        /// Показать Извещения о непригодности
        /// </summary>
        public event EventHandler ShowUnsuitability;

        /// <summary>
        /// Показать Свидетельства о поверке
        /// </summary>
        public event EventHandler ShowСertificate;
        

        /// <summary>
        /// Показать Накладные на перемещения
        /// </summary>
        public event EventHandler ShowMovement;
        

        /// <summary>
        /// Показать сводки
        /// </summary>
        public event EventHandler ShowSummaries;

        /// <summary>
        /// Показать отчёты
        /// </summary>
        public event EventHandler ShowReports;













        /// <summary>
        /// Показать справочник
        /// </summary>
        public event EventHandler ShowManual;

        /// <summary>
        /// Показать пользователей
        /// </summary>
        public event EventHandler ShowUsers;

        /// <summary>
        /// Показать Помощь
        /// </summary>
        public event EventHandler ShowHelp;

        /// <summary>
        /// Показать информацию о программе
        /// </summary>
        public event EventHandler ShowAboutProgram;

        /// <summary>
        /// Показать Периоды калибровки
        /// </summary>
        public event EventHandler ShowCalibrationPeriod;

        /// <summary>
        /// Показать  Типы СИ
        /// </summary>
        public event EventHandler ShowDeviceType;

        /// <summary>
        /// Показать Заводы изготовители
        /// </summary>
        public event EventHandler ShowManufacturer;

        /// <summary>
        /// Показать Единицы измерения
        /// </summary>
        public event EventHandler ShowMeasurementUnit;

        /// <summary>
        /// Показать Подразделения/Местоположения
        /// </summary>
        public event EventHandler ShowDepartment;

        /// <summary>
        /// Показать Список допустимых состояний СИ
        /// </summary>
        public event EventHandler ShowDeviceState;


        /// <summary>
        /// Показать Список поверителей
        /// </summary>
        public event EventHandler ShowCalibrators;

        /// <summary>
        /// Открыть окно для ввода нового логина и пароля администратора
        /// </summary>
        public event EventHandler ChangingAdminLogin;

        /// <summary>
        /// Открыть окно для редактирования настроек сервера БД
        /// </summary>
        public event EventHandler ChangingServerSettings;

        /// <summary>
        /// Сделать недоступными пункты меню
        /// </summary>
        public void CloseMenu();



        /// <summary>
        /// Вывод информации о пользователе
        /// </summary>
        /// <param name="info"></param>
        public void ShowInfoAboutUser(string info);

        /// <summary>
        /// Вывод информации о БД, с которой работаем
        /// </summary>
        /// <param name="info"></param>
        public void ShowInfoAboutDB(string info);


        /// <summary>
        /// Сделать доступными меню для работы с БД
        /// </summary>
        public void ActivateDbWorkMenu();
        
        /// <summary>
        /// Сделать недоступными меню для работы с БД
        /// </summary>
        public void BlockWorkDbMenu();

    }
}
