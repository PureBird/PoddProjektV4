namespace PoddProjektV3._2
{
    partial class Meny
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
            Register = new Button();
            Sök = new Button();
            Kategori = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            Register.Location = new Point(69, 49);
            Register.Name = "button1";
            Register.Size = new Size(229, 65);
            Register.TabIndex = 0;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += registerBtn_Click;
            // 
            // button2
            // 
            Sök.Location = new Point(69, 143);
            Sök.Name = "button2";
            Sök.Size = new Size(229, 65);
            Sök.TabIndex = 1;
            Sök.Text = "Sök ny podd";
            Sök.UseVisualStyleBackColor = true;
            Sök.Click += sokBtn_Click;
            // 
            // button3
            // 
            Kategori.Location = new Point(69, 236);
            Kategori.Name = "button3";
            Kategori.Size = new Size(229, 65);
            Kategori.TabIndex = 2;
            Kategori.Text = "Se kategorier";
            Kategori.UseVisualStyleBackColor = true;
            Kategori.Click += kategoriBtn_Click;
            // 
            // Meny
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Kategori);
            Controls.Add(Sök);
            Controls.Add(Register);
            Name = "Meny";
            Text = "Meny";
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

        private void kategoriBtn_Click(object sender, EventArgs e)
        {
            // objekt kategoriForm = new object();

            //kategoriForm.Show
            //this.Hide();
        }


        #endregion

        private Button Register;
        private Button Sök;
        private Button Kategori;
    }
}