
namespace Cuenta_Por_Pagar
{
    partial class FCheques
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
            this.BEliminarCQ = new System.Windows.Forms.Button();
            this.BModificarCQ = new System.Windows.Forms.Button();
            this.BAgregarCQ = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBNumeroF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNumeroCQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVCheque = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCheque)).BeginInit();
            this.SuspendLayout();
            // 
            // BEliminarCQ
            // 
            this.BEliminarCQ.Location = new System.Drawing.Point(611, 175);
            this.BEliminarCQ.Name = "BEliminarCQ";
            this.BEliminarCQ.Size = new System.Drawing.Size(92, 45);
            this.BEliminarCQ.TabIndex = 17;
            this.BEliminarCQ.Text = "Eliminar";
            this.BEliminarCQ.UseVisualStyleBackColor = true;
            this.BEliminarCQ.Click += new System.EventHandler(this.BEliminarCQ_Click);
            // 
            // BModificarCQ
            // 
            this.BModificarCQ.Location = new System.Drawing.Point(611, 98);
            this.BModificarCQ.Name = "BModificarCQ";
            this.BModificarCQ.Size = new System.Drawing.Size(92, 44);
            this.BModificarCQ.TabIndex = 16;
            this.BModificarCQ.Text = "Modificar";
            this.BModificarCQ.UseVisualStyleBackColor = true;
            this.BModificarCQ.Click += new System.EventHandler(this.BModificarCQ_Click);
            // 
            // BAgregarCQ
            // 
            this.BAgregarCQ.Location = new System.Drawing.Point(611, 34);
            this.BAgregarCQ.Name = "BAgregarCQ";
            this.BAgregarCQ.Size = new System.Drawing.Size(92, 40);
            this.BAgregarCQ.TabIndex = 15;
            this.BAgregarCQ.Text = "Agregar";
            this.BAgregarCQ.UseVisualStyleBackColor = true;
            this.BAgregarCQ.Click += new System.EventHandler(this.BAgregarCQ_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBNumeroF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBNumeroCQ);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(508, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 186);
            this.panel1.TabIndex = 14;
            // 
            // TBNumeroF
            // 
            this.TBNumeroF.Location = new System.Drawing.Point(166, 62);
            this.TBNumeroF.Name = "TBNumeroF";
            this.TBNumeroF.Size = new System.Drawing.Size(100, 26);
            this.TBNumeroF.TabIndex = 3;
            this.TBNumeroF.TextChanged += new System.EventHandler(this.TBNumeroF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero De Factura";
            // 
            // TBNumeroCQ
            // 
            this.TBNumeroCQ.Location = new System.Drawing.Point(166, 10);
            this.TBNumeroCQ.Name = "TBNumeroCQ";
            this.TBNumeroCQ.Size = new System.Drawing.Size(100, 26);
            this.TBNumeroCQ.TabIndex = 1;
            this.TBNumeroCQ.TextChanged += new System.EventHandler(this.TBNumeroCQ_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero De Cheque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar Cheque";
            // 
            // DGVCheque
            // 
            this.DGVCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCheque.Location = new System.Drawing.Point(20, 8);
            this.DGVCheque.Name = "DGVCheque";
            this.DGVCheque.RowHeadersWidth = 62;
            this.DGVCheque.RowTemplate.Height = 28;
            this.DGVCheque.Size = new System.Drawing.Size(482, 457);
            this.DGVCheque.TabIndex = 12;
            // 
            // FCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.BEliminarCQ);
            this.Controls.Add(this.BModificarCQ);
            this.Controls.Add(this.BAgregarCQ);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVCheque);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Name = "FCheques";
            this.Text = "Mantenimiento De cheques";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FCheques_FormClosed);
            this.Load += new System.EventHandler(this.FCheques_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCheque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BEliminarCQ;
        private System.Windows.Forms.Button BModificarCQ;
        private System.Windows.Forms.Button BAgregarCQ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBNumeroF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNumeroCQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVCheque;
    }
}