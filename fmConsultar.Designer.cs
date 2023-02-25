namespace Proyecto03Datos
{
    partial class fmConsultar
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
            this.gbContinentes = new System.Windows.Forms.GroupBox();
            this.ckOceania = new System.Windows.Forms.CheckBox();
            this.ckAfrica = new System.Windows.Forms.CheckBox();
            this.ckAsia = new System.Windows.Forms.CheckBox();
            this.ckEuropa = new System.Windows.Forms.CheckBox();
            this.ckAmerica = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.btPais = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvConsultas = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Continente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Renta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbContinentes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContinentes
            // 
            this.gbContinentes.Controls.Add(this.ckOceania);
            this.gbContinentes.Controls.Add(this.ckAfrica);
            this.gbContinentes.Controls.Add(this.ckAsia);
            this.gbContinentes.Controls.Add(this.ckEuropa);
            this.gbContinentes.Controls.Add(this.ckAmerica);
            this.gbContinentes.Location = new System.Drawing.Point(47, 32);
            this.gbContinentes.Name = "gbContinentes";
            this.gbContinentes.Size = new System.Drawing.Size(200, 167);
            this.gbContinentes.TabIndex = 0;
            this.gbContinentes.TabStop = false;
            this.gbContinentes.Text = "Consulta por continente";
            // 
            // ckOceania
            // 
            this.ckOceania.AutoSize = true;
            this.ckOceania.Location = new System.Drawing.Point(19, 129);
            this.ckOceania.Name = "ckOceania";
            this.ckOceania.Size = new System.Drawing.Size(80, 20);
            this.ckOceania.TabIndex = 4;
            this.ckOceania.Text = "Oceanía";
            this.ckOceania.UseVisualStyleBackColor = true;
            this.ckOceania.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ckAfrica
            // 
            this.ckAfrica.AutoSize = true;
            this.ckAfrica.Location = new System.Drawing.Point(19, 102);
            this.ckAfrica.Name = "ckAfrica";
            this.ckAfrica.Size = new System.Drawing.Size(63, 20);
            this.ckAfrica.TabIndex = 3;
            this.ckAfrica.Text = "África";
            this.ckAfrica.UseVisualStyleBackColor = true;
            this.ckAfrica.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ckAsia
            // 
            this.ckAsia.AutoSize = true;
            this.ckAsia.Location = new System.Drawing.Point(19, 75);
            this.ckAsia.Name = "ckAsia";
            this.ckAsia.Size = new System.Drawing.Size(56, 20);
            this.ckAsia.TabIndex = 2;
            this.ckAsia.Text = "Asia";
            this.ckAsia.UseVisualStyleBackColor = true;
            this.ckAsia.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ckEuropa
            // 
            this.ckEuropa.AutoSize = true;
            this.ckEuropa.Location = new System.Drawing.Point(19, 48);
            this.ckEuropa.Name = "ckEuropa";
            this.ckEuropa.Size = new System.Drawing.Size(73, 20);
            this.ckEuropa.TabIndex = 1;
            this.ckEuropa.Text = "Europa";
            this.ckEuropa.UseVisualStyleBackColor = true;
            this.ckEuropa.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ckAmerica
            // 
            this.ckAmerica.AutoSize = true;
            this.ckAmerica.Location = new System.Drawing.Point(19, 21);
            this.ckAmerica.Name = "ckAmerica";
            this.ckAmerica.Size = new System.Drawing.Size(79, 20);
            this.ckAmerica.TabIndex = 0;
            this.ckAmerica.Text = "America";
            this.ckAmerica.UseVisualStyleBackColor = true;
            this.ckAmerica.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta por País";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(417, 101);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(174, 22);
            this.tbPais.TabIndex = 2;
            this.tbPais.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPais_KeyDown);
            // 
            // btPais
            // 
            this.btPais.Location = new System.Drawing.Point(464, 140);
            this.btPais.Name = "btPais";
            this.btPais.Size = new System.Drawing.Size(75, 32);
            this.btPais.TabIndex = 3;
            this.btPais.Text = "Ver";
            this.btPais.UseVisualStyleBackColor = true;
            this.btPais.Click += new System.EventHandler(this.btPais_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbContinentes);
            this.panel1.Controls.Add(this.btPais);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPais);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 225);
            this.panel1.TabIndex = 4;
            // 
            // lvConsultas
            // 
            this.lvConsultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre,
            this.Capital,
            this.Continente,
            this.Poblacion,
            this.PIB,
            this.Renta});
            this.lvConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConsultas.HideSelection = false;
            this.lvConsultas.Location = new System.Drawing.Point(0, 225);
            this.lvConsultas.Name = "lvConsultas";
            this.lvConsultas.Size = new System.Drawing.Size(800, 252);
            this.lvConsultas.TabIndex = 5;
            this.lvConsultas.UseCompatibleStateImageBehavior = false;
            this.lvConsultas.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 90;
            // 
            // Capital
            // 
            this.Capital.Text = "Capital";
            // 
            // Continente
            // 
            this.Continente.Text = "Continente";
            this.Continente.Width = 90;
            // 
            // Poblacion
            // 
            this.Poblacion.Text = "Poblacion";
            this.Poblacion.Width = 90;
            // 
            // PIB
            // 
            this.PIB.Text = "PIB";
            // 
            // Renta
            // 
            this.Renta.Text = "Renta/Cápita";
            this.Renta.Width = 120;
            // 
            // fmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.lvConsultas);
            this.Controls.Add(this.panel1);
            this.Name = "fmConsultar";
            this.Text = "Consultar";
            this.gbContinentes.ResumeLayout(false);
            this.gbContinentes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContinentes;
        private System.Windows.Forms.CheckBox ckOceania;
        private System.Windows.Forms.CheckBox ckAfrica;
        private System.Windows.Forms.CheckBox ckAsia;
        private System.Windows.Forms.CheckBox ckEuropa;
        private System.Windows.Forms.CheckBox ckAmerica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Button btPais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvConsultas;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Capital;
        private System.Windows.Forms.ColumnHeader Continente;
        private System.Windows.Forms.ColumnHeader Poblacion;
        private System.Windows.Forms.ColumnHeader PIB;
        private System.Windows.Forms.ColumnHeader Renta;
    }
}