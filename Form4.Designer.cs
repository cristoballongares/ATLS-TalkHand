namespace ATLS_TALKHAND
{
    partial class Form4
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 222);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 313);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 113);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 5);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(82, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(149, 39);
            panel2.TabIndex = 4;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumPurple;
            button7.FlatStyle = FlatStyle.System;
            button7.Location = new Point(12, 17);
            button7.Name = "button7";
            button7.Size = new Size(16, 25);
            button7.TabIndex = 17;
            button7.Text = "<";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 23, 235);
            ClientSize = new Size(321, 463);
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            SizeChanged += Form4_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        public Label label2;
        private Panel panel2;
        private Button button7;
    }
}