
namespace Cuenta_Por_Pagar
{
    partial class FEstado_De_Cuenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBNumeroF = new System.Windows.Forms.TextBox();
            this.TBCodigoP = new System.Windows.Forms.TextBox();
            this.BVTodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVEstadoCuenta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstadoCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBNumeroF);
            this.groupBox1.Controls.Add(this.TBCodigoP);
            this.groupBox1.Controls.Add(this.BVTodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(72, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR";
            // 
            // TBNumeroF
            // 
            this.TBNumeroF.Location = new System.Drawing.Point(179, 80);
            this.TBNumeroF.Name = "TBNumeroF";
            this.TBNumeroF.Size = new System.Drawing.Size(235, 26);
            this.TBNumeroF.TabIndex = 4;
            this.TBNumeroF.TextChanged += new System.EventHandler(this.TBNumeroF_TextChanged);
            this.TBNumeroF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNumeroF_KeyPress);
            // 
            // TBCodigoP
            // 
            this.TBCodigoP.Location = new System.Drawing.Point(180, 35);
            this.TBCodigoP.Name = "TBCodigoP";
            this.TBCodigoP.Size = new System.Drawing.Size(234, 26);
            this.TBCodigoP.TabIndex = 3;
            this.TBCodigoP.TextChanged += new System.EventHandler(this.TBCodigoP_TextChanged);
            this.TBCodigoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigoP_KeyPress);
            // 
            // BVTodo
            // 
            this.BVTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVTodo.Location = new System.Drawing.Point(229, 112);
            this.BVTodo.Name = "BVTodo";
            this.BVTodo.Size = new System.Drawing.Size(119, 46);
            this.BVTodo.TabIndex = 2;
            this.BVTodo.Text = "Ver Todo";
            this.BVTodo.UseVisualStyleBackColor = true;
            this.BVTodo.Click += new System.EventHandler(this.BVTodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero De Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo De Proveedor";
            // 
            // DGVEstadoCuenta
            // 
            this.DGVEstadoCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEstadoCuenta.Location = new System.Drawing.Point(12, 185);
            this.DGVEstadoCuenta.Name = "DGVEstadoCuenta";
            this.DGVEstadoCuenta.RowHeadersWidth = 62;
            this.DGVEstadoCuenta.RowTemplate.Height = 28;
            this.DGVEstadoCuenta.Size = new System.Drawing.Size(748, 275);
            this.DGVEstadoCuenta.TabIndex = 1;
            // 
            // FEstado_De_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.DGVEstadoCuenta);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Name = "FEstado_De_Cuenta";
            this.Text = "Estado De Cuenta";
            this.Load += new System.EventHandler(this.FEstado_De_Cuenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstadoCuenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBNumeroF;
        private System.Windows.Forms.TextBox TBCodigoP;
        private System.Windows.Forms.Button BVTodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVEstadoCuenta;
    }
}