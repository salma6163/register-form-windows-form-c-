using System.IO;
using System.Windows.Forms.VisualStyles;

namespace task1;
public partial class Form1 : Form
{
    string gender;
    

    StreamWriter sw = new StreamWriter("OS first task.txt");

    Form2 form = new Form2();


    public Form1()
    {
        InitializeComponent();

    }
    private void Form1_Load(object sender, EventArgs e)
    {
        MessageBox.Show("Welcome to first form", "welcome message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
    }


    private void button1SUBMIT_Click(object sender, EventArgs e)
    {

        form.Show();

        sw.Write(label1name.Text + ":" + textBox1NAME.Text + "\n" + label2age.Text + ":" + textBox2AGE.Text +
            "\n" + label4addres.Text + ":" + textBox4ADDRESS.Text + "\n" + label3gender.Text + ":" + gender + "\n" + label5cource.Text + ":");
        foreach (var item in checkedListBox1.CheckedItems)
        {
            sw.Write(item.ToString() + " - ");
        }
        sw.Close();
    }


    private void radioButton1male_CheckedChanged(object sender, EventArgs e)
    {
        gender = "male";

    }

    private void radioButton2female_CheckedChanged(object sender, EventArgs e)
    {
        gender = "female";
    }

    public string GetGender()
    {
        return gender;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            this.Close();
        }
    }

  
    private void Form1_Paint_1(object sender, PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;
        Pen mypen = new Pen(Color.White);
        graphics.DrawRectangle(mypen, 363, 420, 177, 75);
    }
}