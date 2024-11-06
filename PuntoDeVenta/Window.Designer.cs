namespace PuntoDeVenta
{
    partial class Window
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BProductos = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bVentas = new System.Windows.Forms.Button();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx5 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.tbx8 = new System.Windows.Forms.TextBox();
            this.lb8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bMostrar = new System.Windows.Forms.Button();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx6 = new System.Windows.Forms.TextBox();
            this.lb6 = new System.Windows.Forms.Label();
            this.tbx7 = new System.Windows.Forms.TextBox();
            this.lb7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bEditar = new System.Windows.Forms.Button();
            this.ListDesplegable1 = new System.Windows.Forms.ComboBox();
            this.ListDesplegable2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BProductos
            // 
            this.BProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.BProductos.Location = new System.Drawing.Point(539, 31);
            this.BProductos.Name = "BProductos";
            this.BProductos.Size = new System.Drawing.Size(93, 40);
            this.BProductos.TabIndex = 0;
            this.BProductos.Text = "Productos";
            this.BProductos.UseVisualStyleBackColor = false;
            this.BProductos.Visible = false;
            this.BProductos.Click += new System.EventHandler(this.BProductos_Click);
            // 
            // bClientes
            // 
            this.bClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.bClientes.Location = new System.Drawing.Point(638, 31);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(93, 40);
            this.bClientes.TabIndex = 1;
            this.bClientes.Text = "Clientes";
            this.bClientes.UseVisualStyleBackColor = false;
            this.bClientes.Visible = false;
            this.bClientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // bVentas
            // 
            this.bVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.bVentas.Location = new System.Drawing.Point(732, 31);
            this.bVentas.Name = "bVentas";
            this.bVentas.Size = new System.Drawing.Size(93, 40);
            this.bVentas.TabIndex = 2;
            this.bVentas.Text = "Ventas";
            this.bVentas.UseVisualStyleBackColor = false;
            this.bVentas.Visible = false;
            this.bVentas.Click += new System.EventHandler(this.button3_Click);
            // 
            // bRegistrar
            // 
            this.bRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(184)))));
            this.bRegistrar.Location = new System.Drawing.Point(215, 444);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(75, 23);
            this.bRegistrar.TabIndex = 5;
            this.bRegistrar.Text = "Registrar";
            this.bRegistrar.UseVisualStyleBackColor = false;
            this.bRegistrar.Visible = false;
            this.bRegistrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.bBorrar.Enabled = false;
            this.bBorrar.Location = new System.Drawing.Point(715, 444);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 3;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = false;
            this.bBorrar.Visible = false;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(715, 145);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 6;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pretty Woman Boutique";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(47, 198);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(23, 13);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "lb1";
            this.lb1.Visible = false;
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(47, 230);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(23, 13);
            this.lb2.TabIndex = 10;
            this.lb2.Text = "lb2";
            this.lb2.Visible = false;
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(47, 322);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(23, 13);
            this.lb5.TabIndex = 13;
            this.lb5.Text = "lb5";
            this.lb5.Visible = false;
            this.lb5.Click += new System.EventHandler(this.lb5_Click);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(47, 291);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(23, 13);
            this.lb4.TabIndex = 12;
            this.lb4.Text = "lb4";
            this.lb4.Visible = false;
            this.lb4.Click += new System.EventHandler(this.lb4_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(47, 261);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(23, 13);
            this.lb3.TabIndex = 11;
            this.lb3.Text = "lb3";
            this.lb3.Visible = false;
            this.lb3.Click += new System.EventHandler(this.lb3_Click);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(158, 195);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(132, 20);
            this.tbx1.TabIndex = 15;
            this.tbx1.Visible = false;
            this.tbx1.TextChanged += new System.EventHandler(this.tbx1_TextChanged);
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(158, 258);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(132, 20);
            this.tbx3.TabIndex = 17;
            this.tbx3.Visible = false;
            this.tbx3.TextChanged += new System.EventHandler(this.tbx3_TextChanged);
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(158, 227);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(132, 20);
            this.tbx2.TabIndex = 16;
            this.tbx2.Visible = false;
            this.tbx2.TextChanged += new System.EventHandler(this.tbx2_TextChanged);
            // 
            // tbx5
            // 
            this.tbx5.Location = new System.Drawing.Point(158, 319);
            this.tbx5.Name = "tbx5";
            this.tbx5.Size = new System.Drawing.Size(132, 20);
            this.tbx5.TabIndex = 19;
            this.tbx5.Visible = false;
            this.tbx5.TextChanged += new System.EventHandler(this.tbx5_TextChanged);
            // 
            // tbx4
            // 
            this.tbx4.Location = new System.Drawing.Point(158, 288);
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(132, 20);
            this.tbx4.TabIndex = 18;
            this.tbx4.Visible = false;
            this.tbx4.TextChanged += new System.EventHandler(this.tbx4_TextChanged);
            // 
            // tbx8
            // 
            this.tbx8.Location = new System.Drawing.Point(609, 145);
            this.tbx8.Name = "tbx8";
            this.tbx8.Size = new System.Drawing.Size(100, 20);
            this.tbx8.TabIndex = 20;
            this.tbx8.Visible = false;
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(519, 148);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(21, 13);
            this.lb8.TabIndex = 21;
            this.lb8.Text = "lb8";
            this.lb8.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(323, 444);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(113, 23);
            this.bMostrar.TabIndex = 26;
            this.bMostrar.Text = "Mostrar Todo";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Visible = false;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // GridView1
            // 
            this.GridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(206)))));
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(322, 184);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(482, 238);
            this.GridView1.TabIndex = 27;
            this.GridView1.Visible = false;
            this.GridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tbx6
            // 
            this.tbx6.Location = new System.Drawing.Point(158, 345);
            this.tbx6.Name = "tbx6";
            this.tbx6.Size = new System.Drawing.Size(132, 20);
            this.tbx6.TabIndex = 30;
            this.tbx6.Visible = false;
            this.tbx6.TextChanged += new System.EventHandler(this.tbx6_TextChanged);
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(47, 348);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(23, 13);
            this.lb6.TabIndex = 29;
            this.lb6.Text = "lb6";
            this.lb6.Visible = false;
            this.lb6.Click += new System.EventHandler(this.lb6_Click);
            // 
            // tbx7
            // 
            this.tbx7.Location = new System.Drawing.Point(158, 371);
            this.tbx7.Name = "tbx7";
            this.tbx7.Size = new System.Drawing.Size(132, 20);
            this.tbx7.TabIndex = 32;
            this.tbx7.Visible = false;
            this.tbx7.TextChanged += new System.EventHandler(this.tbx7_TextChanged);
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.Location = new System.Drawing.Point(47, 374);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(23, 13);
            this.lb7.TabIndex = 31;
            this.lb7.Text = "lb7";
            this.lb7.Visible = false;
            this.lb7.Click += new System.EventHandler(this.lb7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bEditar
            // 
            this.bEditar.Enabled = false;
            this.bEditar.Location = new System.Drawing.Point(617, 444);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(75, 23);
            this.bEditar.TabIndex = 34;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Visible = false;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // ListDesplegable1
            // 
            this.ListDesplegable1.FormattingEnabled = true;
            this.ListDesplegable1.Items.AddRange(new object[] {
            "Pieza",
            "Caja"});
            this.ListDesplegable1.Location = new System.Drawing.Point(158, 257);
            this.ListDesplegable1.Name = "ListDesplegable1";
            this.ListDesplegable1.Size = new System.Drawing.Size(121, 21);
            this.ListDesplegable1.TabIndex = 35;
            this.ListDesplegable1.Visible = false;
            // 
            // ListDesplegable2
            // 
            this.ListDesplegable2.FormattingEnabled = true;
            this.ListDesplegable2.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL"});
            this.ListDesplegable2.Location = new System.Drawing.Point(158, 318);
            this.ListDesplegable2.Name = "ListDesplegable2";
            this.ListDesplegable2.Size = new System.Drawing.Size(121, 21);
            this.ListDesplegable2.TabIndex = 36;
            this.ListDesplegable2.Visible = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(849, 492);
            this.Controls.Add(this.ListDesplegable2);
            this.Controls.Add(this.ListDesplegable1);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx7);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.tbx6);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.tbx8);
            this.Controls.Add(this.tbx5);
            this.Controls.Add(this.tbx4);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bRegistrar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bVentas);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.BProductos);
            this.Name = "Window";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BProductos;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bVentas;
        private System.Windows.Forms.Button bRegistrar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx5;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.TextBox tbx8;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bMostrar;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx6;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.TextBox tbx7;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.ComboBox ListDesplegable1;
        private System.Windows.Forms.ComboBox ListDesplegable2;
    }
}

