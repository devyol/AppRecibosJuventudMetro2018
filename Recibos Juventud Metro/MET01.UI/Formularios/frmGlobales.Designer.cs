namespace MET01.UI.Formularios
{
    partial class frmGlobales
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
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.cbxevento = new System.Windows.Forms.ComboBox();
            this.cbxusuario = new System.Windows.Forms.ComboBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(246, 25);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(267, 24);
            this.lblEvento.TabIndex = 0;
            this.lblEvento.Text = "SELECCIONE UN EVENTO";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(167, 102);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(54, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "EVENTO:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(162, 153);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(59, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "USUARIO:";
            // 
            // cbxevento
            // 
            this.cbxevento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxevento.FormattingEnabled = true;
            this.cbxevento.Location = new System.Drawing.Point(250, 99);
            this.cbxevento.Name = "cbxevento";
            this.cbxevento.Size = new System.Drawing.Size(331, 21);
            this.cbxevento.TabIndex = 3;
            // 
            // cbxusuario
            // 
            this.cbxusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxusuario.FormattingEnabled = true;
            this.cbxusuario.Location = new System.Drawing.Point(250, 150);
            this.cbxusuario.Name = "cbxusuario";
            this.cbxusuario.Size = new System.Drawing.Size(171, 21);
            this.cbxusuario.TabIndex = 4;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(250, 198);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(94, 34);
            this.btnaceptar.TabIndex = 5;
            this.btnaceptar.Text = "INICIAR";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(419, 198);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(94, 34);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmGlobales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 271);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.cbxusuario);
            this.Controls.Add(this.cbxevento);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGlobales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.frmGlobales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.ComboBox cbxevento;
        private System.Windows.Forms.ComboBox cbxusuario;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}