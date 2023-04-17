
namespace Cuenta_Por_Pagar
{
    partial class FAgregarFacturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBNumeroF = new System.Windows.Forms.TextBox();
            this.TBCodigoC = new System.Windows.Forms.TextBox();
            this.TBValorF = new System.Windows.Forms.TextBox();
            this.TBFechaF = new System.Windows.Forms.TextBox();
            this.TBFechaV = new System.Windows.Forms.TextBox();
            this.BAgregarf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero De Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor De Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha De Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha De Vencimiento";
            // 
            // TBNumeroF
            // 
            this.TBNumeroF.Location = new System.Drawing.Point(344, 47);
            this.TBNumeroF.Name = "TBNumeroF";
            this.TBNumeroF.Size = new System.Drawing.Size(189, 26);
            this.TBNumeroF.TabIndex = 5;
            this.TBNumeroF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNumeroF_KeyPress);
            // 
            // TBCodigoC
            // 
            this.TBCodigoC.Location = new System.Drawing.Point(344, 109);
            this.TBCodigoC.Name = "TBCodigoC";
            this.TBCodigoC.Size = new System.Drawing.Size(211, 26);
            this.TBCodigoC.TabIndex = 6;
            this.TBCodigoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigoC_KeyPress);
            // 
            // TBValorF
            // 
            this.TBValorF.Location = new System.Drawing.Point(344, 176);
            this.TBValorF.Name = "TBValorF";
            this.TBValorF.Size = new System.Drawing.Size(211, 26);
            this.TBValorF.TabIndex = 7;
            this.TBValorF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBValorF_KeyPress);
            // 
            // TBFechaF
            // 
            this.TBFechaF.Location = new System.Drawing.Point(344, 241);
            this.TBFechaF.Name = "TBFechaF";
            this.TBFechaF.Size = new System.Drawing.Size(211, 26);
            this.TBFechaF.TabIndex = 8;
            this.TBFechaF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFechaF_KeyPress);
            // 
            // TBFechaV
            // 
            this.TBFechaV.Location = new System.Drawing.Point(344, 304);
            this.TBFechaV.Name = "TBFechaV";
            this.TBFechaV.Size = new System.Drawing.Size(211, 26);
            this.TBFechaV.TabIndex = 9;
            this.TBFechaV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFechaV_KeyPress);
            // 
            // BAgregarf
            // 
            this.BAgregarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarf.Location = new System.Drawing.Point(384, 350);
            this.BAgregarf.Name = "BAgregarf";
            this.BAgregarf.Size = new System.Drawing.Size(129, 51);
            this.BAgregarf.TabIndex = 10;
            this.BAgregarf.Text = "Agregar";
            this.BAgregarf.UseVisualStyleBackColor = true;
            this.BAgregarf.Click += new System.EventHandler(this.BAgregarf_Click);
            // 
            // FAgregarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.BAgregarf);
            this.Controls.Add(this.TBFechaV);
            this.Controls.Add(this.TBFechaF);
            this.Controls.Add(this.TBValorF);
            this.Controls.Add(this.TBCodigoC);
            this.Controls.Add(this.TBNumeroF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Name = "FAgregarFacturas";
            this.Text = "Registrar Datos De Facturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBNumeroF;
        private System.Windows.Forms.TextBox TBCodigoC;
        private System.Windows.Forms.TextBox TBValorF;
        private System.Windows.Forms.TextBox TBFechaF;
        private System.Windows.Forms.TextBox TBFechaV;
        private System.Windows.Forms.Button BAgregarf;
    }
}