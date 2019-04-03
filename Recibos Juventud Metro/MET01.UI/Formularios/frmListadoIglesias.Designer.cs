namespace MET01.UI.Formularios
{
    partial class frmListadoIglesias
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtiglesia = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dtgIglesias = new System.Windows.Forms.DataGridView();
            this.idIglesia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recibo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reciboOficina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bsiglesias = new System.Windows.Forms.BindingSource(this.components);
            this.btnnuevo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stmOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAlMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgRecibos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recibo_oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_iglesia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_gestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impresion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bsRecibos = new System.Windows.Forms.BindingSource(this.components);
            this.lblrecibos = new System.Windows.Forms.Label();
            this.btntodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIglesias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsiglesias)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iglesias del Area Metropolitana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iglesia";
            // 
            // txtiglesia
            // 
            this.txtiglesia.Location = new System.Drawing.Point(76, 59);
            this.txtiglesia.Name = "txtiglesia";
            this.txtiglesia.Size = new System.Drawing.Size(417, 20);
            this.txtiglesia.TabIndex = 2;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(499, 56);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(91, 24);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dtgIglesias
            // 
            this.dtgIglesias.AllowUserToAddRows = false;
            this.dtgIglesias.AllowUserToDeleteRows = false;
            this.dtgIglesias.AutoGenerateColumns = false;
            this.dtgIglesias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgIglesias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgIglesias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIglesias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIglesia,
            this.region,
            this.nombre,
            this.recibo,
            this.reciboOficina});
            this.dtgIglesias.DataSource = this.bsiglesias;
            this.dtgIglesias.Location = new System.Drawing.Point(12, 85);
            this.dtgIglesias.Name = "dtgIglesias";
            this.dtgIglesias.RowHeadersVisible = false;
            this.dtgIglesias.Size = new System.Drawing.Size(820, 228);
            this.dtgIglesias.TabIndex = 4;
            this.dtgIglesias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgIglesias_CellContentClick);
            // 
            // idIglesia
            // 
            this.idIglesia.DataPropertyName = "idIglesia";
            this.idIglesia.HeaderText = "id";
            this.idIglesia.Name = "idIglesia";
            this.idIglesia.Visible = false;
            this.idIglesia.Width = 21;
            // 
            // region
            // 
            this.region.DataPropertyName = "region";
            this.region.HeaderText = "Region";
            this.region.Name = "region";
            this.region.Width = 66;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 69;
            // 
            // recibo
            // 
            this.recibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.recibo.HeaderText = "Ofrenda Presentada Día del Evento";
            this.recibo.Name = "recibo";
            this.recibo.Text = "Generar Recibo";
            this.recibo.UseColumnTextForButtonValue = true;
            this.recibo.Width = 119;
            // 
            // reciboOficina
            // 
            this.reciboOficina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.reciboOficina.HeaderText = "Ofrenda Presentada en Oficina";
            this.reciboOficina.Name = "reciboOficina";
            this.reciboOficina.Text = "Registrar";
            this.reciboOficina.UseColumnTextForButtonValue = true;
            this.reciboOficina.Width = 113;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(706, 56);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(126, 24);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.Text = "Nueva Iglesia";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmOpciones,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stmOpciones
            // 
            this.stmOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDeUsuarioToolStripMenuItem,
            this.irAlMenuToolStripMenuItem});
            this.stmOpciones.Name = "stmOpciones";
            this.stmOpciones.Size = new System.Drawing.Size(69, 20);
            this.stmOpciones.Text = "Opciones";
            // 
            // cambiarDeUsuarioToolStripMenuItem
            // 
            this.cambiarDeUsuarioToolStripMenuItem.Name = "cambiarDeUsuarioToolStripMenuItem";
            this.cambiarDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de Usuario";
            this.cambiarDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeUsuarioToolStripMenuItem_Click);
            // 
            // irAlMenuToolStripMenuItem
            // 
            this.irAlMenuToolStripMenuItem.Name = "irAlMenuToolStripMenuItem";
            this.irAlMenuToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.irAlMenuToolStripMenuItem.Text = "ir al Menu";
            this.irAlMenuToolStripMenuItem.Click += new System.EventHandler(this.irAlMenuToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGeneralToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteGeneralToolStripMenuItem
            // 
            this.reporteGeneralToolStripMenuItem.Name = "reporteGeneralToolStripMenuItem";
            this.reporteGeneralToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.reporteGeneralToolStripMenuItem.Text = "Reporte General";
            this.reporteGeneralToolStripMenuItem.Click += new System.EventHandler(this.reporteGeneralToolStripMenuItem_Click);
            // 
            // dtgRecibos
            // 
            this.dtgRecibos.AllowUserToAddRows = false;
            this.dtgRecibos.AllowUserToDeleteRows = false;
            this.dtgRecibos.AutoGenerateColumns = false;
            this.dtgRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRecibos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.recibo_oficina,
            this.nombre_iglesia,
            this.total,
            this.usuario_gestion,
            this.fecha_creacion,
            this.Impresion});
            this.dtgRecibos.DataSource = this.bsRecibos;
            this.dtgRecibos.Location = new System.Drawing.Point(12, 348);
            this.dtgRecibos.Name = "dtgRecibos";
            this.dtgRecibos.RowHeadersVisible = false;
            this.dtgRecibos.Size = new System.Drawing.Size(820, 213);
            this.dtgRecibos.TabIndex = 7;
            this.dtgRecibos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "recibo";
            this.Column1.HeaderText = "Recibo";
            this.Column1.Name = "Column1";
            // 
            // recibo_oficina
            // 
            this.recibo_oficina.DataPropertyName = "recibo_oficina";
            this.recibo_oficina.HeaderText = "Recibo Oficina";
            this.recibo_oficina.Name = "recibo_oficina";
            // 
            // nombre_iglesia
            // 
            this.nombre_iglesia.DataPropertyName = "nombre_iglesia";
            this.nombre_iglesia.HeaderText = "Iglesia";
            this.nombre_iglesia.Name = "nombre_iglesia";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Cantidad";
            this.total.Name = "total";
            // 
            // usuario_gestion
            // 
            this.usuario_gestion.DataPropertyName = "usuario_gestion";
            this.usuario_gestion.HeaderText = "Usuario";
            this.usuario_gestion.Name = "usuario_gestion";
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.DataPropertyName = "fecha_creacion";
            this.fecha_creacion.HeaderText = "Fecha";
            this.fecha_creacion.Name = "fecha_creacion";
            // 
            // Impresion
            // 
            this.Impresion.HeaderText = "Imprimir";
            this.Impresion.Name = "Impresion";
            this.Impresion.Text = "Imprimir";
            this.Impresion.UseColumnTextForButtonValue = true;
            // 
            // lblrecibos
            // 
            this.lblrecibos.AutoSize = true;
            this.lblrecibos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecibos.Location = new System.Drawing.Point(12, 322);
            this.lblrecibos.Name = "lblrecibos";
            this.lblrecibos.Size = new System.Drawing.Size(218, 19);
            this.lblrecibos.TabIndex = 8;
            this.lblrecibos.Text = "Listado de Recibos Emitidos";
            // 
            // btntodos
            // 
            this.btntodos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntodos.Location = new System.Drawing.Point(603, 56);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(91, 24);
            this.btntodos.TabIndex = 9;
            this.btntodos.Text = "Todas";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // frmListadoIglesias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 573);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.lblrecibos);
            this.Controls.Add(this.dtgRecibos);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dtgIglesias);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtiglesia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmListadoIglesias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Iglesias";
            this.Load += new System.EventHandler(this.frmListadoIglesias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIglesias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsiglesias)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtiglesia;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dtgIglesias;
        private System.Windows.Forms.BindingSource bsiglesias;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stmOpciones;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAlMenuToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIglesia;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewButtonColumn recibo;
        private System.Windows.Forms.DataGridViewButtonColumn reciboOficina;
        private System.Windows.Forms.DataGridView dtgRecibos;
        private System.Windows.Forms.BindingSource bsRecibos;
        private System.Windows.Forms.Label lblrecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recibo_oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_iglesia;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_gestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewButtonColumn Impresion;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralToolStripMenuItem;
        private System.Windows.Forms.Button btntodos;
    }
}