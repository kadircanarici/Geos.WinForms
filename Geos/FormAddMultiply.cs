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
    public partial class FormAddMultiply : Form
    {
        private Form1 _mainForm;
        public FormAddMultiply(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }


        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out double number1) &&
                double.TryParse(txtNumber2.Text, out double number2) && double.TryParse(txtNumber3.Text, out double number3))
            {
                double result = (number1 + number2) * number3;
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata");
            }
        }
    }
}
