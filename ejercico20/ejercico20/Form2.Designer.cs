
namespace ejercico20
{
    partial class Form2
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
            this.labelmensaje = new System.Windows.Forms.Label();
            this.lblcomentario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelmensaje
            // 
            this.labelmensaje.AutoSize = true;
            this.labelmensaje.Location = new System.Drawing.Point(38, 38);
            this.labelmensaje.Name = "labelmensaje";
            this.labelmensaje.Size = new System.Drawing.Size(35, 13);
            this.labelmensaje.TabIndex = 0;
            this.labelmensaje.Text = "label1";
            // 
            // lblcomentario
            // 
            this.lblcomentario.AutoSize = true;
            this.lblcomentario.Location = new System.Drawing.Point(41, 77);
            this.lblcomentario.Name = "lblcomentario";
            this.lblcomentario.Size = new System.Drawing.Size(35, 13);
            this.lblcomentario.TabIndex = 1;
            this.lblcomentario.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 144);
            this.Controls.Add(this.lblcomentario);
            this.Controls.Add(this.labelmensaje);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmensaje;
        private System.Windows.Forms.Label lblcomentario;
    }
}