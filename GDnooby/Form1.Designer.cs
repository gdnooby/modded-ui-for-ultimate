namespace GDnooby
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button5 = new Button();
            button8 = new Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            button10 = new Button();
            label4 = new Label();
            button9 = new Button();
            label5 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 407);
            button1.Name = "button1";
            button1.Size = new Size(82, 40);
            button1.TabIndex = 0;
            button1.Text = "Inject";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(100, 413);
            button2.Name = "button2";
            button2.Size = new Size(82, 25);
            button2.TabIndex = 1;
            button2.Text = "Execute";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(611, 354);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(276, 413);
            button3.Name = "button3";
            button3.Size = new Size(110, 25);
            button3.TabIndex = 3;
            button3.Text = "Load Watermark";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(629, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(159, 364);
            listBox1.TabIndex = 4;
            listBox1.MouseDown += listBox1_MouseDoubleClick;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(707, 407);
            button4.Name = "button4";
            button4.Size = new Size(81, 31);
            button4.TabIndex = 5;
            button4.Text = "Save File";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.No;
            label1.Location = new Point(392, 418);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 7;
            label1.Text = "Status =";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(188, 413);
            button5.Name = "button5";
            button5.Size = new Size(82, 25);
            button5.TabIndex = 8;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(629, 407);
            button8.Name = "button8";
            button8.Size = new Size(79, 31);
            button8.TabIndex = 13;
            button8.Text = "Refresh";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(button10);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(button9);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(-1, -5);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(799, 55);
            guna2Panel1.TabIndex = 14;
            guna2Panel1.Paint += guna2Panel1_Paint;
            guna2Panel1.MouseDown += guna2Panel1_MouseDown;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(751, 13);
            button10.Name = "button10";
            button10.Size = new Size(38, 30);
            button10.TabIndex = 18;
            button10.Text = "X";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 9);
            label4.Name = "label4";
            label4.Size = new Size(212, 30);
            label4.TabIndex = 15;
            label4.Text = "Ultimate GD Executor";
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(708, 13);
            button9.Name = "button9";
            button9.Size = new Size(38, 30);
            button9.TabIndex = 16;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 36);
            label5.Name = "label5";
            label5.Size = new Size(159, 15);
            label5.TabIndex = 17;
            label5.Text = "credits to velocity for the API";
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(497, 412);
            button6.Name = "button6";
            button6.Size = new Size(110, 25);
            button6.TabIndex = 15;
            button6.Text = "TopMost = OFF";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(button6);
            Controls.Add(pictureBox1);
            Controls.Add(guna2Panel1);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(798, 450);
            MinimumSize = new Size(798, 450);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button5;
        private Button button8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label4;
        private Button button9;
        private Button button10;
        private Label label5;
        private Button button6;
    }
}
