using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void limitLengthToOne(TextBox tb)
        {
            String value = tb.Text;
            if (value.Length > 1)
            {
                tb.Text = value.Substring(0, 1);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test_label.Text = "Button clicked";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1);
        }

        private void test_label_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2);
        }
    }
}
