
namespace proyecto16
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
            this.lblA = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(29, 38);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(61, 30);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 1;
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(29, 64);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(61, 61);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 3;
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(126, 101);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(35, 13);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "label1";
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(203, 30);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(25, 23);
            this.btnsuma.TabIndex = 5;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(203, 58);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(25, 23);
            this.btnresta.TabIndex = 6;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(234, 58);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(25, 23);
            this.btndiv.TabIndex = 8;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(234, 30);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(25, 23);
            this.btnmult.TabIndex = 7;
            this.btnmult.Text = "X";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 139);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmult;
    }
}

