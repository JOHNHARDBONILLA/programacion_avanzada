
namespace ejerciciopractico
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblseguro = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.rbbasico = new System.Windows.Forms.RadioButton();
            this.rbterceros = new System.Windows.Forms.RadioButton();
            this.rbtotal = new System.Windows.Forms.RadioButton();
            this.segurosaseleccionar = new System.Windows.Forms.GroupBox();
            this.equipamiento = new System.Windows.Forms.GroupBox();
            this.chksonido = new System.Windows.Forms.CheckBox();
            this.chkacondicionado = new System.Windows.Forms.CheckBox();
            this.lblcosto = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.btncotizar = new System.Windows.Forms.Button();
            this.txtcotizacion = new System.Windows.Forms.TextBox();
            this.segurosaseleccionar.SuspendLayout();
            this.equipamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(33, 24);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(49, 15);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "nombre";
            // 
            // lblseguro
            // 
            this.lblseguro.AutoSize = true;
            this.lblseguro.Location = new System.Drawing.Point(33, 77);
            this.lblseguro.Name = "lblseguro";
            this.lblseguro.Size = new System.Drawing.Size(43, 15);
            this.lblseguro.TabIndex = 1;
            this.lblseguro.Text = "seguro";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(102, 24);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 2;
            // 
            // rbbasico
            // 
            this.rbbasico.AutoSize = true;
            this.rbbasico.Location = new System.Drawing.Point(6, 22);
            this.rbbasico.Name = "rbbasico";
            this.rbbasico.Size = new System.Drawing.Size(59, 19);
            this.rbbasico.TabIndex = 3;
            this.rbbasico.TabStop = true;
            this.rbbasico.Text = "basico";
            this.rbbasico.UseVisualStyleBackColor = true;
            // 
            // rbterceros
            // 
            this.rbterceros.AutoSize = true;
            this.rbterceros.Location = new System.Drawing.Point(6, 47);
            this.rbterceros.Name = "rbterceros";
            this.rbterceros.Size = new System.Drawing.Size(76, 19);
            this.rbterceros.TabIndex = 4;
            this.rbterceros.TabStop = true;
            this.rbterceros.Text = "a terceros";
            this.rbterceros.UseVisualStyleBackColor = true;
            this.rbterceros.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtotal
            // 
            this.rbtotal.AutoSize = true;
            this.rbtotal.Location = new System.Drawing.Point(6, 72);
            this.rbtotal.Name = "rbtotal";
            this.rbtotal.Size = new System.Drawing.Size(49, 19);
            this.rbtotal.TabIndex = 5;
            this.rbtotal.TabStop = true;
            this.rbtotal.Text = "total";
            this.rbtotal.UseVisualStyleBackColor = true;
            // 
            // segurosaseleccionar
            // 
            this.segurosaseleccionar.Controls.Add(this.rbbasico);
            this.segurosaseleccionar.Controls.Add(this.rbtotal);
            this.segurosaseleccionar.Controls.Add(this.rbterceros);
            this.segurosaseleccionar.Location = new System.Drawing.Point(102, 65);
            this.segurosaseleccionar.Name = "segurosaseleccionar";
            this.segurosaseleccionar.Size = new System.Drawing.Size(100, 97);
            this.segurosaseleccionar.TabIndex = 6;
            this.segurosaseleccionar.TabStop = false;
            this.segurosaseleccionar.Text = "groupBox1";
            // 
            // equipamiento
            // 
            this.equipamiento.Controls.Add(this.chksonido);
            this.equipamiento.Controls.Add(this.chkacondicionado);
            this.equipamiento.Location = new System.Drawing.Point(300, 65);
            this.equipamiento.Name = "equipamiento";
            this.equipamiento.Size = new System.Drawing.Size(133, 66);
            this.equipamiento.TabIndex = 7;
            this.equipamiento.TabStop = false;
            this.equipamiento.Text = "groupBox1";
            this.equipamiento.Enter += new System.EventHandler(this.equipamiento_Enter);
            // 
            // chksonido
            // 
            this.chksonido.AutoSize = true;
            this.chksonido.Location = new System.Drawing.Point(7, 47);
            this.chksonido.Name = "chksonido";
            this.chksonido.Size = new System.Drawing.Size(62, 19);
            this.chksonido.TabIndex = 1;
            this.chksonido.Text = "sonido";
            this.chksonido.UseVisualStyleBackColor = true;
            // 
            // chkacondicionado
            // 
            this.chkacondicionado.AutoSize = true;
            this.chkacondicionado.Location = new System.Drawing.Point(7, 22);
            this.chkacondicionado.Name = "chkacondicionado";
            this.chkacondicionado.Size = new System.Drawing.Size(127, 19);
            this.chkacondicionado.TabIndex = 0;
            this.chkacondicionado.Text = "aire acondicionado";
            this.chkacondicionado.UseVisualStyleBackColor = true;
            // 
            // lblcosto
            // 
            this.lblcosto.AutoSize = true;
            this.lblcosto.Location = new System.Drawing.Point(33, 178);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(36, 15);
            this.lblcosto.TabIndex = 8;
            this.lblcosto.Text = "costo";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(85, 203);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(100, 23);
            this.txtcosto.TabIndex = 9;
            this.txtcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btncotizar
            // 
            this.btncotizar.Location = new System.Drawing.Point(307, 202);
            this.btncotizar.Name = "btncotizar";
            this.btncotizar.Size = new System.Drawing.Size(75, 23);
            this.btncotizar.TabIndex = 10;
            this.btncotizar.Text = "cotizar";
            this.btncotizar.UseVisualStyleBackColor = true;
            this.btncotizar.Click += new System.EventHandler(this.btncotizar_Click);
            // 
            // txtcotizacion
            // 
            this.txtcotizacion.Location = new System.Drawing.Point(85, 249);
            this.txtcotizacion.Multiline = true;
            this.txtcotizacion.Name = "txtcotizacion";
            this.txtcotizacion.Size = new System.Drawing.Size(321, 94);
            this.txtcotizacion.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 355);
            this.Controls.Add(this.txtcotizacion);
            this.Controls.Add(this.btncotizar);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.lblcosto);
            this.Controls.Add(this.equipamiento);
            this.Controls.Add(this.segurosaseleccionar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblseguro);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "seguro";
            this.segurosaseleccionar.ResumeLayout(false);
            this.segurosaseleccionar.PerformLayout();
            this.equipamiento.ResumeLayout(false);
            this.equipamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblseguro;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.RadioButton rbbasico;
        private System.Windows.Forms.RadioButton rbterceros;
        private System.Windows.Forms.RadioButton rbtotal;
        private System.Windows.Forms.GroupBox segurosaseleccionar;
        private System.Windows.Forms.GroupBox equipamiento;
        private System.Windows.Forms.CheckBox chksonido;
        private System.Windows.Forms.CheckBox chkacondicionado;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Button btncotizar;
        private System.Windows.Forms.TextBox txtcotizacion;
    }
}

