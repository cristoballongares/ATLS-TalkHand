namespace ATLS_TALKHAND
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button6 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NK-B", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 16);
            label1.Name = "label1";
            label1.Size = new Size(144, 43);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.DialogResult = DialogResult.OK;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(52, 109);
            button1.Name = "button1";
            button1.Size = new Size(61, 61);
            button1.TabIndex = 1;
            button1.Tag = "1";
            button1.Text = "A";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(52, 388);
            button6.Name = "button6";
            button6.Size = new Size(219, 41);
            button6.TabIndex = 6;
            button6.Text = "Practicar";
            button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(132, 109);
            button2.Name = "button2";
            button2.Size = new Size(61, 61);
            button2.TabIndex = 7;
            button2.Tag = "2";
            button2.Text = "E";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(210, 109);
            button3.Name = "button3";
            button3.Size = new Size(61, 61);
            button3.TabIndex = 8;
            button3.Text = "I";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(86, 176);
            button4.Name = "button4";
            button4.Size = new Size(61, 61);
            button4.TabIndex = 9;
            button4.Text = "O";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(169, 176);
            button5.Name = "button5";
            button5.Size = new Size(61, 61);
            button5.TabIndex = 10;
            button5.Text = "U";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumPurple;
            button7.FlatStyle = FlatStyle.System;
            button7.Location = new Point(5, 3);
            button7.Name = "button7";
            button7.Size = new Size(16, 25);
            button7.TabIndex = 16;
            button7.Text = "<";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(321, 463);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
    }
}