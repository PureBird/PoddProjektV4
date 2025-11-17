namespace PL
{
    partial class Kategorier
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
            BackBtn = new Button();
            CategoryLbl = new Label();
            OptionLbl = new Label();
            label1 = new Label();
            CreateRbn = new RadioButton();
            DeleteRbn = new RadioButton();
            EditRbn = new RadioButton();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "<- Tillbaka";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CategoryLbl
            // 
            CategoryLbl.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryLbl.Location = new Point(575, 12);
            CategoryLbl.Name = "CategoryLbl";
            CategoryLbl.Size = new Size(213, 37);
            CategoryLbl.TabIndex = 1;
            CategoryLbl.Text = "Kategorier";
            // 
            // OptionLbl
            // 
            OptionLbl.Font = new Font("Segoe UI", 12F);
            OptionLbl.Location = new Point(12, 102);
            OptionLbl.Name = "OptionLbl";
            OptionLbl.Size = new Size(78, 36);
            OptionLbl.TabIndex = 2;
            OptionLbl.Text = "Jag vill:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(96, 102);
            label1.Name = "label1";
            label1.Size = new Size(229, 36);
            label1.TabIndex = 3;
            label1.Text = "Skapa";
            // 
            // CreateRbn
            // 
            CreateRbn.Appearance = Appearance.Button;
            CreateRbn.AutoSize = true;
            CreateRbn.Location = new Point(12, 69);
            CreateRbn.Name = "CreateRbn";
            CreateRbn.Size = new Size(59, 30);
            CreateRbn.TabIndex = 4;
            CreateRbn.TabStop = true;
            CreateRbn.Text = "Skapa";
            CreateRbn.UseVisualStyleBackColor = true;
            // 
            // DeleteRbn
            // 
            DeleteRbn.Appearance = Appearance.Button;
            DeleteRbn.AutoSize = true;
            DeleteRbn.Location = new Point(162, 69);
            DeleteRbn.Name = "DeleteRbn";
            DeleteRbn.Size = new Size(66, 30);
            DeleteRbn.TabIndex = 5;
            DeleteRbn.TabStop = true;
            DeleteRbn.Text = "Radera";
            DeleteRbn.UseVisualStyleBackColor = true;
            // 
            // EditRbn
            // 
            EditRbn.Appearance = Appearance.Button;
            EditRbn.AutoSize = true;
            EditRbn.Location = new Point(77, 69);
            EditRbn.Name = "EditRbn";
            EditRbn.Size = new Size(79, 30);
            EditRbn.TabIndex = 6;
            EditRbn.TabStop = true;
            EditRbn.Text = "Redigera";
            EditRbn.UseVisualStyleBackColor = true;
            // 
            // Kategorier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditRbn);
            Controls.Add(DeleteRbn);
            Controls.Add(CreateRbn);
            Controls.Add(label1);
            Controls.Add(OptionLbl);
            Controls.Add(CategoryLbl);
            Controls.Add(BackBtn);
            Name = "Kategorier";
            Text = "Kategorier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Label CategoryLbl;
        private Label OptionLbl;
        private Label label1;
        private RadioButton CreateRbn;
        private RadioButton DeleteRbn;
        private RadioButton EditRbn;
    }
}