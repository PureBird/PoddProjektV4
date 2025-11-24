namespace PL
{
    partial class Register
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
            TillbakaBtn = new Button();
            h1 = new Label();
            FilterComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            PoddNamn = new DataGridViewTextBoxColumn();
            PBeskrivning = new DataGridViewTextBoxColumn();
            AntalAvsnitt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TillbakaBtn
            // 
            TillbakaBtn.Enabled = false;
            TillbakaBtn.Location = new Point(17, 14);
            TillbakaBtn.Name = "TillbakaBtn";
            TillbakaBtn.Size = new Size(94, 29);
            TillbakaBtn.TabIndex = 0;
            TillbakaBtn.Text = "<- Tillbaka";
            TillbakaBtn.UseVisualStyleBackColor = true;
            TillbakaBtn.Click += TillbakaBtn_Click;
            // 
            // h1
            // 
            h1.AutoSize = true;
            h1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            h1.Location = new Point(48, 59);
            h1.Name = "h1";
            h1.Size = new Size(225, 60);
            h1.TabIndex = 1;
            h1.Text = "REGISTER";
            // 
            // FilterComboBox
            // 
            FilterComboBox.BackColor = Color.White;
            FilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterComboBox.ForeColor = Color.Black;
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(48, 122);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(229, 28);
            FilterComboBox.TabIndex = 2;
            FilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Pink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PoddNamn, PBeskrivning, AntalAvsnitt });
            dataGridView1.Location = new Point(48, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(702, 252);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PoddNamn
            // 
            PoddNamn.HeaderText = "Podcast";
            PoddNamn.MinimumWidth = 6;
            PoddNamn.Name = "PoddNamn";
            // 
            // PBeskrivning
            // 
            PBeskrivning.HeaderText = "Beskrivning";
            PBeskrivning.MinimumWidth = 6;
            PBeskrivning.Name = "PBeskrivning";
            // 
            // AntalAvsnitt
            // 
            AntalAvsnitt.HeaderText = "Antal avsnitt";
            AntalAvsnitt.MinimumWidth = 6;
            AntalAvsnitt.Name = "AntalAvsnitt";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(FilterComboBox);
            Controls.Add(h1);
            Controls.Add(TillbakaBtn);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterNew";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TillbakaBtn;
        private Label h1;
        private ComboBox FilterComboBox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PoddNamn;
        private DataGridViewTextBoxColumn PBeskrivning;
        private DataGridViewTextBoxColumn AntalAvsnitt;
    }
}