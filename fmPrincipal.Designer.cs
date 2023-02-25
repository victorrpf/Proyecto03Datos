namespace Proyecto03Datos
{
    partial class fmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAcercaDe = new System.Windows.Forms.Button();
            this.btRentaCapita = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAnadir = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckDescendente = new System.Windows.Forms.CheckBox();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbCapital = new System.Windows.Forms.RadioButton();
            this.rbPIB = new System.Windows.Forms.RadioButton();
            this.rbPoblacion = new System.Windows.Forms.RadioButton();
            this.rbContinente = new System.Windows.Forms.RadioButton();
            this.rbPais = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDatos = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContinente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPib = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRentaCapita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAcercaDe);
            this.panel1.Controls.Add(this.btRentaCapita);
            this.panel1.Controls.Add(this.btBorrar);
            this.panel1.Controls.Add(this.btConsultar);
            this.panel1.Controls.Add(this.btModificar);
            this.panel1.Controls.Add(this.btAnadir);
            this.panel1.Controls.Add(this.btMostrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 80);
            this.panel1.TabIndex = 0;
            // 
            // btAcercaDe
            // 
            this.btAcercaDe.Location = new System.Drawing.Point(786, 30);
            this.btAcercaDe.Name = "btAcercaDe";
            this.btAcercaDe.Size = new System.Drawing.Size(121, 31);
            this.btAcercaDe.TabIndex = 6;
            this.btAcercaDe.Text = "Acerca de";
            this.btAcercaDe.UseVisualStyleBackColor = true;
            this.btAcercaDe.Click += new System.EventHandler(this.btAcercaDe_Click);
            // 
            // btRentaCapita
            // 
            this.btRentaCapita.Location = new System.Drawing.Point(504, 30);
            this.btRentaCapita.Name = "btRentaCapita";
            this.btRentaCapita.Size = new System.Drawing.Size(181, 31);
            this.btRentaCapita.TabIndex = 5;
            this.btRentaCapita.Text = "Calcula Renta/Capita";
            this.btRentaCapita.UseVisualStyleBackColor = true;
            this.btRentaCapita.Click += new System.EventHandler(this.btRentaCapita_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(406, 30);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 31);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(307, 30);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 31);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(207, 30);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 31);
            this.btModificar.TabIndex = 2;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btAnadir
            // 
            this.btAnadir.Location = new System.Drawing.Point(109, 30);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(75, 31);
            this.btAnadir.TabIndex = 1;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = true;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(13, 30);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 31);
            this.btMostrar.TabIndex = 0;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckDescendente);
            this.panel2.Controls.Add(this.rbID);
            this.panel2.Controls.Add(this.rbCapital);
            this.panel2.Controls.Add(this.rbPIB);
            this.panel2.Controls.Add(this.rbPoblacion);
            this.panel2.Controls.Add(this.rbContinente);
            this.panel2.Controls.Add(this.rbPais);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 100);
            this.panel2.TabIndex = 1;
            // 
            // ckDescendente
            // 
            this.ckDescendente.AutoSize = true;
            this.ckDescendente.Location = new System.Drawing.Point(682, 44);
            this.ckDescendente.Name = "ckDescendente";
            this.ckDescendente.Size = new System.Drawing.Size(110, 20);
            this.ckDescendente.TabIndex = 7;
            this.ckDescendente.Text = "Descendente";
            this.ckDescendente.UseVisualStyleBackColor = true;
            this.ckDescendente.CheckedChanged += new System.EventHandler(this.radiobuttons_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Checked = true;
            this.rbID.Location = new System.Drawing.Point(504, 59);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(101, 20);
            this.rbID.TabIndex = 6;
            this.rbID.TabStop = true;
            this.rbID.Text = "Identificador";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.radiobuttons_CheckedChanged);
            // 
            // rbCapital
            // 
            this.rbCapital.AutoSize = true;
            this.rbCapital.Location = new System.Drawing.Point(504, 19);
            this.rbCapital.Name = "rbCapital";
            this.rbCapital.Size = new System.Drawing.Size(70, 20);
            this.rbCapital.TabIndex = 5;
            this.rbCapital.Text = "Capital";
            this.rbCapital.UseVisualStyleBackColor = true;
            this.rbCapital.CheckedChanged += new System.EventHandler(this.radiobuttons_CheckedChanged);
            // 
            // rbPIB
            // 
            this.rbPIB.AutoSize = true;
            this.rbPIB.Location = new System.Drawing.Point(360, 59);
            this.rbPIB.Name = "rbPIB";
            this.rbPIB.Size = new System.Drawing.Size(49, 20);
            this.rbPIB.TabIndex = 4;
            this.rbPIB.Text = "PIB";
            this.rbPIB.UseVisualStyleBackColor = true;
            this.rbPIB.CheckedChanged += new System.EventHandler(this.radiobuttons_CheckedChanged);
            // 
            // rbPoblacion
            // 
            this.rbPoblacion.AutoSize = true;
            this.rbPoblacion.Location = new System.Drawing.Point(360, 19);
            this.rbPoblacion.Name = "rbPoblacion";
            this.rbPoblacion.Size = new System.Drawing.Size(89, 20);
            this.rbPoblacion.TabIndex = 3;
            this.rbPoblacion.Text = "Poblacion";
            this.rbPoblacion.UseVisualStyleBackColor = true;
            this.rbPoblacion.CheckedChanged += new System.EventHandler(this.radiobuttons_CheckedChanged);
            // 
            // rbContinente
            // 
            this.rbContinente.AutoSize = true;
            this.rbContinente.Location = new System.Drawing.Point(207, 59);
            this.rbContinente.Name = "rbContinente";
            this.rbContinente.Size = new System.Drawing.Size(91, 20);
            this.rbContinente.TabIndex = 2;
            this.rbContinente.Text = "Continente";
            this.rbContinente.UseVisualStyleBackColor = true;
            this.rbContinente.CheckedChanged += new System.EventHandler(this.radiobuttons_CheckedChanged);
            // 
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.Location = new System.Drawing.Point(207, 19);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(55, 20);
            this.rbPais.TabIndex = 1;
            this.rbPais.Text = "Pais";
            this.rbPais.UseVisualStyleBackColor = true;
            this.rbPais.CheckedChanged += new System.EventHandler(this.radiobuttons_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenar por:";
            // 
            // lvDatos
            // 
            this.lvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNombre,
            this.chCapital,
            this.chContinente,
            this.chPoblacion,
            this.chPib,
            this.chRentaCapita});
            this.lvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDatos.HideSelection = false;
            this.lvDatos.Location = new System.Drawing.Point(0, 80);
            this.lvDatos.MultiSelect = false;
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(919, 356);
            this.lvDatos.TabIndex = 2;
            this.lvDatos.UseCompatibleStateImageBehavior = false;
            this.lvDatos.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 40;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 100;
            // 
            // chCapital
            // 
            this.chCapital.Text = "Capital";
            this.chCapital.Width = 80;
            // 
            // chContinente
            // 
            this.chContinente.Text = "Continente";
            this.chContinente.Width = 100;
            // 
            // chPoblacion
            // 
            this.chPoblacion.Text = "Poblacion";
            this.chPoblacion.Width = 100;
            // 
            // chPib
            // 
            this.chPib.Text = "PIB";
            this.chPib.Width = 70;
            // 
            // chRentaCapita
            // 
            this.chRentaCapita.Text = "Renta/Cápita";
            this.chRentaCapita.Width = 100;
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 536);
            this.Controls.Add(this.lvDatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmPrincipal";
            this.Text = "Datos Países";
            this.Load += new System.EventHandler(this.fmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvDatos;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chCapital;
        private System.Windows.Forms.ColumnHeader chContinente;
        private System.Windows.Forms.ColumnHeader chPoblacion;
        private System.Windows.Forms.ColumnHeader chPib;
        private System.Windows.Forms.ColumnHeader chRentaCapita;
        private System.Windows.Forms.Button btAcercaDe;
        private System.Windows.Forms.Button btRentaCapita;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbCapital;
        private System.Windows.Forms.RadioButton rbPIB;
        private System.Windows.Forms.RadioButton rbPoblacion;
        private System.Windows.Forms.RadioButton rbContinente;
        private System.Windows.Forms.RadioButton rbPais;
        private System.Windows.Forms.CheckBox ckDescendente;
    }
}

