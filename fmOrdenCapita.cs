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
    public partial class fmOrdenCapita : Form
    {
        public fmOrdenCapita()
        {
            InitializeComponent();
        }

        private void fmOrdenCapita_Load(object sender, EventArgs e)
        {
            // Sentencia SQL con cálculo sobre variable rentacapita,
            // con condición pib>0 y orden descendente
            string consulta = "select nombre, pib * 1000000 / poblacion "
            + "as rentacapita from paises where pib > 0 order by 2 desc";
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, //Usamos Data….
            fmPrincipal.conexion);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            lvRentaCapita.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            { // Extraemos datos de la tabla incluida variable y mostramos en Listview
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem((i + 1).ToString());
                elementos.SubItems.Add(filas["nombre"].ToString());
                double valor = (double)filas["rentacapita"];
                elementos.SubItems.Add(valor.ToString("#,###,##0.00"));
                lvRentaCapita.Items.Add(elementos);
            }
        }
    }
}
