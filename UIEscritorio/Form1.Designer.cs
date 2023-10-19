namespace UIEscritorio
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
            dgvUsuarios = new DataGridView();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            lblFechaNac = new Label();
            dtpFechaNac = new DateTimePicker();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            btnMostrarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 12);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 29;
            dgvUsuarios.Size = new Size(937, 225);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.Click += dgvUsuarios_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(50, 267);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(143, 264);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(143, 312);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 27);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(50, 315);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(143, 368);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 27);
            txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(50, 371);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(50, 432);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(77, 20);
            lblFechaNac.TabIndex = 7;
            lblFechaNac.Text = "Fecha Nac";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(143, 432);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(250, 27);
            dtpFechaNac.TabIndex = 8;
            dtpFechaNac.Value = new DateTime(2023, 10, 18, 0, 0, 0, 0);
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(837, 465);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(715, 465);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(570, 465);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(591, 274);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(237, 27);
            txtBuscador.TabIndex = 12;
            txtBuscador.Text = "Buscar por nombre\r\n";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(837, 274);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(612, 361);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(154, 29);
            btnMostrarTodos.TabIndex = 14;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 506);
            Controls.Add(btnMostrarTodos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaNac);
            Controls.Add(lblFechaNac);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(dgvUsuarios);
            Name = "Form1";
            Text = "Usuarios";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblFechaNac;
        private DateTimePicker dtpFechaNac;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtBuscador;
        private Button btnBuscar;
        private Button btnMostrarTodos;
    }
}