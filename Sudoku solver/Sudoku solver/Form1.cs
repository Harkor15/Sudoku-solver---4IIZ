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
        List<TextBox> fields;
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

        DataSet getDataFromSudoku()
        {
            DataSet dataSet = new DataSet();


            return dataSet;
        }

        void initFields()
        {
            fields.Add(textBox0x0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test_label.Text = "Button clicked";
        }

        private void test_label_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x0);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x0);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x0);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x1);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x1);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x1);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x2);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x2);
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x2);
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x2);
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x2);
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x2);
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x1);
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x1);
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x1);
        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x0);
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x0);
        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x0);
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x2);
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x2);
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x2);
        }
        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x1);
        }
        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x1);
        }
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x1);
        }
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x0);
        }
        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x0);
        }
        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x0);
        }
        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x5);
        }
        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x5);
        }
        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x5);
        }
        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x4);
        }
        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x4);
        }
        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x4);
        }
        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x3);
        }
        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x3);
        }
        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x3);
        }
        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x5);
        }
        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x5);
        }
        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x5);
        }
        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x4);
        }
        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4z4);
        }
        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3z4);
        }
        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x3);
        }
        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x3);
        }
        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x3);
        }
        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x5);
        }
        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x5);
        }
        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x5);
        }
        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x4);
        }
        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x4);
        }
        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x4);
        }
        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x3);
        }
        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x3);
        }
        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x3);
        }
        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x8);
        }
        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x8);
        }
        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x8);
        }
        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x7);
        }
        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x7);
        }
        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x7);
        }
        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x6);
        }
        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x6);
        }
        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x6);
        }
        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x8);
        }
        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x8);
        }
        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x8);
        }
        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x7);
        }
        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x7);
        }
        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x7);
        }
        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x6);
        }
        private void textBox71_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x6);
        }
        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x6);
        }
        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x8);
        }
        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x8);
        }
        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x8);
        }
        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x7);
        }
        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x7);
        }
        private void textBox78_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x7);
        }
        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x6);
        }
        private void textBox80_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x6);
        }
        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x6);
        }

      
    }
}