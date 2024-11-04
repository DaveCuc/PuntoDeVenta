﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PuntoDeVenta
{
    public partial class Window : Form
    {
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

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

            lb1.Text = "Id. Producto";
            lb2.Text = "Id. Cliente";
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

        }

        private void button1_Click(object sender, EventArgs e) //prueba de conexion
        {
            SqlConnection conn = new SqlConnection();
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

            GridView1.Visible = true;







            
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
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO Clientes (RFC, Nombre, Dirección, Teléfono, No_Cuenta) VALUES (@RFC, @Nombre, @Direccion, @Telefono, @NoCuenta)", conn);
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
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO Productos (Articulo, Descripcion, Unidad, Modelo, Talla, Color, Precio) VALUES (@Articulo, @Descripcion, @Unidad, @Modelo, @Talla,@Color,@Precio)", conn);
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
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand("SELECT RFC, Nombre, Dirección, Teléfono, No_Cuenta FROM Clientes WHERE IdCliente = @IdCliente", conn);
                    comando.Parameters.AddWithValue("@IdCliente", tbx8.Text);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
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
            
        }

        private void BuscarProducto()  //buscar producto
        {
            Vacio();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand("SELECT Articulo, Descripcion, Unidad, Modelo, Talla, Color, Precio FROM Productos WHERE idProducto = @idProducto", conn);
                    comando.Parameters.AddWithValue("@idProducto", tbx8.Text);

                    using (SqlDataReader reader = comando.ExecuteReader())
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
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                DataSet ds = new DataSet("Clientes");
                SqlCommand comando = new SqlCommand("SELECT * FROM Clientes", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
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
            throw new NotImplementedException();
        }
        private void MostrarProducto()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                DataSet ds = new DataSet("Productos");
                SqlCommand comando = new SqlCommand("SELECT * FROM Productos", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
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