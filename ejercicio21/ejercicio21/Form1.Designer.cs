﻿
namespace ejercicio21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnForma2 = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForma2
            // 
            this.btnForma2.Location = new System.Drawing.Point(187, 28);
            this.btnForma2.Name = "btnForma2";
            this.btnForma2.Size = new System.Drawing.Size(104, 23);
            this.btnForma2.TabIndex = 0;
            this.btnForma2.Text = "Abrir la Forma 2";
            this.btnForma2.UseVisualStyleBackColor = true;
            this.btnForma2.Click += new System.EventHandler(this.btnForma2_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(31, 32);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(79, 15);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "=========";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(31, 78);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(38, 15);
            this.lblContenido.TabIndex = 2;
            this.lblContenido.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 233);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnForma2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForma2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblContenido;
    }
}

