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
    public partial class FormZagzig : Form
    {
        private Form1 _mainForm;

        public FormZagzig(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Show();
        }

        private void btnZagzig_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 200; i++)
            {
                string output = "";

                if (i % 3 == 0)
                    output += "zig";

                if (i % 5 == 0)
                    output += "zag";

                if (output == "")
                    output = i.ToString();

                if (i > 100 && output == "zigzag")
                    output = "zagzig";

                richTextBox1.AppendText(output + Environment.NewLine);
            }
        }
    }
}
