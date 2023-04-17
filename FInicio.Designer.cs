
namespace Cuenta_Por_Pagar
{
    partial class FInicio
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
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.TClave = new System.Windows.Forms.TextBox();
            this.DGVUsuario = new System.Windows.Forms.DataGridView();
            this.BEntrada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese El Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escribe La Contraseña";
            // 
            // TUsuario
            // 
            this.TUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUsuario.Location = new System.Drawing.Point(299, 34);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(226, 35);
            this.TUsuario.TabIndex = 2;
            this.TUsuario.TextChanged += new System.EventHandler(this.TUsuario_TextChanged);
            this.TUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TUsuario_KeyPress);
            // 
            // TClave
            // 
            this.TClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TClave.Location = new System.Drawing.Point(299, 94);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(226, 35);
            this.TClave.TabIndex = 3;
            this.TClave.TextChanged += new System.EventHandler(this.TClave_TextChanged);
            this.TClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TClave_KeyPress);
            // 
            // DGVUsuario
            // 
            this.DGVUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuario.Location = new System.Drawing.Point(12, 202);
            this.DGVUsuario.Name = "DGVUsuario";
            this.DGVUsuario.RowHeadersWidth = 62;
            this.DGVUsuario.RowTemplate.Height = 28;
            this.DGVUsuario.Size = new System.Drawing.Size(778, 258);
            this.DGVUsuario.TabIndex = 4;
            // 
            // BEntrada
            // 
            this.BEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEntrada.Location = new System.Drawing.Point(346, 138);
            this.BEntrada.Name = "BEntrada";
            this.BEntrada.Size = new System.Drawing.Size(135, 58);
            this.BEntrada.TabIndex = 5;
            this.BEntrada.Text = "Entrar";
            this.BEntrada.UseVisualStyleBackColor = true;
            this.BEntrada.Click += new System.EventHandler(this.BEntrada_Click);
            // 
            // FInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.BEntrada);
            this.Controls.Add(this.DGVUsuario);
            this.Controls.Add(this.TClave);
            this.Controls.Add(this.TUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Name = "FInicio";
            this.Text = "Inicio De Sesion";
            this.Load += new System.EventHandler(this.FInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TUsuario;
        private System.Windows.Forms.TextBox TClave;
        private System.Windows.Forms.DataGridView DGVUsuario;
        private System.Windows.Forms.Button BEntrada;
    }
}

