namespace task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1SUBMIT = new Button();
            label1name = new Label();
            label2age = new Label();
            label3gender = new Label();
            label4addres = new Label();
            label5cource = new Label();
            textBox1NAME = new TextBox();
            textBox2AGE = new TextBox();
            textBox4ADDRESS = new TextBox();
            radioButton1male = new RadioButton();
            radioButton2female = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button1SUBMIT
            // 
            button1SUBMIT.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1SUBMIT.Location = new Point(370, 426);
            button1SUBMIT.Margin = new Padding(4);
            button1SUBMIT.Name = "button1SUBMIT";
            button1SUBMIT.Size = new Size(179, 75);
            button1SUBMIT.TabIndex = 0;
            button1SUBMIT.Text = "Submit";
            button1SUBMIT.UseVisualStyleBackColor = true;
            button1SUBMIT.Click += button1SUBMIT_Click;
            // 
            // label1name
            // 
            label1name.AutoSize = true;
            label1name.BackColor = SystemColors.ControlLightLight;
            label1name.Font = new Font("Segoe Print", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1name.ImageAlign = ContentAlignment.TopLeft;
            label1name.Location = new Point(21, 59);
            label1name.Margin = new Padding(4, 0, 4, 0);
            label1name.Name = "label1name";
            label1name.Size = new Size(78, 38);
            label1name.TabIndex = 1;
            label1name.Text = "name";
            // 
            // label2age
            // 
            label2age.AutoSize = true;
            label2age.BackColor = SystemColors.ButtonHighlight;
            label2age.Font = new Font("Segoe Print", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2age.Location = new Point(21, 130);
            label2age.Margin = new Padding(4, 0, 4, 0);
            label2age.Name = "label2age";
            label2age.Size = new Size(54, 38);
            label2age.TabIndex = 2;
            label2age.Text = "age";
            // 
            // label3gender
            // 
            label3gender.AutoSize = true;
            label3gender.BackColor = SystemColors.ControlLightLight;
            label3gender.Font = new Font("Segoe Print", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3gender.Location = new Point(13, 192);
            label3gender.Margin = new Padding(4, 0, 4, 0);
            label3gender.Name = "label3gender";
            label3gender.Size = new Size(93, 38);
            label3gender.TabIndex = 3;
            label3gender.Text = "gender";
            // 
            // label4addres
            // 
            label4addres.AutoSize = true;
            label4addres.BackColor = SystemColors.ControlLightLight;
            label4addres.Font = new Font("Segoe Print", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4addres.Location = new Point(13, 240);
            label4addres.Margin = new Padding(4, 0, 4, 0);
            label4addres.Name = "label4addres";
            label4addres.Size = new Size(91, 38);
            label4addres.TabIndex = 4;
            label4addres.Text = "addres";
            // 
            // label5cource
            // 
            label5cource.AutoSize = true;
            label5cource.BackColor = SystemColors.ControlLightLight;
            label5cource.Font = new Font("Segoe Print", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5cource.Location = new Point(13, 324);
            label5cource.Margin = new Padding(4, 0, 4, 0);
            label5cource.Name = "label5cource";
            label5cource.Size = new Size(93, 38);
            label5cource.TabIndex = 5;
            label5cource.Text = "courses";
            // 
            // textBox1NAME
            // 
            textBox1NAME.Location = new Point(118, 59);
            textBox1NAME.Margin = new Padding(4);
            textBox1NAME.Name = "textBox1NAME";
            textBox1NAME.Size = new Size(235, 34);
            textBox1NAME.TabIndex = 6;
            // 
            // textBox2AGE
            // 
            textBox2AGE.Location = new Point(118, 134);
            textBox2AGE.Margin = new Padding(4);
            textBox2AGE.Name = "textBox2AGE";
            textBox2AGE.Size = new Size(235, 34);
            textBox2AGE.TabIndex = 7;
            // 
            // textBox4ADDRESS
            // 
            textBox4ADDRESS.Location = new Point(118, 240);
            textBox4ADDRESS.Margin = new Padding(4);
            textBox4ADDRESS.Name = "textBox4ADDRESS";
            textBox4ADDRESS.ScrollBars = ScrollBars.Horizontal;
            textBox4ADDRESS.Size = new Size(235, 34);
            textBox4ADDRESS.TabIndex = 9;
            // 
            // radioButton1male
            // 
            radioButton1male.AutoSize = true;
            radioButton1male.BackColor = SystemColors.ControlLightLight;
            radioButton1male.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1male.ForeColor = Color.FromArgb(20, 20, 184);
            radioButton1male.Location = new Point(118, 192);
            radioButton1male.Margin = new Padding(4);
            radioButton1male.Name = "radioButton1male";
            radioButton1male.Size = new Size(81, 37);
            radioButton1male.TabIndex = 11;
            radioButton1male.Text = "male";
            radioButton1male.UseVisualStyleBackColor = false;
            radioButton1male.CheckedChanged += radioButton1male_CheckedChanged;
            // 
            // radioButton2female
            // 
            radioButton2female.AutoSize = true;
            radioButton2female.BackColor = SystemColors.ControlLightLight;
            radioButton2female.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2female.ForeColor = Color.FromArgb(20, 20, 184);
            radioButton2female.Location = new Point(255, 192);
            radioButton2female.Margin = new Padding(4);
            radioButton2female.Name = "radioButton2female";
            radioButton2female.Size = new Size(98, 37);
            radioButton2female.TabIndex = 12;
            radioButton2female.Text = "female";
            radioButton2female.UseVisualStyleBackColor = false;
            radioButton2female.CheckedChanged += radioButton2female_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBox1.ForeColor = Color.FromArgb(20, 20, 184);
            checkedListBox1.Items.AddRange(new object[] { "c#", "c++", "python", "Java script", "c" });
            checkedListBox1.Location = new Point(118, 299);
            checkedListBox1.Margin = new Padding(4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(235, 74);
            checkedListBox1.TabIndex = 16;
            checkedListBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(621, 563);
            Controls.Add(checkedListBox1);
            Controls.Add(radioButton2female);
            Controls.Add(radioButton1male);
            Controls.Add(textBox4ADDRESS);
            Controls.Add(textBox2AGE);
            Controls.Add(textBox1NAME);
            Controls.Add(label5cource);
            Controls.Add(label4addres);
            Controls.Add(label3gender);
            Controls.Add(label2age);
            Controls.Add(label1name);
            Controls.Add(button1SUBMIT);
            Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint_1;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1SUBMIT;
        private Label label1name;
        private Label label2age;
        private Label label3gender;
        private Label label4addres;
        private Label label5cource;
        private TextBox textBox1NAME;
        private TextBox textBox2AGE;
        private TextBox textBox4ADDRESS;
        private RadioButton radioButton1male;
        private RadioButton radioButton2female;
        private CheckedListBox checkedListBox1;
    }
}
