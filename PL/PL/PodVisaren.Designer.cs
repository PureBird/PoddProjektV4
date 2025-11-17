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
            ((System.ComponentModel.ISupportInitialize)poddTabell).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Stencil", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(786, 61);
            label1.TabIndex = 2;
            label1.Text = "SÖK EFTER DIN FAVORITPODD";
            //label1.Click += label1_Click;
            // 
            // RSSTEXT
            // 
            RSSTEXT.Location = new Point(98, 103);
            RSSTEXT.Name = "RSSTEXT";
            RSSTEXT.Size = new Size(332, 31);
            RSSTEXT.TabIndex = 3;
            RSSTEXT.TextChanged += RSSTEXT_TextChanged;
            // 
            // visaPODD
            // 
            visaPODD.Location = new Point(622, 104);
            visaPODD.Name = "visaPODD";
            visaPODD.Size = new Size(112, 34);
            visaPODD.TabIndex = 4;
            visaPODD.Text = "button1";
            visaPODD.UseVisualStyleBackColor = true;
            visaPODD.Click += visaPODD_Click_1;
            // 
            // poddTabell
            // 
            poddTabell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            poddTabell.Location = new Point(12, 183);
            poddTabell.Name = "poddTabell";
            poddTabell.RowHeadersWidth = 62;
            poddTabell.Size = new Size(722, 225);
            poddTabell.TabIndex = 5;
            poddTabell.CellContentClick += poddTabell_CellContentClick;
            // 
            // PodVisaren
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(poddTabell);
            Controls.Add(visaPODD);
            Controls.Add(RSSTEXT);
            Controls.Add(label1);
            Name = "PodVisaren";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)poddTabell).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox RSSTEXT;
        private Button visaPODD;
        private DataGridView poddTabell;
    }
}
