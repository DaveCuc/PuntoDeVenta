using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
using MySql.Data.MySqlClient;


namespace PuntoDeVenta
{
    public partial class Window : Form
    {

        MySqlCommand comando = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private void button1_Click(object sender, EventArgs e) //prueba de conexion
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            conn.Open();

            MessageBox.Show("Base de Datos conectada");

            button1.Visible = false;

            BProductos.Visible = true;
            bClientes.Visible = true;
            bVentas.Visible = true;
            tbx8.Visible = true;
            bBuscar.Visible = true;
            bRegistrar.Visible = true;
            bMostrar.Visible = true;
            bBorrar.Visible = true;
            bEditar.Visible = true;
            GridView1.Visible = true;








        }


        private string seccionActiva = "";

        public Window()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //menu Clientes
        {
            seccionActiva = "Clientes";;

            label2.Visible = true;
            label2.Text = "Clientes";
            
            lb1.Visible = Enabled;
            
            
            lb2.Visible = Enabled;
            
            tbx2.Visible = Enabled;
            lb3.Visible = Enabled;
            lb4.Visible = Enabled;
            lb5.Visible = Enabled;
            lb8.Visible = Enabled;

            lb1.Text = "Nombre del Cliente";
            lb2.Text = "RFC";
            lb3.Text = "Dirección";
            lb4.Text = "Teléfono";
            lb5.Text = "Número de Cuenta";

            lb8.Text = "Id. del Cliente";

            lb6.Visible = false;
            lb7.Visible = false;


            tbx1.Visible = Enabled;
            tbx2.Visible = Enabled;
            tbx3.Visible = Enabled;
            tbx4.Visible = Enabled;
            tbx5.Visible = Enabled;

            tbx6.Visible = false;
            tbx7.Visible = false;

            LimpiarCampos(new TextBox[] { tbx1, tbx2, tbx3, tbx4, tbx5, tbx6, tbx7, tbx8 });

            GridView1.DataSource = null;




        }
        private void BProductos_Click(object sender, EventArgs e) // menu productos
        {
            seccionActiva = "Productos";

            label2.Visible = Enabled;
            label2.Text = "Productos";


            lb1.Visible = Enabled;
            lb2.Visible = Enabled;
            lb3.Visible = Enabled;
            lb4.Visible = Enabled;
            lb5.Visible = Enabled;
            lb6.Visible = Enabled;
            lb7.Visible = Enabled;
            lb8.Visible = Enabled;

            lb1.Text = "Nombre";
            lb2.Text = "Descripción";
            lb3.Text = "T. de Unidad";
            lb4.Text = "Modelo";
            lb5.Text = "Talla";
            lb6.Text = "Color";
            lb7.Text = "Precio";
            lb8.Text = "Id. del Producto";

            tbx1 .Visible = Enabled;
            tbx2.Visible = Enabled;
            tbx3 .Visible = Enabled;
            tbx4.Visible = Enabled;
            tbx5.Visible = Enabled;
            tbx6.Visible = Enabled;
            tbx7 .Visible = Enabled;

            LimpiarCampos(new TextBox[] { tbx1, tbx2, tbx3, tbx4, tbx5, tbx6, tbx7, tbx8 });

            GridView1.DataSource = null;

        }

        private void button3_Click(object sender, EventArgs e) //menu ventas
        {
            seccionActiva = "Ventas";

            CampoBusqueda();


            label2.Visible = true;
            label2.Text = "Ventas";

            lb1.Visible = true;
            lb2.Visible = true;
            lb3.Visible = true;
            lb4.Visible = true;
            lb5.Visible = true;
            lb6.Visible = false;
            lb7.Visible = false;
            lb8.Visible = true;

            lb1.Text = "Nombre del Producto";
            lb2.Text = "Nombre del Cliente";
            lb3.Text = "Fecha de la venta";
            lb4.Text = "Cantidad";
            lb5.Text = "Total";

            lb8.Text = "Id. de la Venta";

            tbx1.Visible = true;
            tbx2.Visible = true;
            tbx3.Visible = Enabled;
            tbx4.Visible = true;
            tbx5.Visible = Enabled;
            tbx6.Visible = false;
            tbx7.Visible = false;

            LimpiarCampos(new TextBox[] { tbx1, tbx2, tbx3, tbx4, tbx5, tbx6, tbx7, tbx8 });


            GridView1.DataSource = null;
        }

