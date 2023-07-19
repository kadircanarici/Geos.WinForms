using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geos
{
    public partial class FormMTable : Form
    {
        private Form1 _mainForm;
        public FormMTable(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Show();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number) & number<16 )
            {
                richTextBox1.Text = CreateMultiplicationTable(number);
            }
            else
            {
                MessageBox.Show("Geçerli bir tam sayı giriniz.");
            }
        }
        private string CreateMultiplicationTable(int n)
        {
            string tablo = "";

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        tablo += $"{0,-6}";
                    }
                    else if (i == 0)
                    {
                        tablo += $"{j,-6}"; 
                    }
                    else if (j == 0)
                    {
                        tablo += $"{i,-6}"; 
                    }
                    else
                    {
                        tablo += $"{i * j,-6}"; 
                    }
                }
                tablo += Environment.NewLine; 
            }

            return tablo;
        }
    }
}
