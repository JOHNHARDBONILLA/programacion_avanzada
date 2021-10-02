
namespace proy17
{
    partial class Form1
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
            this.chkpantalla = new System.Windows.Forms.CheckBox();
            this.chmouse = new System.Windows.Forms.CheckBox();
            this.chteclado = new System.Windows.Forms.CheckBox();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkpantalla
            // 
            this.chkpantalla.AutoSize = true;
            this.chkpantalla.Location = new System.Drawing.Point(104, 77);
            this.chkpantalla.Name = "chkpantalla";
            this.chkpantalla.Size = new System.Drawing.Size(87, 17);
            this.chkpantalla.TabIndex = 0;
            this.chkpantalla.Text = "monitor $400";
            this.chkpantalla.UseVisualStyleBackColor = true;
            this.chkpantalla.CheckedChanged += new System.EventHandler(this.chkpantalla_CheckedChanged);
            // 
            // chmouse
            // 
            this.chmouse.AutoSize = true;
            this.chmouse.Location = new System.Drawing.Point(104, 114);
            this.chmouse.Name = "chmouse";
            this.chmouse.Size = new System.Drawing.Size(78, 17);
            this.chmouse.TabIndex = 1;
            this.chmouse.Text = "mouse $20";
            this.chmouse.UseVisualStyleBackColor = true;
            this.chmouse.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chteclado
            // 
            this.chteclado.AutoSize = true;
            this.chteclado.Location = new System.Drawing.Point(104, 147);
            this.chteclado.Name = "chteclado";
            this.chteclado.Size = new System.Drawing.Size(82, 17);
            this.chteclado.TabIndex = 2;
            this.chteclado.Text = "teclado $18";
            this.chteclado.UseVisualStyleBackColor = true;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(146, 197);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(35, 13);
            this.lblmensaje.TabIndex = 3;
            this.lblmensaje.Text = "label1";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(361, 99);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.chteclado);
            this.Controls.Add(this.chmouse);
            this.Controls.Add(this.chkpantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkpantalla;
        private System.Windows.Forms.CheckBox chmouse;
        private System.Windows.Forms.CheckBox chteclado;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btncalcular;
    }
}

