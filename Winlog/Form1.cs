using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winlog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
                this.textBox1.AutoSize = false;
                this.textBox1.Size = new System.Drawing.Size(259, 35);

            this.textBox2.AutoSize = false;
            this.textBox2.Size = new System.Drawing.Size(259, 35);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(900, 570);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.AutoSize = false;
            this.textBox1.Size = new System.Drawing.Size(259, 35);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
