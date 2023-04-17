
namespace Cuenta_Por_Pagar
{
    partial class FAgregarCheques
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
            this.BAgregarCQ = new System.Windows.Forms.Button();
            this.TBFechaCQ = new System.Windows.Forms.TextBox();
            this.TBValorCQ = new System.Windows.Forms.TextBox();
            this.TBNumeroF = new System.Windows.Forms.TextBox();
            this.TBNumeroCQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAgregarCQ
            // 
            this.BAgregarCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BAgregarCQ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BAgregarCQ.Location = new System.Drawing.Point(352, 313);
            this.BAgregarCQ.Name = "BAgregarCQ";
            this.BAgregarCQ.Size = new System.Drawing.Size(129, 51);
            this.BAgregarCQ.TabIndex = 21;
            this.BAgregarCQ.Text = "Agregar";
            this.BAgregarCQ.UseVisualStyleBackColor = true;
            this.BAgregarCQ.Click += new System.EventHandler(this.BAgregarCQ_Click);
            // 
            // TBFechaCQ
            // 
            this.TBFechaCQ.Location = new System.Drawing.Point(302, 244);
            this.TBFechaCQ.Name = "TBFechaCQ";
            this.TBFechaCQ.Size = new System.Drawing.Size(211, 26);
            this.TBFechaCQ.TabIndex = 19;
            this.TBFechaCQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFechaCQ_KeyPress);
            // 
            // TBValorCQ
            // 
            this.TBValorCQ.Location = new System.Drawing.Point(302, 178);
            this.TBValorCQ.Name = "TBValorCQ";
            this.TBValorCQ.Size = new System.Drawing.Size(211, 26);
            this.TBValorCQ.TabIndex = 18;
            this.TBValorCQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBValorCQ_KeyPress);
            // 
            // TBNumeroF
            // 
            this.TBNumeroF.Location = new System.Drawing.Point(302, 111);
            this.TBNumeroF.Name = "TBNumeroF";
            this.TBNumeroF.Size = new System.Drawing.Size(211, 26);
            this.TBNumeroF.TabIndex = 17;
            this.TBNumeroF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNumeroF_KeyPress);
            // 
            // TBNumeroCQ
            // 
            this.TBNumeroCQ.Location = new System.Drawing.Point(302, 49);
            this.TBNumeroCQ.Name = "TBNumeroCQ";
            this.TBNumeroCQ.Size = new System.Drawing.Size(189, 26);
            this.TBNumeroCQ.TabIndex = 16;
            this.TBNumeroCQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNumeroCQ_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(107, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha De Cheque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(107, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor De Cheque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(107, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numero De Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(107, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numero De Cheque";
            // 
            // FAgregarCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.BAgregarCQ);
            this.Controls.Add(this.TBFechaCQ);
            this.Controls.Add(this.TBValorCQ);
            this.Controls.Add(this.TBNumeroF);
            this.Controls.Add(this.TBNumeroCQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FAgregarCheques";
            this.Text = "Registrar Cheques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAgregarCQ;
        private System.Windows.Forms.TextBox TBFechaCQ;
        private System.Windows.Forms.TextBox TBValorCQ;
        private System.Windows.Forms.TextBox TBNumeroF;
        private System.Windows.Forms.TextBox TBNumeroCQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}