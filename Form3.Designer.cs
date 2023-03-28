namespace ATLS_TALKHAND
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button3 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.MediumPurple;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(5, 3);
            button3.Name = "button3";
            button3.Size = new Size(16, 25);
            button3.TabIndex = 15;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(321, 463);
            Controls.Add(button3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
    }
}