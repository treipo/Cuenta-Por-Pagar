
namespace Cuenta_Por_Pagar
{
    partial class FProveedores
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
            this.BAgregar = new System.Windows.Forms.Button();
            this.BModificar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.DGVProveedores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBCodido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProveedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(12, 38);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(97, 38);
            this.BAgregar.TabIndex = 0;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BModificar
            // 
            this.BModificar.Location = new System.Drawing.Point(151, 38);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(89, 38);
            this.BModificar.TabIndex = 1;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = true;
            this.BModificar.Click += new System.EventHandler(this.BModificar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(268, 38);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(88, 38);
            this.BEliminar.TabIndex = 2;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // DGVProveedores
            // 
            this.DGVProveedores.AllowUserToOrderColumns = true;
            this.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProveedores.Location = new System.Drawing.Point(-3, 106);
            this.DGVProveedores.Name = "DGVProveedores";
            this.DGVProveedores.RowHeadersWidth = 62;
            this.DGVProveedores.RowTemplate.Height = 28;
            this.DGVProveedores.Size = new System.Drawing.Size(500, 354);
            this.DGVProveedores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Provedores";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBTelefono);
            this.panel1.Controls.Add(this.TBCiudad);
            this.panel1.Controls.Add(this.TBDireccion);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.TBCodido);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(521, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 356);
            this.panel1.TabIndex = 5;
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(141, 290);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(100, 26);
            this.TBTelefono.TabIndex = 11;
            this.TBTelefono.TextChanged += new System.EventHandler(this.TBTelefono_TextChanged);
            this.TBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTelefono_KeyPress);
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(143, 241);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(100, 26);
            this.TBCiudad.TabIndex = 10;
            this.TBCiudad.TextChanged += new System.EventHandler(this.TBCiudad_TextChanged);
            this.TBCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCiudad_KeyPress);
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(141, 196);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(100, 26);
            this.TBDireccion.TabIndex = 9;
            this.TBDireccion.TextChanged += new System.EventHandler(this.TBDireccion_TextChanged);
            this.TBDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDireccion_KeyPress);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(141, 149);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(100, 26);
            this.TBApellido.TabIndex = 8;
            this.TBApellido.TextChanged += new System.EventHandler(this.TBApellido_TextChanged);
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBApellido_KeyPress);
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(141, 89);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 26);
            this.TBNombre.TabIndex = 7;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombre_KeyPress);
            // 
            // TBCodido
            // 
            this.TBCodido.Location = new System.Drawing.Point(141, 39);
            this.TBCodido.Name = "TBCodido";
            this.TBCodido.Size = new System.Drawing.Size(100, 26);
            this.TBCodido.TabIndex = 6;
            this.TBCodido.TextChanged += new System.EventHandler(this.TBCodido_TextChanged);
            this.TBCodido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodido_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ciudaad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // FProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVProveedores);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BModificar);
            this.Controls.Add(this.BAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Name = "FProveedores";
            this.Text = "Mantenimiento De Proveedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FProveedores_FormClosed);
            this.Load += new System.EventHandler(this.FProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.DataGridView DGVProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCodido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}