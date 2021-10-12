
namespace ejercicio19
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
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.btnenvio1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(33, 46);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(100, 20);
            this.txtmensaje.TabIndex = 1;
            // 
            // btnenvio1
            // 
            this.btnenvio1.Location = new System.Drawing.Point(193, 42);
            this.btnenvio1.Name = "btnenvio1";
            this.btnenvio1.Size = new System.Drawing.Size(75, 23);
            this.btnenvio1.TabIndex = 2;
            this.btnenvio1.Text = "Envio1";
            this.btnenvio1.UseVisualStyleBackColor = true;
            this.btnenvio1.Click += new System.EventHandler(this.btnenvio1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 232);
            this.Controls.Add(this.btnenvio1);
            this.Controls.Add(this.txtmensaje);
            this.Name = "Form1";
            this.Text = "Forma1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Button btnenvio1;
    }
}

