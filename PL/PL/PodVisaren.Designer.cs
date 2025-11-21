namespace PL
{
    partial class PodVisaren
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
            label1 = new Label();
            RSSTEXT = new TextBox();
            visaPODD = new Button();
            poddTabell = new DataGridView();
            avsnittGrid = new DataGridView();
            sparaBTN = new Button();
            TillbakaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)poddTabell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avsnittGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(796, 71);
            label1.TabIndex = 2;
            label1.Text = "SÖK EFTER DIN FAVORITPODD";
            label1.Click += label1_Click;
            // 
            // RSSTEXT
            // 
            RSSTEXT.BackColor = SystemColors.HighlightText;
            RSSTEXT.Location = new Point(16, 103);
            RSSTEXT.Name = "RSSTEXT";
            RSSTEXT.PlaceholderText = "Länka din podd i rss format!";
            RSSTEXT.Size = new Size(431, 31);
            RSSTEXT.TabIndex = 3;
            RSSTEXT.TextChanged += RSSTEXT_TextChanged;
            // 
            // visaPODD
            // 
            visaPODD.Location = new Point(454, 103);
            visaPODD.Name = "visaPODD";
            visaPODD.Size = new Size(179, 38);
            visaPODD.TabIndex = 4;
            visaPODD.Text = "Visa din podd";
            visaPODD.UseVisualStyleBackColor = true;
            visaPODD.Click += visaPODD_Click_1;
            // 
            // poddTabell
            // 
            poddTabell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            poddTabell.BackgroundColor = SystemColors.ButtonHighlight;
            poddTabell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            poddTabell.Location = new Point(16, 195);
            poddTabell.Name = "poddTabell";
            poddTabell.RowHeadersWidth = 62;
            poddTabell.Size = new Size(617, 115);
            poddTabell.TabIndex = 5;
            poddTabell.CellContentClick += poddTabell_CellContentClick;
            // 
            // avsnittGrid
            // 
            avsnittGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            avsnittGrid.BackgroundColor = SystemColors.ButtonHighlight;
            avsnittGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            avsnittGrid.Location = new Point(640, 195);
            avsnittGrid.Margin = new Padding(4, 5, 4, 5);
            avsnittGrid.Name = "avsnittGrid";
            avsnittGrid.RowHeadersWidth = 62;
            avsnittGrid.Size = new Size(891, 617);
            avsnittGrid.TabIndex = 6;
            avsnittGrid.CellContentClick += avsnittGrid_CellContentClick;
            // 
            // sparaBTN
            // 
            sparaBTN.Location = new Point(1036, 124);
            sparaBTN.Name = "sparaBTN";
            sparaBTN.Size = new Size(336, 34);
            sparaBTN.TabIndex = 7;
            sparaBTN.Text = "Spara din podd och dess avsnitt";
            sparaBTN.UseVisualStyleBackColor = true;
            sparaBTN.Click += sparaBTN_Click;
            // 
            // TillbakaBtn
            // 
            TillbakaBtn.BackColor = Color.Red;
            TillbakaBtn.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TillbakaBtn.Location = new Point(31, 23);
            TillbakaBtn.Name = "TillbakaBtn";
            TillbakaBtn.Size = new Size(144, 43);
            TillbakaBtn.TabIndex = 8;
            TillbakaBtn.Text = "Tillbaka";
            TillbakaBtn.UseVisualStyleBackColor = false;
            TillbakaBtn.Click += TillbakaBtn_Click;
            // 
            // PodVisaren
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1549, 858);
            Controls.Add(TillbakaBtn);
            Controls.Add(sparaBTN);
            Controls.Add(avsnittGrid);
            Controls.Add(poddTabell);
            Controls.Add(visaPODD);
            Controls.Add(RSSTEXT);
            Controls.Add(label1);
            Name = "PodVisaren";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)poddTabell).EndInit();
            ((System.ComponentModel.ISupportInitialize)avsnittGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox RSSTEXT;
        private Button visaPODD;
        private DataGridView poddTabell;
        private DataGridView avsnittGrid;
        private Button sparaBTN;
        private Button TillbakaBtn;
    }
}
