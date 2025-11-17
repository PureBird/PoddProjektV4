namespace PoddProjektV3._2
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
            header = new Label();
            comboBoxFilter = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tillbakaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Stencil", 26F, FontStyle.Bold | FontStyle.Italic);
            header.Location = new Point(55, 70);
            header.Name = "header";
            header.Size = new Size(239, 52);
            header.TabIndex = 0;
            header.Text = "Register";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(66, 136);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(300, 28);
            comboBoxFilter.TabIndex = 1;
            comboBoxFilter.Text = "Alla Poddar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(66, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(610, 270);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Podcast";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Beskrivning";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Antal avsnitt";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // tillbakaBtn
            // 
            tillbakaBtn.Location = new Point(33, 25);
            tillbakaBtn.Name = "tillbakaBtn";
            tillbakaBtn.Size = new Size(94, 29);
            tillbakaBtn.TabIndex = 3;
            tillbakaBtn.TabStop = false;
            tillbakaBtn.Text = "<- Tillbaka";
            tillbakaBtn.UseVisualStyleBackColor = true;
            tillbakaBtn.Click += tillbakaBtn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(tillbakaBtn);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxFilter);
            Controls.Add(header);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void tillbakaBtn_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Meny"].Show();
            this.Close();
        }

        #endregion

        private Label header;
        private ComboBox comboBoxFilter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button tillbakaBtn;
    }
}