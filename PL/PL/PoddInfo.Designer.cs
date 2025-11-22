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
            btnTillbaka = new Button();
            btnTaBort = new Button();
            ((System.ComponentModel.ISupportInitialize)podcastBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PoddTitel
            // 
            PoddTitel.AutoSize = true;
            PoddTitel.Font = new Font("Segoe UI", 19F);
            PoddTitel.Location = new Point(12, 73);
            PoddTitel.Name = "PoddTitel";
            PoddTitel.Size = new Size(225, 51);
            PoddTitel.TabIndex = 0;
            PoddTitel.Text = "En poddtitel";
            // 
            // Kategori1
            // 
            Kategori1.AutoSize = true;
            Kategori1.Location = new Point(12, 145);
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
            AvsnittTitel.Location = new Point(12, 194);
            AvsnittTitel.Name = "AvsnittTitel";
            AvsnittTitel.Size = new Size(278, 304);
            AvsnittTitel.TabIndex = 2;
            AvsnittTitel.SelectedIndexChanged += AvsnittTitel_SelectedIndexChanged;
            // 
            // AvsnittInfo
            // 
            AvsnittInfo.Location = new Point(367, 194);
            AvsnittInfo.Multiline = true;
            AvsnittInfo.Name = "AvsnittInfo";
            AvsnittInfo.ScrollBars = ScrollBars.Vertical;
            AvsnittInfo.Size = new Size(405, 304);
            AvsnittInfo.TabIndex = 3;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Location = new Point(622, 12);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(150, 34);
            btnAndraKategori.TabIndex = 4;
            btnAndraKategori.Text = "Ändra kategori";
            btnAndraKategori.UseVisualStyleBackColor = true;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // tbNykategori
            // 
            tbNykategori.Location = new Point(622, 61);
            tbNykategori.Name = "tbNykategori";
            tbNykategori.Size = new Size(150, 31);
            tbNykategori.TabIndex = 5;
            // 
            // btnAndraTitel
            // 
            btnAndraTitel.Location = new Point(504, 11);
            btnAndraTitel.Name = "btnAndraTitel";
            btnAndraTitel.Size = new Size(112, 34);
            btnAndraTitel.TabIndex = 6;
            btnAndraTitel.Text = "Ändra titel";
            btnAndraTitel.UseVisualStyleBackColor = true;
            btnAndraTitel.Click += btnAndraTitel_Click;
            // 
            // txbAndraTitel
            // 
            txbAndraTitel.Location = new Point(504, 61);
            txbAndraTitel.Name = "txbAndraTitel";
            txbAndraTitel.Size = new Size(112, 31);
            txbAndraTitel.TabIndex = 7;
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(12, 12);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(112, 34);
            btnTillbaka.TabIndex = 8;
            btnTillbaka.Text = "<- Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(330, 11);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(149, 34);
            btnTaBort.TabIndex = 9;
            btnTaBort.Text = "Avprenumerera";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            // 
            // PoddInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(btnTaBort);
            Controls.Add(btnTillbaka);
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
        private Button btnTillbaka;
        private Button btnTaBort;
    }
}