        private void CampoBusqueda()
        {
            
        }

        private void button4_Click(object sender, EventArgs e) // Botón para registrar
        {
            if (seccionActiva == "Clientes")
            {
                RegistrarCliente(); 
            }
            else if (seccionActiva == "Productos")
            {
                RegistrarProducto(); 
            }
            else if (seccionActiva == "Ventas")
            {
                RegistrarVenta();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sección válida antes de registrar.");
            }
        }
   
        private void bBorrar_Click(object sender, EventArgs e) //boton para borrar dato
        {
            if (seccionActiva == "Clientes")
            {
                EliminarCliente();
            }
            else if (seccionActiva == "Productos")
            {
                EliminarProducto();
            }
            else if (seccionActiva == "Ventas")
            {
                EliminarVenta();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sección válida antes de registrar.");
            }


        }

        private void bMostrar_Click(object sender, EventArgs e) // Boton para Mostrar Tabla datos
        {
            if (seccionActiva == "Clientes")
            {
                MostrarCliente();
             }
            else if (seccionActiva == "Productos")
            {
                MostrarProducto(); 
            }
            else if (seccionActiva == "Ventas")
            {
                MostrarVenta(); 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sección válida antes de Buscar.");
            }
        } 

        private void bBuscar_Click(object sender, EventArgs e) // Boton para buscar
        {
            if (seccionActiva == "Clientes")
            {
                BuscarCliente(); 
            }
            else if (seccionActiva == "Productos")
            {
                BuscarProducto(); 
            }
            else if (seccionActiva == "Ventas")
            {
                BuscarVenta(); 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sección válida antes de Buscar.");
            }
        }

        private void bEditar_Click(object sender, EventArgs e) //boton para editar clientes
        {
            if (seccionActiva == "Clientes")
            {
                EditarCliente();
            }
            else if (seccionActiva == "Productos")
            {
                EditarProducto();
            }
            else if (seccionActiva == "Ventas")
            {
                EditarVenta();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sección válida antes de Buscar.");
            }
        }

        

