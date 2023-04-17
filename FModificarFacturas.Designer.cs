
namespace Cuenta_Por_Pagar
{
    partial class FModificarFacturas
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
            this.BAtualizarF = new System.Windows.Forms.Button();
            this.TBFechaV = new System.Windows.Forms.TextBox();
            this.TBFechaF = new System.Windows.Forms.TextBox();
            this.TBValorF = new System.Windows.Forms.TextBox();
            this.TBCodigoC = new System.Windows.Forms.TextBox();
            this.TBNumeroF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAtualizarF
            // 
            this.BAtualizarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAtualizarF.Location = new System.Drawing.Point(408, 351);
            this.BAtualizarF.Name = "BAtualizarF";
            this.BAtualizarF.Size = new System.Drawing.Size(129, 50);
            this.BAtualizarF.TabIndex = 21;
            this.BAtualizarF.Text = "Actualizar";
            this.BAtualizarF.UseVisualStyleBackColor = true;
            this.BAtualizarF.Click += new System.EventHandler(this.BAtualizarF_Click);
            // 
            // TBFechaV
            // 
            this.TBFechaV.Location = new System.Drawing.Point(333, 306);
            this.TBFechaV.Name = "TBFechaV";
            this.TBFechaV.Size = new System.Drawing.Size(258, 26);
            this.TBFechaV.TabIndex = 20;
            this.TBFechaV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFechaV_KeyPress);
            // 
            // TBFechaF
            // 
            this.TBFechaF.Location = new System.Drawing.Point(333, 243);
            this.TBFechaF.Name = "TBFechaF";
            this.TBFechaF.Size = new System.Drawing.Size(258, 26);
            this.TBFechaF.TabIndex = 19;
            this.TBFechaF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFechaF_KeyPress);
            // 
            // TBValorF
            // 
            this.TBValorF.Location = new System.Drawing.Point(333, 177);
            this.TBValorF.Name = "TBValorF";
            this.TBValorF.Size = new System.Drawing.Size(258, 26);
            this.TBValorF.TabIndex = 18;
            this.TBValorF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBValorF_KeyPress);
            // 
            // TBCodigoC
            // 
            this.TBCodigoC.Location = new System.Drawing.Point(333, 110);
            this.TBCodigoC.Name = "TBCodigoC";
            this.TBCodigoC.Size = new System.Drawing.Size(258, 26);
            this.TBCodigoC.TabIndex = 17;
            this.TBCodigoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigoC_KeyPress);
            // 
            // TBNumeroF
            // 
            this.TBNumeroF.Location = new System.Drawing.Point(333, 48);
            this.TBNumeroF.Name = "TBNumeroF";
            this.TBNumeroF.Size = new System.Drawing.Size(226, 26);
            this.TBNumeroF.TabIndex = 16;
           // this.TBNumeroF.TextChanged += new System.EventHandler(this.TBNumeroF_TextChanged);
            this.TBNumeroF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNumeroF_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha De Vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha De Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor De Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Codigo Del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numero De Factura";
            // 
            // FModificarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.BAtualizarF);
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
            this.Name = "FModificarFacturas";
            this.Text = "Modificar Datos De Facturas";
            this.Load += new System.EventHandler(this.FModificarFacturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAtualizarF;
        private System.Windows.Forms.TextBox TBFechaV;
        private System.Windows.Forms.TextBox TBFechaF;
        private System.Windows.Forms.TextBox TBValorF;
        private System.Windows.Forms.TextBox TBCodigoC;
        private System.Windows.Forms.TextBox TBNumeroF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}