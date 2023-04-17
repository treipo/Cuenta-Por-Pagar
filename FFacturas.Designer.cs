
namespace Cuenta_Por_Pagar
{
    partial class FFacturas
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
            this.BEliminarF = new System.Windows.Forms.Button();
            this.BModificarF = new System.Windows.Forms.Button();
            this.BAgregarF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBCodigoF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNumeroF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVFacturas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // BEliminarF
            // 
            this.BEliminarF.Location = new System.Drawing.Point(611, 175);
            this.BEliminarF.Name = "BEliminarF";
            this.BEliminarF.Size = new System.Drawing.Size(92, 48);
            this.BEliminarF.TabIndex = 11;
            this.BEliminarF.Text = "Eliminar";
            this.BEliminarF.UseVisualStyleBackColor = true;
            this.BEliminarF.Click += new System.EventHandler(this.BEliminarF_Click);
            // 
            // BModificarF
            // 
            this.BModificarF.Location = new System.Drawing.Point(611, 105);
            this.BModificarF.Name = "BModificarF";
            this.BModificarF.Size = new System.Drawing.Size(92, 50);
            this.BModificarF.TabIndex = 10;
            this.BModificarF.Text = "Modificar";
            this.BModificarF.UseVisualStyleBackColor = true;
            this.BModificarF.Click += new System.EventHandler(this.BModificarF_Click);
            // 
            // BAgregarF
            // 
            this.BAgregarF.Location = new System.Drawing.Point(611, 34);
            this.BAgregarF.Name = "BAgregarF";
            this.BAgregarF.Size = new System.Drawing.Size(92, 50);
            this.BAgregarF.TabIndex = 9;
            this.BAgregarF.Text = "Agregar";
            this.BAgregarF.UseVisualStyleBackColor = true;
            this.BAgregarF.Click += new System.EventHandler(this.BAgregarF_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBCodigoF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBNumeroF);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(508, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 186);
            this.panel1.TabIndex = 8;
            // 
            // TBCodigoF
            // 
            this.TBCodigoF.Location = new System.Drawing.Point(166, 93);
            this.TBCodigoF.Name = "TBCodigoF";
            this.TBCodigoF.Size = new System.Drawing.Size(100, 26);
            this.TBCodigoF.TabIndex = 3;
            this.TBCodigoF.TextChanged += new System.EventHandler(this.TBCodigoF_TextChanged);
          //  this.TBCodigoF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigoF_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo De Proveedor";
            // 
            // TBNumeroF
            // 
            this.TBNumeroF.Location = new System.Drawing.Point(166, 42);
            this.TBNumeroF.Name = "TBNumeroF";
            this.TBNumeroF.Size = new System.Drawing.Size(100, 26);
            this.TBNumeroF.TabIndex = 1;
            this.TBNumeroF.TextChanged += new System.EventHandler(this.TBNumeroF_TextChanged);
            this.TBNumeroF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNumeroF_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero De actura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar Factura";
            // 
            // DGVFacturas
            // 
            this.DGVFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFacturas.Location = new System.Drawing.Point(20, 8);
            this.DGVFacturas.Name = "DGVFacturas";
            this.DGVFacturas.RowHeadersWidth = 62;
            this.DGVFacturas.RowTemplate.Height = 28;
            this.DGVFacturas.Size = new System.Drawing.Size(482, 457);
            this.DGVFacturas.TabIndex = 6;
            // 
            // FFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.BEliminarF);
            this.Controls.Add(this.BModificarF);
            this.Controls.Add(this.BAgregarF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVFacturas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Name = "FFacturas";
            this.Text = "Mantenimiento De Factura";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FFacturas_FormClosed);
            this.Load += new System.EventHandler(this.FFacturas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BEliminarF;
        private System.Windows.Forms.Button BModificarF;
        private System.Windows.Forms.Button BAgregarF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBCodigoF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNumeroF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVFacturas;
    }
}