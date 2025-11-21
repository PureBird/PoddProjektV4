namespace PL
{
    partial class PoddInfo
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
            components = new System.ComponentModel.Container();
            PoddTitel = new Label();
            Kategori1 = new Label();
            podcastBindingSource = new BindingSource(components);
            AvsnittTitel = new ListBox();
            AvsnittInfo = new TextBox();
            btnAndraKategori = new Button();
            tbNykategori = new TextBox();
            btnAndraTitel = new Button();
            txbAndraTitel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)podcastBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PoddTitel
            // 
            PoddTitel.AutoSize = true;
            PoddTitel.Font = new Font("Segoe UI", 19F);
            PoddTitel.Location = new Point(12, 9);
            PoddTitel.Name = "PoddTitel";
            PoddTitel.Size = new Size(225, 51);
            PoddTitel.TabIndex = 0;
            PoddTitel.Text = "En poddtitel";
            // 
            // Kategori1
            // 
            Kategori1.AutoSize = true;
            Kategori1.Location = new Point(12, 81);
            Kategori1.Name = "Kategori1";
            Kategori1.Size = new Size(88, 25);
            Kategori1.TabIndex = 1;
            Kategori1.Text = "Kategori1";
            // 
            // podcastBindingSource
            // 
            podcastBindingSource.DataSource = typeof(PoddProjektV4.Models.Podcast);
            // 
            // AvsnittTitel
            // 
            AvsnittTitel.FormattingEnabled = true;
            AvsnittTitel.ItemHeight = 25;
            AvsnittTitel.Location = new Point(12, 130);
            AvsnittTitel.Name = "AvsnittTitel";
            AvsnittTitel.Size = new Size(278, 304);
            AvsnittTitel.TabIndex = 2;
            AvsnittTitel.SelectedIndexChanged += AvsnittTitel_SelectedIndexChanged;
            // 
            // AvsnittInfo
            // 
            AvsnittInfo.Location = new Point(360, 130);
            AvsnittInfo.Multiline = true;
            AvsnittInfo.Name = "AvsnittInfo";
            AvsnittInfo.Size = new Size(405, 304);
            AvsnittInfo.TabIndex = 3;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Location = new Point(622, 26);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(150, 34);
            btnAndraKategori.TabIndex = 4;
            btnAndraKategori.Text = "Ändra kategori";
            btnAndraKategori.UseVisualStyleBackColor = true;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // tbNykategori
            // 
            tbNykategori.Location = new Point(622, 75);
            tbNykategori.Name = "tbNykategori";
            tbNykategori.Size = new Size(150, 31);
            tbNykategori.TabIndex = 5;
            // 
            // btnAndraTitel
            // 
            btnAndraTitel.Location = new Point(504, 25);
            btnAndraTitel.Name = "btnAndraTitel";
            btnAndraTitel.Size = new Size(112, 34);
            btnAndraTitel.TabIndex = 6;
            btnAndraTitel.Text = "Ändra titel";
            btnAndraTitel.UseVisualStyleBackColor = true;
            btnAndraTitel.Click += btnAndraTitel_Click;
            // 
            // txbAndraTitel
            // 
            txbAndraTitel.Location = new Point(504, 75);
            txbAndraTitel.Name = "txbAndraTitel";
            txbAndraTitel.Size = new Size(112, 31);
            txbAndraTitel.TabIndex = 7;
            // 
            // PoddInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbAndraTitel);
            Controls.Add(btnAndraTitel);
            Controls.Add(tbNykategori);
            Controls.Add(btnAndraKategori);
            Controls.Add(AvsnittInfo);
            Controls.Add(AvsnittTitel);
            Controls.Add(Kategori1);
            Controls.Add(PoddTitel);
            Name = "PoddInfo";
            Text = "PoddInfo";
            ((System.ComponentModel.ISupportInitialize)podcastBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PoddTitel;
        private Label Kategori1;
        private BindingSource podcastBindingSource;
        private ListBox AvsnittTitel;
        private TextBox AvsnittInfo;
        private Button btnAndraKategori;
        private TextBox tbNykategori;
        private Button btnAndraTitel;
        private TextBox txbAndraTitel;
    }
}