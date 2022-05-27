using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewInterfaces;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Форма для редактирования настроек соединения с сервером БД
    /// </summary>
    public partial class FormServerSettings : BaseViewShowErrorAndWarning, IServerSettingsView
    {
        public event EventHandler<string?>? ServerConnectionChecking;
        public event EventHandler<(string? serverName, string? dBName)>? DBEnableChecking;
        public event EventHandler<(string? serverName, string? dBName)>? SavingNewSettings;
        public event EventHandler<(string? serverName, string? dBName)>? CreatingNewDb;
        

        public FormServerSettings()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }



        public void PrintData(string? currentServerName, string? currentDbName)
        {
            textBox4CurrentServerName.Text = currentServerName;
            textBox5CurrentDbName.Text = currentDbName;
        }


        /// <summary>
        /// Вызов события Проверить доступность Сервера
        /// </summary>
        private void OnCheckServerConnection()
        {
            string serverName = textBox1ServerName.Text;
            ServerConnectionChecking?.Invoke(this, serverName);
        }

        /// <summary>
        /// Вызов события Проверить доступность БД
        /// </summary>
        private void OnCheckDbEnable()
        {
            DBEnableChecking?.Invoke(this, GetEnteredNames());
        }

        private void OnSaveNewData()
        {
            SavingNewSettings?.Invoke(this, GetEnteredNames());
        }

        private void OnCreateNewDb()
        {
            CreatingNewDb?.Invoke(this, GetEnteredNames());
        }

        /// <summary>
        /// Получить введённые пользователем название сервера и имя БД
        /// </summary>
        /// <returns></returns>
       private (string serverName, string dbName) GetEnteredNames()
        {
            string serverName = textBox1ServerName.Text;
            string dbName = textBox2DbName.Text;
            return (serverName, dbName);
        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            OnSaveNewData();
        }

        private void button2Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3CheckServerConnection_Click(object sender, EventArgs e)
        { //Проверить доступность Сервера БД
            OnCheckServerConnection();
        }

        private void button4CheckDbEnable_Click(object sender, EventArgs e)
        { //Проверить наличие БД
            OnCheckDbEnable();
        }

        private void button5CreateDb_Click(object sender, EventArgs e)
        {//создать БД
            OnCreateNewDb();
        }
    }
}
