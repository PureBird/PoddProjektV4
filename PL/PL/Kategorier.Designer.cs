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
            DisplayOptionLbl = new Label();
            OptionLbl = new Label();
            CreateRbn = new RadioButton();
            DeleteRbn = new RadioButton();
            EditRbn = new RadioButton();
            CatLbl = new Label();
            CatBtn = new Button();
            CatTbx = new TextBox();
            CatTbxEdit = new TextBox();
            CatBtnEdit = new Button();
            CatLblEdit = new Label();
            CatCbx = new ComboBox();
            AlertLbl = new Label();
            AlertLblEditCount = new Label();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(10, 9);
            BackBtn.Margin = new Padding(3, 2, 3, 2);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(82, 22);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "<- Tillbaka";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CategoryLbl
            // 
            CategoryLbl.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryLbl.Location = new Point(526, 9);
            CategoryLbl.Name = "CategoryLbl";
            CategoryLbl.Size = new Size(163, 28);
            CategoryLbl.TabIndex = 1;
            CategoryLbl.Text = "Kategorier";
            // 
            // DisplayOptionLbl
            // 
            DisplayOptionLbl.AutoSize = true;
            DisplayOptionLbl.Font = new Font("Segoe UI", 12F);
            DisplayOptionLbl.Location = new Point(6, 205);
            DisplayOptionLbl.Name = "DisplayOptionLbl";
            DisplayOptionLbl.Size = new Size(66, 21);
            DisplayOptionLbl.TabIndex = 2;
            DisplayOptionLbl.Text = "Jag vill...";
            // 
            // OptionLbl
            // 
            OptionLbl.AutoSize = true;
            OptionLbl.Font = new Font("Segoe UI", 12F);
            OptionLbl.Location = new Point(67, 205);
            OptionLbl.Name = "OptionLbl";
            OptionLbl.Size = new Size(91, 21);
            OptionLbl.TabIndex = 3;
            OptionLbl.Text = "placeholder";
            // 
            // CreateRbn
            // 
            CreateRbn.Appearance = Appearance.Button;
            CreateRbn.AutoSize = true;
            CreateRbn.Location = new Point(10, 52);
            CreateRbn.Margin = new Padding(3, 2, 3, 2);
            CreateRbn.Name = "CreateRbn";
            CreateRbn.Size = new Size(48, 25);
            CreateRbn.TabIndex = 4;
            CreateRbn.TabStop = true;
            CreateRbn.Text = "Skapa";
            CreateRbn.UseVisualStyleBackColor = true;
            CreateRbn.CheckedChanged += CreateRbn_CheckedChanged;
            // 
            // DeleteRbn
            // 
            DeleteRbn.Appearance = Appearance.Button;
            DeleteRbn.AutoSize = true;
            DeleteRbn.Location = new Point(142, 52);
            DeleteRbn.Margin = new Padding(3, 2, 3, 2);
            DeleteRbn.Name = "DeleteRbn";
            DeleteRbn.Size = new Size(53, 25);
            DeleteRbn.TabIndex = 5;
            DeleteRbn.TabStop = true;
            DeleteRbn.Text = "Radera";
            DeleteRbn.UseVisualStyleBackColor = true;
            DeleteRbn.CheckedChanged += DeleteRbn_CheckedChanged;
            // 
            // EditRbn
            // 
            EditRbn.Appearance = Appearance.Button;
            EditRbn.AutoSize = true;
            EditRbn.Location = new Point(67, 52);
            EditRbn.Margin = new Padding(3, 2, 3, 2);
            EditRbn.Name = "EditRbn";
            EditRbn.Size = new Size(63, 25);
            EditRbn.TabIndex = 6;
            EditRbn.TabStop = true;
            EditRbn.Text = "Redigera";
            EditRbn.UseVisualStyleBackColor = true;
            EditRbn.CheckedChanged += EditRbn_CheckedChanged;
            // 
            // CatLbl
            // 
            CatLbl.AutoSize = true;
            CatLbl.Font = new Font("Segoe UI", 12F);
            CatLbl.Location = new Point(10, 89);
            CatLbl.Name = "CatLbl";
            CatLbl.Size = new Size(219, 21);
            CatLbl.TabIndex = 7;
            CatLbl.Text = "Namnet på den nya kategorin:";
            // 
            // CatBtn
            // 
            CatBtn.Font = new Font("Segoe UI", 12F);
            CatBtn.Location = new Point(362, 84);
            CatBtn.Name = "CatBtn";
            CatBtn.Size = new Size(78, 29);
            CatBtn.TabIndex = 8;
            CatBtn.Text = "Skapa";
            CatBtn.UseVisualStyleBackColor = true;
            CatBtn.Click += CatBtn_Click;
            // 
            // CatTbx
            // 
            CatTbx.Font = new Font("Segoe UI", 12F);
            CatTbx.Location = new Point(235, 86);
            CatTbx.Name = "CatTbx";
            CatTbx.Size = new Size(121, 29);
            CatTbx.TabIndex = 9;
            CatTbx.Text = "Placeholder";
            // 
            // CatTbxEdit
            // 
            CatTbxEdit.Font = new Font("Segoe UI", 12F);
            CatTbxEdit.Location = new Point(235, 130);
            CatTbxEdit.Name = "CatTbxEdit";
            CatTbxEdit.Size = new Size(121, 29);
            CatTbxEdit.TabIndex = 12;
            CatTbxEdit.Text = "Placeholder";
            // 
            // CatBtnEdit
            // 
            CatBtnEdit.Font = new Font("Segoe UI", 12F);
            CatBtnEdit.Location = new Point(362, 130);
            CatBtnEdit.Name = "CatBtnEdit";
            CatBtnEdit.Size = new Size(78, 29);
            CatBtnEdit.TabIndex = 11;
            CatBtnEdit.Text = "Ändra";
            CatBtnEdit.UseVisualStyleBackColor = true;
            CatBtnEdit.Click += CatBtnEdit_Click;
            // 
            // CatLblEdit
            // 
            CatLblEdit.AutoSize = true;
            CatLblEdit.Font = new Font("Segoe UI", 12F);
            CatLblEdit.Location = new Point(10, 130);
            CatLblEdit.Name = "CatLblEdit";
            CatLblEdit.Size = new Size(205, 21);
            CatLblEdit.TabIndex = 13;
            CatLblEdit.Text = "Nytt namn för vald kategori:";
            // 
            // CatCbx
            // 
            CatCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            CatCbx.Font = new Font("Segoe UI", 12F);
            CatCbx.FormattingEnabled = true;
            CatCbx.Location = new Point(235, 86);
            CatCbx.Name = "CatCbx";
            CatCbx.Size = new Size(121, 29);
            CatCbx.TabIndex = 14;
            // 
            // AlertLbl
            // 
            AlertLbl.AutoEllipsis = true;
            AlertLbl.Font = new Font("Segoe UI", 12F);
            AlertLbl.Location = new Point(446, 84);
            AlertLbl.MaximumSize = new Size(240, 50);
            AlertLbl.MinimumSize = new Size(240, 0);
            AlertLbl.Name = "AlertLbl";
            AlertLbl.Size = new Size(240, 50);
            AlertLbl.TabIndex = 15;
            AlertLbl.Text = "Placeholder";
            AlertLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // AlertLblEditCount
            // 
            AlertLblEditCount.AutoEllipsis = true;
            AlertLblEditCount.Font = new Font("Segoe UI", 12F);
            AlertLblEditCount.Location = new Point(446, 130);
            AlertLblEditCount.MaximumSize = new Size(240, 50);
            AlertLblEditCount.MinimumSize = new Size(240, 0);
            AlertLblEditCount.Name = "AlertLblEditCount";
            AlertLblEditCount.Size = new Size(240, 25);
            AlertLblEditCount.TabIndex = 16;
            AlertLblEditCount.Text = "Placeholder";
            AlertLblEditCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Kategorier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 243);
            Controls.Add(AlertLblEditCount);
            Controls.Add(AlertLbl);
            Controls.Add(CatCbx);
            Controls.Add(CatLblEdit);
            Controls.Add(CatTbxEdit);
            Controls.Add(CatBtnEdit);
            Controls.Add(CatTbx);
            Controls.Add(CatBtn);
            Controls.Add(CatLbl);
            Controls.Add(EditRbn);
            Controls.Add(DeleteRbn);
            Controls.Add(CreateRbn);
            Controls.Add(OptionLbl);
            Controls.Add(DisplayOptionLbl);
            Controls.Add(CategoryLbl);
            Controls.Add(BackBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Kategorier";
            Text = "Kategorier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Label CategoryLbl;
        private Label DisplayOptionLbl;
        private Label OptionLbl;
        private RadioButton CreateRbn;
        private RadioButton DeleteRbn;
        private RadioButton EditRbn;
        private Label CatLbl;
        private Button CatBtn;
        private TextBox CatTbx;
        private TextBox CatTbxEdit;
        private Button CatBtnEdit;
        private Label CatLblEdit;
        private ComboBox CatCbx;
        private Label AlertLbl;
        private Label AlertLblEditCount;
    }
}