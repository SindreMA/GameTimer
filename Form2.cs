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
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
                System.IO.StreamReader myFile = new System.IO.StreamReader("c:\\Gametimer\\Total-Timer.txt");
                string myString = myFile.ReadToEnd();
                richTextBox1.Text = myString;
                myFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void brefreash_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader myFile = new System.IO.StreamReader("c:\\Gametimer\\Total-Timer.txt");
            string myString = myFile.ReadToEnd();
            richTextBox1.Text = myString;
            myFile.Close();
        }
    }
}

