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
    public partial class fmConsultar : Form
    {
        OleDbCommand comando; // Variable global con definición de objeto Command
        public fmConsultar()
        {
            InitializeComponent();
        }

        void asignaListview() // Función para lectura de objeto Reader devuelto
        { // por sentencia SQL de Command
            OleDbDataReader lector = comando.ExecuteReader();// Ejecutamos SQL que
                                                             // devuelve Reader
            lvConsultas.Items.Clear();
            while (lector.Read()) // Leemos mientras no es fin
            {
                ListViewItem elementos = new // Se crea Item listview con columna 1
                ListViewItem(lector.GetInt32(0).ToString());
                elementos.SubItems.Add(lector.GetString(1)); // Métodos para obtener
                elementos.SubItems.Add(lector.GetString(2)); // datos y se
                elementos.SubItems.Add(lector.GetString(3)); // añaden a Subitem’s
                elementos.SubItems.Add(lector.GetInt32(4).ToString());
                // Añadimos columna 6 calculamos valor y lo asignamos
                elementos.SubItems.Add(lector.GetInt32(5).ToString());
                decimal pib = Convert.ToDecimal(lector.GetInt32(5)) * 1000000;
                decimal renta = pib / lector.GetInt32(4);
                elementos.SubItems.Add(renta.ToString("######"));
                lvConsultas.Items.Add(elementos); // Añadimos fila a ListView
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string sentenciasql = "SELECT * FROM paises WHERE " // SQL con parámetros
                + " continente=@Europa or continente=@Asia or continente=@Africa "
                + "or continente=@America or continente=@Oceania ORDER BY continente";
            // En este caso usamos objeto command y conexión definida en form principal
            comando = new OleDbCommand(sentenciasql, fmPrincipal.conexion);
            // Asignación valor a parámetros a través de operador ternario
            comando.Parameters.AddWithValue("@Africa", ckAfrica.Checked ? "Africa" : "");
            comando.Parameters.AddWithValue("@Asia", ckAsia.Checked ? "Asia" : "");
            comando.Parameters.AddWithValue("@America", ckAmerica.Checked ? "América" : "");
            comando.Parameters.AddWithValue("@Europa", ckEuropa.Checked ? "Europa" : "");
            comando.Parameters.AddWithValue("@Oceania", ckOceania.Checked ? "Oceanía" : "");
            asignaListview();
        }

        private void btPais_Click(object sender, EventArgs e)
        {
            foreach (CheckBox elchec in gbContinentes.Controls)
            { // Desmarcamos todos los CheckBox del GroupBox gbContinentes
                elchec.Checked = false;
            }
            if (tbPais.Text == "") // Si está vacío no mostramos nada
            {
                lvConsultas.Items.Clear();
                return;
            }
            // Con like podemos filtrar nombres parciales, tecleamos menos
            string sentenciasql =
            "SELECT * FROM paises Where nombre like '%' + @nombre+ '%'";
            // Constructor de command definido de forma global
            comando = new OleDbCommand(sentenciasql, fmPrincipal.conexion);
            comando.Parameters.AddWithValue("@nombre", tbPais.Text);
            asignaListview(); // para ejecutar el reader
        }

        private void tbPais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btPais_Click(sender, e);
            }
        }
    }
}
