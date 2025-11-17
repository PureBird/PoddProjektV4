using PoddProjektV3._2;

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
            RegisterBtn.Location = new Point(47, 41);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(310, 112);
            RegisterBtn.TabIndex = 0;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += registerBtn_Click;
            // 
            // SokBtn
            // 
            SokBtn.Location = new Point(47, 176);
            SokBtn.Name = "SokBtn";
            SokBtn.Size = new Size(310, 112);
            SokBtn.TabIndex = 1;
            SokBtn.Text = "Sök";
            SokBtn.UseVisualStyleBackColor = true;
            SokBtn.Click += sokBtn_Click;
            // 
            // KategorierBtn
            // 
            KategorierBtn.Location = new Point(47, 312);
            KategorierBtn.Name = "KategorierBtn";
            KategorierBtn.Size = new Size(310, 112);
            KategorierBtn.TabIndex = 2;
            KategorierBtn.Text = "Kategorier";
            KategorierBtn.UseVisualStyleBackColor = true;
            KategorierBtn.Click += kategorierBtn_Click;
            // 
            // Meny2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KategorierBtn);
            Controls.Add(SokBtn);
            Controls.Add(RegisterBtn);
            Name = "Meny2";
            Text = "Form1";
            ResumeLayout(false);
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();

            registerForm.Show();
            this.Hide();
        }

        private void sokBtn_Click(object sender, EventArgs e)
        {
            PodVisaren sokForm = new PodVisaren();

            sokForm.Show();
            this.Hide();
        }

        private void kategorierBtn_Click(object sender, EventArgs e)
        {
            // objekt kategoriForm = new object();

            //kategoriForm.Show
            //this.Hide();
        }


        #endregion

        private Button RegisterBtn;
        private Button SokBtn;
        private Button KategorierBtn;
    }
}
