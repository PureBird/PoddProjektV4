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
            ((System.ComponentModel.ISupportInitialize)poddTabell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avsnittGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(540, 47);
            label1.TabIndex = 2;
            label1.Text = "SÖK EFTER DIN FAVORITPODD";
            // 
            // RSSTEXT
            // 
            RSSTEXT.BackColor = SystemColors.HighlightText;
            RSSTEXT.Location = new Point(11, 62);
            RSSTEXT.Margin = new Padding(2);
            RSSTEXT.Name = "RSSTEXT";
            RSSTEXT.PlaceholderText = "Länka din podd i rss format!";
            RSSTEXT.Size = new Size(303, 23);
            RSSTEXT.TabIndex = 3;
            RSSTEXT.TextChanged += RSSTEXT_TextChanged;
            // 
            // visaPODD
            // 
            visaPODD.Location = new Point(318, 62);
            visaPODD.Margin = new Padding(2);
            visaPODD.Name = "visaPODD";
            visaPODD.Size = new Size(88, 23);
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
            poddTabell.Location = new Point(11, 117);
            poddTabell.Margin = new Padding(2);
            poddTabell.Name = "poddTabell";
            poddTabell.RowHeadersWidth = 62;
            poddTabell.Size = new Size(432, 69);
            poddTabell.TabIndex = 5;
            poddTabell.CellContentClick += poddTabell_CellContentClick;
            // 
            // avsnittGrid
            // 
            avsnittGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            avsnittGrid.BackgroundColor = SystemColors.ButtonHighlight;
            avsnittGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            avsnittGrid.Location = new Point(448, 117);
            avsnittGrid.Name = "avsnittGrid";
            avsnittGrid.Size = new Size(624, 370);
            avsnittGrid.TabIndex = 6;
            avsnittGrid.CellContentClick += avsnittGrid_CellContentClick;
            // 
            // PodVisaren
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1084, 515);
            Controls.Add(avsnittGrid);
            Controls.Add(poddTabell);
            Controls.Add(visaPODD);
            Controls.Add(RSSTEXT);
            Controls.Add(label1);
            Margin = new Padding(2);
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
    }
}
