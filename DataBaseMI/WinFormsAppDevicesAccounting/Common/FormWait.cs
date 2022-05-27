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
    public partial class FormWait:Form
    {
        public FormWait()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        /// <summary>
        /// Вывести значение
        /// </summary>
        /// <param name="n"></param>
        public void Print(int n)
        {
            progressBar1.Value = n;
        }
    }
}
