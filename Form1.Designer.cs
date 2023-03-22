namespace ATLS_TALKHAND
{
    partial class Form1
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
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            btnTraducir = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(button3);
            panel1.Location = new Point(45, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 340);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(47, 117);
            button3.Name = "button3";
            button3.Size = new Size(141, 23);
            button3.TabIndex = 0;
            button3.Text = "Activar camara";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(31, 358);
            button1.Name = "button1";
            button1.Size = new Size(70, 64);
            button1.TabIndex = 1;
            button1.Text = "Palabras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnTraducir
            // 
            btnTraducir.BackColor = Color.LightBlue;
            btnTraducir.FlatStyle = FlatStyle.Flat;
            btnTraducir.Location = new Point(216, 358);
            btnTraducir.Name = "btnTraducir";
            btnTraducir.Size = new Size(70, 64);
            btnTraducir.TabIndex = 2;
            btnTraducir.Text = "Traducir";
            btnTraducir.UseVisualStyleBackColor = false;
            btnTraducir.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 7);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
           
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(321, 463);
            Controls.Add(label1);
            Controls.Add(btnTraducir);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "ATLS - TalkHand";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnTraducir;
        private Button button3;
        private Label label1;
    }
}