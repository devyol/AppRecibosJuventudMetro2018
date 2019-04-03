namespace MET01.UI.Formularios
{
    partial class frmVistaPrevia
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
            this.rptdiseno = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptdiseno
            // 
            this.rptdiseno.Location = new System.Drawing.Point(12, 67);
            this.rptdiseno.Name = "rptdiseno";
            this.rptdiseno.Size = new System.Drawing.Size(873, 446);
            this.rptdiseno.TabIndex = 0;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(609, 12);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(112, 32);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(738, 12);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(112, 32);
            this.btnimprimir.TabIndex = 2;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // frmVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 525);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.rptdiseno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVistaPrevia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPRESION RECIBO";
            this.Load += new System.EventHandler(this.frmVistaPrevia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptdiseno;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnimprimir;
    }
}