        //funciones para registrar
        private void RegistrarCliente() //registrar cliente
        {
            if (
               string.IsNullOrWhiteSpace(tbx2.Text) ||
               string.IsNullOrWhiteSpace(tbx1.Text) ||
               string.IsNullOrWhiteSpace(tbx3.Text) ||
               string.IsNullOrWhiteSpace(tbx4.Text) ||
               string.IsNullOrWhiteSpace(tbx5.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar el cliente.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO Clientes (RFC, Nombre, Dirección, Teléfono, No_Cuenta) VALUES (@RFC, @Nombre, @Direccion, @Telefono, @NoCuenta)", conn);
                    comando.Parameters.AddWithValue("@RFC", tbx2.Text);
                    comando.Parameters.AddWithValue("@Nombre", tbx1.Text);
                    comando.Parameters.AddWithValue("@Direccion", tbx3.Text);
                    comando.Parameters.AddWithValue("@Telefono", tbx4.Text);
                    comando.Parameters.AddWithValue("@NoCuenta", tbx5.Text);

                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente guardado");


                        LimpiarCampos(new TextBox[] { tbx1, tbx2, tbx3, tbx4, tbx5, tbx6, tbx7, tbx8 });

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el cliente");
                    }
                }
            }
            catch (Exception ex)
            {
                label3.Visible = true;
                label3.Text = "No se pudo guardar: " + ex.Message;
            }
        }
        private void RegistrarVenta() //registrar venta
        {
            if (
               string.IsNullOrWhiteSpace(tbx2.Text) ||
               string.IsNullOrWhiteSpace(tbx1.Text) ||
               string.IsNullOrWhiteSpace(tbx3.Text) ||
               string.IsNullOrWhiteSpace(tbx4.Text) ||
               string.IsNullOrWhiteSpace(tbx5.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar el cliente.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();

                    MySqlCommand comando = new MySqlCommand("INSERT INTO Ventas (idProducto, idCliente, FechaVenta, Cantidad, Total) VALUES (@idProducto, @idCliente, @FechaVenta, @Cantidad, @Total)", conn);

                    // Asignar parámetros para la consulta de venta
                    comando.Parameters.AddWithValue("@idCliente", tbx1.Text);
                    comando.Parameters.AddWithValue("@idProducto", tbx2.Text);
                    comando.Parameters.AddWithValue("@FechaVenta", DateTime.Parse(tbx3.Text));
                    comando.Parameters.AddWithValue("@Cantidad", int.Parse(tbx4.Text));
                    comando.Parameters.AddWithValue("@Total", decimal.Parse(tbx5.Text));


                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Venta guardada");


                        LimpiarCampos(new TextBox[] { tbx1, tbx2, tbx3, tbx4, tbx5, tbx6, tbx7, tbx8 });

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la venta");
                    }
                }
            }
            catch (Exception ex)
            {
                label3.Visible = true;
                label3.Text = "No se pudo guardar: " + ex.Message;
            }


        }

        private void RegistrarProducto() //registrar producto
        {
            if (
                string.IsNullOrWhiteSpace(tbx1.Text) ||
                string.IsNullOrWhiteSpace(tbx2.Text) ||
                string.IsNullOrWhiteSpace(tbx3.Text) ||
                string.IsNullOrWhiteSpace(tbx4.Text) ||
                string.IsNullOrWhiteSpace(tbx5.Text) ||
                string.IsNullOrWhiteSpace(tbx6.Text) ||
                string.IsNullOrWhiteSpace(tbx7.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO Productos (Articulo, Descripcion, Unidad, Modelo, Talla, Color, Precio) VALUES (@Articulo, @Descripcion, @Unidad, @Modelo, @Talla,@Color,@Precio)", conn);
                    comando.Parameters.AddWithValue("@Articulo", tbx1.Text);
                    comando.Parameters.AddWithValue("@Descripcion", tbx2.Text);
                    comando.Parameters.AddWithValue("@Unidad", tbx3.Text);
                    comando.Parameters.AddWithValue("@Modelo", tbx4.Text);
                    comando.Parameters.AddWithValue("@Talla", tbx5.Text);
                    comando.Parameters.AddWithValue("@Color", tbx6.Text);
                    comando.Parameters.AddWithValue("@Precio", tbx7.Text);

                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto guardado");


                        LimpiarCampos(new TextBox[] { tbx1, tbx2, tbx3, tbx4, tbx5, tbx6, tbx7, tbx8 });

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el Prodcuto");
                    }
                }
            }
            catch (Exception ex)
            {
                label3.Visible = true;
                label3.Text = "Error" + ex.Message;
            }
        }

        //funciones para buscar
        private void BuscarCliente()  //buscar cliente
        {
            Vacio();
            

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    MySqlCommand comando = new MySqlCommand("SELECT RFC, Nombre, Direccion, Telefono, No_Cuenta FROM Clientes WHERE IdCliente = @IdCliente", conn);
                    comando.Parameters.AddWithValue("@IdCliente", tbx8.Text);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bEditar.Enabled = true;
                            bBorrar.Enabled = true;

                            // Si se encuentra el cliente, llenar los TextBox
                            tbx2.Text = reader["RFC"].ToString();
                            tbx1.Text = reader["Nombre"].ToString();
                            tbx3.Text = reader["Dirección"].ToString();
                            tbx4.Text = reader["Teléfono"].ToString();
                            tbx5.Text = reader["No_Cuenta"].ToString();

                            // Crear un DataTable para mostrar en el DataGridView
                            DataTable dt = new DataTable();
                            dt.Columns.Add("RFC");
                            dt.Columns.Add("Nombre");
                            dt.Columns.Add("Dirección");
                            dt.Columns.Add("Teléfono");
                            dt.Columns.Add("No_Cuenta");

                            // Agregar la fila con los datos del cliente
                            DataRow row = dt.NewRow();
                            row["RFC"] = reader["RFC"];
                            row["Nombre"] = reader["Nombre"];
                            row["Dirección"] = reader["Dirección"];
                            row["Teléfono"] = reader["Teléfono"];
                            row["No_Cuenta"] = reader["No_Cuenta"];
                            dt.Rows.Add(row);

                            // Asignar el DataTable al DataGridView
                            GridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un cliente con ese ID.");
                            // Limpiar el DataGridView si no se encuentra el cliente
                            GridView1.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message);
            }
        }

        private void BuscarVenta() //buscar venta
        {
            Vacio();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    MySqlCommand comando = new MySqlCommand("SELECT idProducto, idCliente, FechaVenta, Cantidad, Total FROM Ventas WHERE IdVenta = @IdVenta", conn);
                    comando.Parameters.AddWithValue("@IdVenta", tbx8.Text);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Si se encuentra la venta, llenar los TextBox
                            tbx2.Text = reader["idProducto"].ToString();
                            tbx1.Text = reader["idCliente"].ToString();
                            tbx3.Text = reader["FechaVenta"].ToString();
                            tbx4.Text = reader["Cantidad"].ToString();
                            tbx5.Text = reader["Total"].ToString();

                            // Crear un DataTable para mostrar en el DataGridView
                            DataTable dt = new DataTable();
                            dt.Columns.Add("idProducto");
                            dt.Columns.Add("idCliente");
                            dt.Columns.Add("FechaVenta");
                            dt.Columns.Add("Cantidad");
                            dt.Columns.Add("Total");

                            // Agregar la fila con los datos de la venta
                            DataRow row = dt.NewRow();
                            row["idProducto"] = reader["idProducto"];
                            row["idCliente"] = reader["idCliente"];
                            row["FechaVenta"] = reader["FechaVenta"];
                            row["Cantidad"] = reader["Cantidad"];
                            row["Total"] = reader["Total"];
                            dt.Rows.Add(row);

                            // Asignar el DataTable al DataGridView
                            GridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró una venta con ese ID.");
                            // Limpiar el DataGridView si no se encuentra la venta
                            GridView1.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la venta: " + ex.Message);
            }

        }

        private void BuscarProducto()  //buscar producto
        {
            Vacio();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    MySqlCommand comando = new MySqlCommand("SELECT Articulo, Descripcion, Unidad, Modelo, Talla, Color, Precio FROM Productos WHERE idProducto = @idProducto", conn);
                    comando.Parameters.AddWithValue("@idProducto", tbx8.Text);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Si se encuentra el cliente, llenar los TextBox
                            tbx1.Text = reader["Articulo"].ToString();
                            tbx2.Text = reader["Descripcion"].ToString();
                            tbx3.Text = reader["Unidad"].ToString();
                            tbx4.Text = reader["Modelo"].ToString();
                            tbx5.Text = reader["Talla"].ToString();
                            tbx6.Text = reader["Color"].ToString();
                            tbx7.Text = reader["Precio"].ToString();
                            

                            // Crear un DataTable para mostrar en el DataGridView
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Articulo");
                            dt.Columns.Add("Descripcion");
                            dt.Columns.Add("Unidad");
                            dt.Columns.Add("Modelo");
                            dt.Columns.Add("Talla");
                            dt.Columns.Add("Color");
                            dt.Columns.Add("Precio");

                            // Agregar la fila con los datos del producto
                            DataRow row = dt.NewRow();
                            row["Articulo"] = reader["Articulo"];
                            row["Descripcion"] = reader["Descripcion"];
                            row["Unidad"] = reader["Unidad"];
                            row["Modelo"] = reader["Modelo"];
                            row["Talla"] = reader["Talla"];
                            row["Color"] = reader["Color"];
                            row["Precio"] = reader["Precio"];
                            dt.Rows.Add(row);

                            // Asignar el DataTable al DataGridView
                            GridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un producto con ese ID.");
                            // Limpiar el DataGridView si no se encuentra el producto
                            GridView1.DataSource = null;
                        }
                    }

                }
            }
            catch (Exception ex){
                MessageBox.Show("Error al buscar el Producto: " + ex.Message);
            }

        }

        //funciones para eliminar

        private void EliminarCliente()
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Si el usuario selecciona "Sí", se procede con la eliminación
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                    {
                        conn.Open();
                        MySqlCommand comando = new MySqlCommand("DELETE FROM Clientes WHERE IdCliente = @IdCliente", conn);
                        comando.Parameters.AddWithValue("@IdCliente", tbx8.Text);  // El ID que quieres eliminar

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.");
                            LimpiarCampos(new TextBox[] { tbx1, tbx2, tbx3, tbx4, tbx5, tbx6, tbx7, tbx8 });

                            bEditar.Enabled = false;
                            bBorrar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
            }
            else
            {
                // Si el usuario selecciona "No", no se realiza ninguna acción
                MessageBox.Show("Eliminación cancelada.");
            }

        }

        private void EliminarVenta()
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Si el usuario selecciona "Sí", se procede con la eliminación
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                    {
                        conn.Open();
                        MySqlCommand comando = new MySqlCommand("DELETE FROM Ventas WHERE IdVenta = @IdVenta", conn);
                        comando.Parameters.AddWithValue("@IdVenta", tbx8.Text);  // ID de la venta a eliminar

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Venta eliminada correctamente.");
                            LimpiarCampos(new TextBox[] { tbx2, tbx1, tbx3, tbx4, tbx5});

                            bEditar.Enabled = false;
                            bBorrar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la venta.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la venta: " + ex.Message);
                }
            }
            else
            {
                // Si el usuario selecciona "No", no se realiza ninguna acción
                MessageBox.Show("Eliminación cancelada.");
            }

        }

        private void EliminarProducto()
        {
            throw new NotImplementedException();
        }
        // funciones editar

        private void EditarCliente()
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas editar este cliente?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Si el usuario selecciona "Sí", se procede con la edición
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                    {
                        conn.Open();
                        MySqlCommand comando = new MySqlCommand("UPDATE Clientes SET RFC = @RFC, Nombre = @Nombre, Dirección = @Dirección, Teléfono = @Teléfono, No_Cuenta = @No_Cuenta WHERE IdCliente = @IdCliente", conn);

                        // Asignar los valores de los TextBox a los parámetros de la consulta SQL
                        comando.Parameters.AddWithValue("@RFC", tbx2.Text);
                        comando.Parameters.AddWithValue("@Nombre", tbx1.Text);
                        comando.Parameters.AddWithValue("@Dirección", tbx3.Text);
                        comando.Parameters.AddWithValue("@Teléfono", tbx4.Text);
                        comando.Parameters.AddWithValue("@No_Cuenta", tbx5.Text);
                        comando.Parameters.AddWithValue("@IdCliente", tbx8.Text);  // IdCliente que se utiliza para buscar

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente actualizado correctamente.");
                            LimpiarCampos(new TextBox[] { tbx1, tbx2, tbx3, tbx4, tbx5, tbx6, tbx7, tbx8 });

                            bEditar.Enabled = false;
                            bBorrar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el cliente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
            }
            else
            {
                // Si el usuario selecciona "No", no se realiza ninguna acción
                MessageBox.Show("Edición cancelada.");
            }
        }

        private void EditarVenta()
        {
            throw new NotImplementedException();
        }

        private void EditarProducto()
        {
            throw new NotImplementedException();
        }


        //funciones

        private void LimpiarCampos(TextBox[] textboxes) //funcion para limpiar textbox
        {
            foreach (var textbox in textboxes)
            {
                textbox.Text = string.Empty;
            }
        }

        private void Vacio()
        {
            if (string.IsNullOrWhiteSpace(tbx8.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }
        }
        //funciones para mostrar
        private void MostrarCliente()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                DataSet ds = new DataSet("Clientes");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Clientes", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
                GridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void MostrarVenta()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                DataSet ds = new DataSet("Ventas");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Ventas", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
                GridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void MostrarProducto()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                DataSet ds = new DataSet("Productos");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Productos", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                conn.Open();
                adapter.Fill(ds);
                conn.Close();
                GridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        











        //fucniones creadas por error que no puedo eliminar
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void lb5_Click(object sender, EventArgs e)
        {

        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbx7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb7_Click(object sender, EventArgs e)
        {

        }

        private void tbx6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbx5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb4_Click(object sender, EventArgs e)
        {

        }

        private void lb3_Click(object sender, EventArgs e)
        {

        }

        private void lb2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
