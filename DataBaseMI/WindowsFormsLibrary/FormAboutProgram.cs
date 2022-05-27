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

namespace WinFormsAppDevicesAccounting.Windows
{
    public partial class FormAboutProgram : Form, IAboutProgramView
    {
        public FormAboutProgram()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            
        }
        public new void Close()
        {

        }
    }
}
