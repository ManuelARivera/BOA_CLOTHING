
namespace BOA_CLOTHING.Formularios.Formularios_Resportes
{
    partial class FrmReportesStockMercancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportesStockMercancia));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvMercancia = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(81, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(40, 20);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.TextChanged += new System.EventHandler(this.Filtrar);
            // 
            // dgvMercancia
            // 
            this.dgvMercancia.AllowUserToAddRows = false;
            this.dgvMercancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercancia.Location = new System.Drawing.Point(16, 38);
            this.dgvMercancia.Name = "dgvMercancia";
            this.dgvMercancia.ReadOnly = true;
            this.dgvMercancia.Size = new System.Drawing.Size(535, 285);
            this.dgvMercancia.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(486, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(387, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Reportes de Stock ";
            // 
            // FrmReportesStockMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 392);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvMercancia);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportesStockMercancia";
            this.Text = "FrmReportesStockMercancia";
            this.Load += new System.EventHandler(this.FrmReportesStockMercancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvMercancia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
    }
}