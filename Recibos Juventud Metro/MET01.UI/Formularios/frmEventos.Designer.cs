namespace MET01.UI.Formularios
{
    partial class frmEventos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtglistado = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btncancel = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxestado);
            this.groupBox1.Controls.Add(this.lblestado);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Evento";
            // 
            // cbxestado
            // 
            this.cbxestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxestado.FormattingEnabled = true;
            this.cbxestado.Location = new System.Drawing.Point(215, 95);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(384, 24);
            this.cbxestado.TabIndex = 3;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(6, 93);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(180, 24);
            this.lblestado.TabIndex = 2;
            this.lblestado.Text = "Estado del Evento";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(215, 58);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(384, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(6, 56);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(191, 24);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre del Evento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnlimpiar);
            this.groupBox2.Controls.Add(this.btnmodificar);
            this.groupBox2.Controls.Add(this.btnagregar);
            this.groupBox2.Location = new System.Drawing.Point(639, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(90, 115);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(161, 37);
            this.btnlimpiar.TabIndex = 2;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(90, 72);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(161, 37);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(90, 29);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(161, 37);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Guardar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtglistado);
            this.groupBox3.Location = new System.Drawing.Point(12, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(972, 292);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Eventos";
            // 
            // dtglistado
            // 
            this.dtglistado.AllowUserToAddRows = false;
            this.dtglistado.AllowUserToDeleteRows = false;
            this.dtglistado.AutoGenerateColumns = false;
            this.dtglistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtglistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtglistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evento,
            this.nombre,
            this.estado_registro,
            this.usuario_creacion,
            this.fecha_creacion,
            this.usuario_modificacion,
            this.fecha_modificacion});
            this.dtglistado.DataSource = this.bindingSource1;
            this.dtglistado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtglistado.Location = new System.Drawing.Point(3, 18);
            this.dtglistado.Name = "dtglistado";
            this.dtglistado.ReadOnly = true;
            this.dtglistado.RowHeadersVisible = false;
            this.dtglistado.RowTemplate.Height = 24;
            this.dtglistado.Size = new System.Drawing.Size(966, 271);
            this.dtglistado.TabIndex = 0;
            this.dtglistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistado_CellClick);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(407, 551);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(204, 62);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Salir";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(278, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(376, 32);
            this.lbltitulo.TabIndex = 4;
            this.lbltitulo.Text = "Mantenimiento de Eventos";
            // 
            // evento
            // 
            this.evento.DataPropertyName = "evento";
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Visible = false;
            this.evento.Width = 77;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Evento";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 77;
            // 
            // estado_registro
            // 
            this.estado_registro.DataPropertyName = "estado_registro";
            this.estado_registro.HeaderText = "Estado";
            this.estado_registro.Name = "estado_registro";
            this.estado_registro.ReadOnly = true;
            this.estado_registro.Width = 77;
            // 
            // usuario_creacion
            // 
            this.usuario_creacion.DataPropertyName = "usuario_creacion";
            this.usuario_creacion.HeaderText = "Usuario Creacion";
            this.usuario_creacion.Name = "usuario_creacion";
            this.usuario_creacion.ReadOnly = true;
            this.usuario_creacion.Width = 142;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.DataPropertyName = "fecha_creacion";
            this.fecha_creacion.HeaderText = "Fecha Creacion";
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.ReadOnly = true;
            this.fecha_creacion.Width = 132;
            // 
            // usuario_modificacion
            // 
            this.usuario_modificacion.DataPropertyName = "usuario_modificacion";
            this.usuario_modificacion.HeaderText = "Usuario Modificacion";
            this.usuario_modificacion.Name = "usuario_modificacion";
            this.usuario_modificacion.ReadOnly = true;
            this.usuario_modificacion.Visible = false;
            this.usuario_modificacion.Width = 164;
            // 
            // fecha_modificacion
            // 
            this.fecha_modificacion.DataPropertyName = "fecha_modificacion";
            this.fecha_modificacion.HeaderText = "Fecha Modificacion";
            this.fecha_modificacion.Name = "fecha_modificacion";
            this.fecha_modificacion.ReadOnly = true;
            this.fecha_modificacion.Visible = false;
            this.fecha_modificacion.Width = 154;
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 625);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.frmEventos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtglistado;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ComboBox cbxestado;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_modificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_modificacion;
    }
}