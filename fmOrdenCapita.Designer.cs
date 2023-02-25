namespace Proyecto03Datos
{
    partial class fmOrdenCapita
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvRentaCapita = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // lvRentaCapita
            // 
            this.lvRentaCapita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRentaCapita.HideSelection = false;
            this.lvRentaCapita.Location = new System.Drawing.Point(0, 100);
            this.lvRentaCapita.Name = "lvRentaCapita";
            this.lvRentaCapita.Size = new System.Drawing.Size(800, 350);
            this.lvRentaCapita.TabIndex = 1;
            this.lvRentaCapita.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clasificación de paises por Renta per Cápita";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(647, 36);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 33);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // fmOrdenCapita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvRentaCapita);
            this.Controls.Add(this.panel1);
            this.Name = "fmOrdenCapita";
            this.Text = "Orden Cápita";
            this.Load += new System.EventHandler(this.fmOrdenCapita_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvRentaCapita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalir;
    }
}