using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bAddP_Click(object sender, EventArgs e)
        {
            var shell = PowerShell.Create();
            shell.Commands.AddScript("C:\\Gametimer\\Timer_Install.ps1");
            var results = shell.Invoke();
        }

        private void bUnistall_Click(object sender, EventArgs e)
        {
            var shell = PowerShell.Create();
            shell.Commands.AddScript("C:\\gametimer\\Uninstall.ps1");
            var results = shell.Invoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value1 = File.ReadAllText("C:\\gametimer\\Alltimers.txt");
            MessageBox.Show(value1);
        }
    }
}
