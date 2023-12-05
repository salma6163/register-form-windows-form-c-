using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task1
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();

        }

        private void button2SHOWINFO_Click(object sender, EventArgs e)
        {
            richTextBox1FORM2.Text = File.ReadAllText("OS first task.txt");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("form sent successfully");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("thanks", "end message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen mypen = new Pen(Color.White);
            graphics.DrawRectangle(mypen, 58, 298, 472, 220);
            graphics.DrawRectangle(mypen, 200, 75, 190, 87);
        }

      
    }
}
