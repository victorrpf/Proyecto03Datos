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
    public partial class fmActualizar : Form
    {
        public fmActualizar()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "") //Convertimos este campo en obligatorio
            {
                MessageBox.Show("Falta nombre pais");
                tbNombre.Focus();
            }
            else
            {
                this.DialogResult= DialogResult.OK;
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tbPoblacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbPIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void ponercontinentes()
        { // Usamos distinct que elimina repeticiones de igual valor
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT DISTINCT " +
                "continente FROM paises", fmPrincipal.conexion);
            DataSet ds = new DataSet();// Usamos DataAdapter, dataSet y datatable
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            cbContinente.Items.Clear();// Vaciamos comboBox
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i]; // No es posible asignación directa al
                cbContinente.Items.Add(filas["continente"].ToString());// ítem comboBox
            }
            cbContinente.SelectedIndex = 0; // Seleccionamos primer continente
        }
    }
}
