using ViewInterfaces;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Класс отвечает за вывод окна сообщения о необходимости подождать завершения выполняемой операции
    /// </summary>
    public class WaitWindow : IWaitWindow
    {
        /// <summary>
        /// счётчик
        /// </summary>
        int n = 0;

        /// <summary>
        /// Окно с сообщение о необходимости подождать завершения текущей операции
        /// </summary>
        readonly FormWait formWait = new FormWait();

        /// <summary>
        /// Таймер
        /// </summary>
        readonly System.Windows.Forms.Timer timer;

        /// <summary>
        /// Флаг, показывает кто хочет закрыть окно.
        /// true- я сам(программа) хочу закрыть окно.
        /// false - пользователь пытается закрыть окно
        /// </summary>
        bool iWantCloseForm = false;

        /// <summary>
        /// Конструктор
        /// </summary>
        public WaitWindow()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;

            formWait.FormClosing += ExecuteFormClosingEvent;
        }

        SynchronizationContext? _SyncContext;
        public void Run(SynchronizationContext? SyncContext)
        {
            _SyncContext = SyncContext;

            if (_SyncContext == null) //если НЕ передан контекст потока
            { //тогда выполняем в этом же потоке
                timer.Enabled = true;
                formWait.ShowDialog();
            }
            else //если контекст передан, тогда выполняем в потоке контекста
                _SyncContext.Send(state =>
            {
                timer.Enabled = true;
                formWait.ShowDialog();
            }, null);
        }



        /// <summary>
        /// Выполняем обработку события "Закрытие формы"
        /// </summary>
        private void ExecuteFormClosingEvent(object? sender, FormClosingEventArgs e)
        {
            if (iWantCloseForm) return;
            e.Cancel = true;// если пользователь пытается закрыть окно, отменяем действие пользователя
        }




        // обработчик события Tick таймера
        private void timer1_Tick(object? sender, EventArgs e)
        {
            n++;
            
            if (_SyncContext == null) formWait.progressBar1.Value = n;
            else _SyncContext?.Send(state => formWait.progressBar1.Value = n, null);

            if (n == 100) n = 1;
        }


        public void CloseWindow()
        {
            if (_SyncContext == null) //если НЕ передан контекст потока
            {
                timer.Stop();
                iWantCloseForm = true;
                formWait.Close();
            }
            else
            {
                _SyncContext.Send(state =>
                {
                    timer.Stop();
                    iWantCloseForm = true;
                    formWait.Close();
                }, null);

            }
        }

    }
}
