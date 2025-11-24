namespace PL
{
    partial class Meny
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
            RegisterBtn = new Button();
            SokBtn = new Button();
            KategorierBtn = new Button();
            SuspendLayout();
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.White;
            RegisterBtn.Location = new Point(47, 41);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(310, 112);
            RegisterBtn.TabIndex = 0;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += registerBtn_Click;
            // 
            // SokBtn
            // 
            SokBtn.BackColor = Color.White;
            SokBtn.Location = new Point(47, 176);
            SokBtn.Name = "SokBtn";
            SokBtn.Size = new Size(310, 112);
            SokBtn.TabIndex = 1;
            SokBtn.Text = "Sök";
            SokBtn.UseVisualStyleBackColor = false;
            SokBtn.Click += sokBtn_Click;
            // 
            // KategorierBtn
            // 
            KategorierBtn.BackColor = Color.White;
            KategorierBtn.Location = new Point(47, 312);
            KategorierBtn.Name = "KategorierBtn";
            KategorierBtn.Size = new Size(310, 112);
            KategorierBtn.TabIndex = 2;
            KategorierBtn.Text = "Kategorier";
            KategorierBtn.UseVisualStyleBackColor = false;
            KategorierBtn.Click += kategorierBtn_Click;
            // 
            // Meny
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(405, 450);
            Controls.Add(KategorierBtn);
            Controls.Add(SokBtn);
            Controls.Add(RegisterBtn);
            Name = "Meny";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }







        #endregion

        private Button RegisterBtn;
        private Button SokBtn;
        private Button KategorierBtn;
    }
}
