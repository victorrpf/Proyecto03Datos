using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto03Datos
{
    public partial class fmPrincipal : Form
    {
        public static OleDbConnection conexion;
        public fmActualizar VentanaActualizar = new fmActualizar();
        public fmPrincipal()
        {
            InitializeComponent();
        }

        private void fmPrincipal_Load(object sender, EventArgs e)
        {
            string conecta = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source =.\datos\bd_paises.accdb";
            conexion = new OleDbConnection(conecta); //Creamos objeto conexión
            
            try
            {
                conexion.Open(); //Abrimos conexión a BD
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM paises " +
                "ORDER by Id ", conexion);
            DataSet ds = new DataSet(); //Exclusivamente para el DataAdapter
            DataTable tabla = new DataTable();//Como no hay reader se necesita DataTable
            adaptador.Fill(ds);//Modifica los datos de DataSet de forma que coincidan
                               // con los del origen de datos
            tabla = ds.Tables[0]; //Extraemos la primera tabla del Dataset,solo hay una
            lvDatos.Items.Clear(); //Limpiamos el listview
            for (int i = 0; i < tabla.Rows.Count; i++) // Repite mientras hay filas
            {
                DataRow filas = tabla.Rows[i]; //Asignamos filas de la tabla datarow
                ListViewItem elementos = new ListViewItem(filas["id"].ToString());
                //Extrae columnas del datarow y las asigna a ListViewItem, es la
                // clase de filas de listview con la primera columna de la fila
                elementos.SubItems.Add(filas["nombre"].ToString());//El resto de columnas
                                                                   // son tratadas como subitems
                elementos.SubItems.Add(filas["capital"].ToString());
                elementos.SubItems.Add(filas["continente"].ToString());
                elementos.SubItems.Add(filas["poblacion"].ToString());
                elementos.SubItems.Add(filas["pib"].ToString());
                elementos.SubItems.Add("0"); //Campo calculado no pertenece a la tabla
                lvDatos.Items.Add(elementos); //Añadimos ítem fila al listview
            }
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            //Seleccionamos primera fila con orden inverso, por tanto última de la tabla
            string numFilas = "SELECT TOP 1 ID FROM paises ORDER BY ID DESC ";
            OleDbCommand comando1 = new OleDbCommand(numFilas, conexion);//Usamos Command
            int numfil = (int)comando1.ExecuteScalar();//Devuelve primera columna fila 1
            VentanaActualizar.tbId.Text = Convert.ToString(numfil + 1);//Nuevo id último+1
            VentanaActualizar.tbCapital.Text = ""; //Vaciamos Textbox otro form
            VentanaActualizar.cbContinente.Text = "";
            VentanaActualizar.tbPIB.Text = "0";
            VentanaActualizar.tbPoblacion.Text = "0";
            VentanaActualizar.tbNombre.Text = "";
            VentanaActualizar.ponercontinentes();
            if (VentanaActualizar.ShowDialog() == DialogResult.OK)
            { //Si pulsa ok ejecutamos consulta de inserción nuevo registro
                string insertar = "INSERT INTO " +
                    "paises(id, nombre, capital, continente, poblacion, pib) ";
            insertar += "VALUES ('" + VentanaActualizar.tbId.Text + "','"
            + VentanaActualizar.tbNombre.Text + "','"
            + VentanaActualizar.tbCapital.Text + "','"
            + VentanaActualizar.cbContinente.Text + "','"
            + VentanaActualizar.tbPoblacion.Text + "','"
            + VentanaActualizar.tbPIB.Text + "')";
                OleDbCommand comando = new OleDbCommand(insertar, conexion);//Creamos
                                                                            //objeto command
                try
                {
                    comando.ExecuteNonQuery();//Ejecutamos con método sentencias no select
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Datos Guardados correctamente");
                btMostrar.PerformClick();
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (lvDatos.SelectedIndices.Count > 0) //solo uno porque multiselect=false
            { //Recogemos en clase collection la fila seleccionada
                ListView.SelectedListViewItemCollection seleccionado =
                lvDatos.SelectedItems;
                //ListViewItem elemento=(ListViewItem)lvDatos.SelectedItems;//No se
                // puede asignar directamente porque no es posible la conversión
                foreach (ListViewItem elemento in seleccionado) //Hay que extraer de
                                                                // colección aunque solo sea uno
                {
                    int mid = Convert.ToInt32(elemento.SubItems[0].Text); //Asignamos a
                                                                          // variable la columna 1
                    string consulta = "select * from paises where Id = @mid; "; // SQL
                                                                                // sentencia con parámetro
                    OleDbCommand comando = new OleDbCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@mid", mid); //Asignamos valor a
                                                                  // parámetro
                    OleDbDataReader lector = comando.ExecuteReader(); //Se ejecuta
                                                                      // sentencia SQL y recoge objeto Reader
                    while (lector.Read()) //Desplaza al siguiente registro y devuelve
                                          // false si no hay más filas
                    { //Cargamos textbox del formulario actualizar para modificarlos
                        VentanaActualizar.ponercontinentes();// Ver en formulario
                        VentanaActualizar.tbId.Text =
                        Convert.ToString(lector.GetInt32(0));//Obtiene valor de columna
                        VentanaActualizar.tbNombre.Text = lector.GetString(1); // usamos
                                                                               // un método u otro según tipo de dato
                        VentanaActualizar.tbCapital.Text = lector.GetString(2);
                        VentanaActualizar.cbContinente.Text = lector.GetString(3);
                        VentanaActualizar.tbPoblacion.Text =
                        Convert.ToString(lector.GetInt32(4));
                        VentanaActualizar.tbPIB.Text =
                        Convert.ToString(lector.GetInt32(5));
                        if (VentanaActualizar.ShowDialog() == DialogResult.OK)
                        {
                            mid = Convert.ToInt32(VentanaActualizar.tbId.Text);
                            string modificar = "UPDATE paises " //Sentencia SQL de
                                                                // actualización con valores de text de otro form
                            + " SET id ='" + VentanaActualizar.tbId.Text
                            + "',nombre='" + VentanaActualizar.tbNombre.Text
                            + "',capital='" + VentanaActualizar.tbCapital.Text
                            + "',continente ='" + VentanaActualizar.cbContinente.Text
                            + "',poblacion='" + VentanaActualizar.tbPoblacion.Text
                            + "',pib='" + VentanaActualizar.tbPIB.Text + "' "
                            + "where Id = @mid; ";
                            OleDbCommand comando2 = new OleDbCommand(modificar, conexion);
                            comando2.Parameters.AddWithValue("@mid", mid);
                            try
                            {
                                comando2.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            MessageBox.Show("Datos Guardados correctamente");
                        }
                    }
                    btMostrar.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Elige un Pais");
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (lvDatos.SelectedIndices.Count > 0)
            { //Sobre fila seleccionada del ListView realizamos consulta Sql de borrado
                ListView.SelectedListViewItemCollection seleccionado =
                lvDatos.SelectedItems;
                foreach (ListViewItem elemento in seleccionado)
                { // Usamos celdas del Listview para pedir confirmación
                    DialogResult resulta = MessageBox.Show("Seguro que desea eliminar el " +
                        "pais " + elemento.SubItems[1].Text + " con ID: " +
                    elemento.SubItems[0].Text, "Atención, Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resulta == DialogResult.No)
                        break; //Cortamos el ciclo foreach aunque solo hay uno
                    string idborra = Convert.ToString(elemento.SubItems[0].Text);
                    //Columna 1 del seleccionado
                    string borra = "delete from paises where Id = @idborra"; //Senten.SQL
                    OleDbCommand comandoborra = new OleDbCommand(borra, conexion);
                    comandoborra.Parameters.AddWithValue("@idborra", idborra);//param.SQL
                    try
                    {
                        comandoborra.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                btMostrar.PerformClick();
            }
            else
            {
                MessageBox.Show("Elige un Pais");
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            fmConsultar fmConsult= new fmConsultar();
            fmConsult.ShowDialog();
        }

        private void btRentaCapita_Click(object sender, EventArgs e)
        {
            if (lvDatos.Items.Count > 0)
            {
                ListView.ListViewItemCollection filas = lvDatos.Items;
                foreach (ListViewItem elemento in filas)
                {
                    int mid = Convert.ToInt32(elemento.SubItems[0].Text);
                    string operacion = // SQl para operación de cálculo
                    "select pib * 1000000 / poblacion from paises where Id = @mid;";
                    OleDbCommand comando = new OleDbCommand(operacion, conexion);
                    comando.Parameters.AddWithValue("@mid", mid);
                    double rentacap = (double)comando.ExecuteScalar(); // Devuelve fila
                                                                       // y columna 1 que es el PIB por el select
                    elemento.SubItems[6].Text = rentacap.ToString("######");
                } // Asignamos valor a columna con máscara de formateo numérico
            }
            else
            {
                MessageBox.Show("no hay filas");
            }
        }

        private void radiobuttons_CheckedChanged(object sender, EventArgs e)
        {
            string sentenciasql = "SELECT * FROM paises ";
            if (rbPais.Checked) sentenciasql += "ORDER BY nombre";
            if (rbContinente.Checked) sentenciasql += "ORDER BY continente";
            if (rbPoblacion.Checked) sentenciasql += "ORDER BY poblacion";
            if (rbPIB.Checked) sentenciasql += "ORDER BY pib";
            if (rbID.Checked) sentenciasql += "ORDER BY id";
            if (rbCapital.Checked) sentenciasql += "ORDER BY capital";
            if (ckDescendente.Checked) sentenciasql += " DESC";
            OleDbDataAdapter adaptador = new OleDbDataAdapter(sentenciasql,
            conexion); // Usamos DataAdapter con DataSet y tabla
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            lvDatos.Items.Clear(); //Vaciamos ListView y volvemos a cargar según
                                   // nuevo criterio de clasificación indicado
            for (int i = 0; i < tabla.Rows.Count; i++) // En este caso nos
            { // movemos por la tabla no hay Reader
                DataRow filas = tabla.Rows[i]; // Cargamos ListView desde tabla
                ListViewItem elementos = new ListViewItem(filas["id"].ToString());
                elementos.SubItems.Add(filas["nombre"].ToString());
                elementos.SubItems.Add(filas["capital"].ToString());
                elementos.SubItems.Add(filas["continente"].ToString());
                elementos.SubItems.Add(filas["poblacion"].ToString());
                elementos.SubItems.Add(filas["pib"].ToString());
                // Para cálculos usamos celdas correspondientes en este caso
                decimal pib = Convert.ToDecimal(filas["pib"].ToString()) * 1000000;
                decimal renta = pib / Convert.ToInt64(filas["poblacion"].ToString());
                elementos.SubItems.Add(renta.ToString("######"));
                lvDatos.Items.Add(elementos); // Añadimos fila a fila
            }
        }

        private void btAcercaDe_Click(object sender, EventArgs e)
        {
            fmAcercade fmAcerca = new fmAcercade();
            fmAcerca.ShowDialog();
            fmAcerca.Dispose();
        }

        private void btOrdenCapita_Click(object sender, EventArgs e)
        {
            fmOrdenCapita fmOrden = new fmOrdenCapita();
            fmOrden.ShowDialog();
            fmOrden.Dispose();
        }
    }
}
