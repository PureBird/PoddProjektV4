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
            DeleteRbn = new RadioButton();
            EditRbn = new RadioButton();
            CatLbl = new Label();
            CatBtn = new Button();
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
            BackBtn.Location = new Point(11, 12);
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
            CategoryLbl.Location = new Point(675, 12);
            CategoryLbl.Name = "CategoryLbl";
            CategoryLbl.Size = new Size(213, 37);
            CategoryLbl.TabIndex = 1;
            CategoryLbl.Text = "Kategorier";
            CategoryLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DeleteRbn
            // 
            DeleteRbn.Appearance = Appearance.Button;
            DeleteRbn.AutoSize = true;
            DeleteRbn.Font = new Font("Segoe UI", 11F);
            DeleteRbn.Location = new Point(109, 76);
            DeleteRbn.Name = "DeleteRbn";
            DeleteRbn.Size = new Size(81, 35);
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
            EditRbn.Font = new Font("Segoe UI", 11F);
            EditRbn.Location = new Point(11, 76);
            EditRbn.Name = "EditRbn";
            EditRbn.Size = new Size(96, 35);
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
            CatLbl.Location = new Point(11, 119);
            CatLbl.Name = "CatLbl";
            CatLbl.Size = new Size(276, 28);
            CatLbl.TabIndex = 7;
            CatLbl.Text = "Namnet på den nya kategorin:";
            // 
            // CatBtn
            // 
            CatBtn.Font = new Font("Segoe UI", 12F);
            CatBtn.Location = new Point(506, 113);
            CatBtn.Margin = new Padding(3, 4, 3, 4);
            CatBtn.Name = "CatBtn";
            CatBtn.Size = new Size(89, 39);
            CatBtn.TabIndex = 8;
            CatBtn.Text = "Skapa";
            CatBtn.UseVisualStyleBackColor = true;
            CatBtn.Click += CatBtn_Click;
            // 
            // CatTbxEdit
            // 
            CatTbxEdit.Font = new Font("Segoe UI", 12F);
            CatTbxEdit.Location = new Point(314, 173);
            CatTbxEdit.Margin = new Padding(3, 4, 3, 4);
            CatTbxEdit.Name = "CatTbxEdit";
            CatTbxEdit.Size = new Size(185, 34);
            CatTbxEdit.TabIndex = 12;
            CatTbxEdit.Text = "Placeholder";
            // 
            // CatBtnEdit
            // 
            CatBtnEdit.Font = new Font("Segoe UI", 12F);
            CatBtnEdit.Location = new Point(506, 175);
            CatBtnEdit.Margin = new Padding(3, 4, 3, 4);
            CatBtnEdit.Name = "CatBtnEdit";
            CatBtnEdit.Size = new Size(89, 39);
            CatBtnEdit.TabIndex = 11;
            CatBtnEdit.Text = "Ändra";
            CatBtnEdit.UseVisualStyleBackColor = true;
            CatBtnEdit.Click += CatBtnEdit_Click;
            // 
            // CatLblEdit
            // 
            CatLblEdit.AutoSize = true;
            CatLblEdit.Font = new Font("Segoe UI", 12F);
            CatLblEdit.Location = new Point(11, 173);
            CatLblEdit.Name = "CatLblEdit";
            CatLblEdit.Size = new Size(259, 28);
            CatLblEdit.TabIndex = 13;
            CatLblEdit.Text = "Nytt namn för vald kategori:";
            // 
            // CatCbx
            // 
            CatCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            CatCbx.Font = new Font("Segoe UI", 12F);
            CatCbx.FormattingEnabled = true;
            CatCbx.Location = new Point(314, 113);
            CatCbx.Margin = new Padding(3, 4, 3, 4);
            CatCbx.Name = "CatCbx";
            CatCbx.Size = new Size(185, 36);
            CatCbx.TabIndex = 14;
            // 
            // AlertLbl
            // 
            AlertLbl.AutoEllipsis = true;
            AlertLbl.Font = new Font("Segoe UI", 12F);
            AlertLbl.Location = new Point(614, 113);
            AlertLbl.MaximumSize = new Size(274, 67);
            AlertLbl.MinimumSize = new Size(274, 0);
            AlertLbl.Name = "AlertLbl";
            AlertLbl.Size = new Size(274, 65);
            AlertLbl.TabIndex = 15;
            AlertLbl.Text = "Placeholder";
            AlertLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // AlertLblEditCount
            // 
            AlertLblEditCount.AutoEllipsis = true;
            AlertLblEditCount.Font = new Font("Segoe UI", 12F);
            AlertLblEditCount.Location = new Point(614, 173);
            AlertLblEditCount.MaximumSize = new Size(274, 67);
            AlertLblEditCount.MinimumSize = new Size(274, 0);
            AlertLblEditCount.Name = "AlertLblEditCount";
            AlertLblEditCount.Size = new Size(274, 33);
            AlertLblEditCount.TabIndex = 16;
            AlertLblEditCount.Text = "Placeholder";
            AlertLblEditCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Kategorier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 236);
            Controls.Add(AlertLblEditCount);
            Controls.Add(AlertLbl);
            Controls.Add(CatCbx);
            Controls.Add(CatLblEdit);
            Controls.Add(CatTbxEdit);
            Controls.Add(CatBtnEdit);
            Controls.Add(CatBtn);
            Controls.Add(CatLbl);
            Controls.Add(EditRbn);
            Controls.Add(DeleteRbn);
            Controls.Add(CategoryLbl);
            Controls.Add(BackBtn);
            Name = "Kategorier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategorier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Label CategoryLbl;
        private RadioButton DeleteRbn;
        private RadioButton EditRbn;
        private Label CatLbl;
        private Button CatBtn;
        private TextBox CatTbxEdit;
        private Button CatBtnEdit;
        private Label CatLblEdit;
        private ComboBox CatCbx;
        private Label AlertLbl;
        private Label AlertLblEditCount;
    }
}