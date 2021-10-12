
namespace ejercicio19
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
            this.lblmensaje1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensaje1
            // 
            this.lblmensaje1.AutoSize = true;
            this.lblmensaje1.Location = new System.Drawing.Point(35, 65);
            this.lblmensaje1.Name = "lblmensaje1";
            this.lblmensaje1.Size = new System.Drawing.Size(0, 13);
            this.lblmensaje1.TabIndex = 0;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblmensaje1);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lblmensaje1;
    }
}