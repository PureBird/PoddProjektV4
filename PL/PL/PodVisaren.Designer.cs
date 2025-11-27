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
            label1.Location = new Point(267, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(659, 60);
            label1.TabIndex = 2;
            label1.Text = "SÖK EFTER DIN FAVORITPODD";
            label1.Click += label1_Click;
            // 
            // RSSTEXT
            // 
            RSSTEXT.BackColor = SystemColors.HighlightText;
            RSSTEXT.Location = new Point(13, 82);
            RSSTEXT.Margin = new Padding(2);
            RSSTEXT.Name = "RSSTEXT";
            RSSTEXT.PlaceholderText = "Länka din podd i rss format!";
            RSSTEXT.Size = new Size(346, 27);
            RSSTEXT.TabIndex = 3;
            RSSTEXT.TextChanged += RSSTEXT_TextChanged;
            // 
            // visaPODD
            // 
            visaPODD.Location = new Point(363, 82);
            visaPODD.Margin = new Padding(2);
            visaPODD.Name = "visaPODD";
            visaPODD.Size = new Size(143, 25);
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
            poddTabell.Location = new Point(13, 156);
            poddTabell.Margin = new Padding(2);
            poddTabell.Name = "poddTabell";
            poddTabell.RowHeadersWidth = 62;
            poddTabell.Size = new Size(494, 92);
            poddTabell.TabIndex = 5;
            poddTabell.CellContentClick += poddTabell_CellContentClick;
            // 
            // avsnittGrid
            // 
            avsnittGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            avsnittGrid.BackgroundColor = SystemColors.ButtonHighlight;
            avsnittGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            avsnittGrid.Location = new Point(512, 156);
            avsnittGrid.Margin = new Padding(3, 4, 3, 4);
            avsnittGrid.Name = "avsnittGrid";
            avsnittGrid.RowHeadersWidth = 62;
            avsnittGrid.Size = new Size(713, 494);
            avsnittGrid.TabIndex = 6;
            avsnittGrid.CellContentClick += avsnittGrid_CellContentClick;
            // 
            // sparaBTN
            // 
            sparaBTN.Location = new Point(829, 99);
            sparaBTN.Margin = new Padding(2);
            sparaBTN.Name = "sparaBTN";
            sparaBTN.Size = new Size(269, 27);
            sparaBTN.TabIndex = 7;
            sparaBTN.Text = "Spara din podd och dess avsnitt";
            sparaBTN.UseVisualStyleBackColor = true;
            sparaBTN.Click += sparaBTN_Click;
            // 
            // TillbakaBtn
            // 
            TillbakaBtn.BackColor = SystemColors.ActiveCaption;
            TillbakaBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TillbakaBtn.Location = new Point(26, 18);
            TillbakaBtn.Margin = new Padding(2);
            TillbakaBtn.Name = "TillbakaBtn";
            TillbakaBtn.Size = new Size(111, 31);
            TillbakaBtn.TabIndex = 8;
            TillbakaBtn.Text = "<-- Tillbaka";
            TillbakaBtn.UseVisualStyleBackColor = false;
            TillbakaBtn.Click += TillbakaBtn_Click;
            // 
            // PodVisaren
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1239, 686);
            Controls.Add(TillbakaBtn);
            Controls.Add(sparaBTN);
            Controls.Add(avsnittGrid);
            Controls.Add(poddTabell);
            Controls.Add(visaPODD);
            Controls.Add(RSSTEXT);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "PodVisaren";
            StartPosition = FormStartPosition.CenterScreen;
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
