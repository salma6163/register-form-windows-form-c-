namespace task1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button2SHOWINFO = new Button();
            richTextBox1FORM2 = new RichTextBox();
            SuspendLayout();
            // 
            // button2SHOWINFO
            // 
            button2SHOWINFO.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2SHOWINFO.ForeColor = SystemColors.ActiveCaptionText;
            button2SHOWINFO.Location = new Point(206, 80);
            button2SHOWINFO.Name = "button2SHOWINFO";
            button2SHOWINFO.Padding = new Padding(5);
            button2SHOWINFO.Size = new Size(193, 90);
            button2SHOWINFO.TabIndex = 0;
            button2SHOWINFO.Text = "show  my info";
            button2SHOWINFO.UseVisualStyleBackColor = true;
            button2SHOWINFO.Click += button2SHOWINFO_Click;
//            button2SHOWINFO.Paint += button2SHOWINFO_Paint;
            // 
            // richTextBox1FORM2
            // 
            richTextBox1FORM2.Font = new Font("Sitka Heading", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1FORM2.Location = new Point(66, 305);
            richTextBox1FORM2.Name = "richTextBox1FORM2";
            richTextBox1FORM2.Size = new Size(468, 218);
            richTextBox1FORM2.TabIndex = 50;
            richTextBox1FORM2.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(658, 621);
            Controls.Add(richTextBox1FORM2);
            Controls.Add(button2SHOWINFO);
            Name = "Form2";
            Padding = new Padding(0, 0, 50, 5);
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            Paint += Form2_Paint;
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Button button2SHOWINFO;
        private RichTextBox richTextBox1FORM2;
    }
}