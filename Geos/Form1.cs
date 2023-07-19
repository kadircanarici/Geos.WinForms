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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddMultiply_Click(object sender, EventArgs e)
        {
            FormAddMultiply formAddMultiply = new FormAddMultiply(this);

            this.Hide();
            formAddMultiply.ShowDialog();
            this.Show();
        }

        private void btnZagzig_Click(object sender, EventArgs e)
        {
            FormZagzig formZagzig= new FormZagzig(this);

            this.Hide();
            formZagzig.ShowDialog();
            this.Show();
        }

        private void btnMTable_Click(object sender, EventArgs e)
        {
            FormMTable formMTable= new FormMTable(this);

            this.Hide();
            formMTable.ShowDialog();
            this.Show();
        }
    }
}
