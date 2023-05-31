using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Product _product = new();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBDescription.Text != string.Empty &&
                TBPrice.Text != string.Empty &&
                TBName.Text != string.Empty
                )
            {
                _product = new Product(TBName.Text, TBDescription.Text, Convert.ToDouble(TBPrice.Text));
                Close();
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Incorrect Data", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
