
namespace ejercico20
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
            this.textenvio1 = new System.Windows.Forms.TextBox();
            this.btnenvio1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textenvio1
            // 
            this.textenvio1.Location = new System.Drawing.Point(26, 36);
            this.textenvio1.Name = "textenvio1";
            this.textenvio1.Size = new System.Drawing.Size(100, 20);
            this.textenvio1.TabIndex = 0;
            this.textenvio1.Text = "envio1";
            // 
            // btnenvio1
            // 
            this.btnenvio1.Location = new System.Drawing.Point(220, 32);
            this.btnenvio1.Name = "btnenvio1";
            this.btnenvio1.Size = new System.Drawing.Size(75, 23);
            this.btnenvio1.TabIndex = 1;
            this.btnenvio1.Text = "envio1";
            this.btnenvio1.UseVisualStyleBackColor = true;
            this.btnenvio1.Click += new System.EventHandler(this.btnenvio1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 152);
            this.Controls.Add(this.btnenvio1);
            this.Controls.Add(this.textenvio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textenvio1;
        private System.Windows.Forms.Button btnenvio1;
    }
}

