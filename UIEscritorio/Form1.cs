namespace UIEscritorio
{
    public partial class Form1 : Form
    {

        Negocios.Usuario CN_Usuario = new Negocios.Usuario();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            obtenerTodosLosUsuarios();
        }

        private void obtenerTodosLosUsuarios()
        {

            dgvUsuarios.DataSource = CN_Usuario.obtenerTodosLosUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean validUsu= CN_Usuario.crearUsuario(txtNombre.Text, txtApellido.Text, txtTelefono.Text, dtpFechaNac.Value);
                if (!validUsu)
                {
                    throw new Exception("Mail (apellido) no válido");
                }
                txtNombre.ResetText();
                txtApellido.ResetText();
                txtTelefono.ResetText();
                dtpFechaNac.ResetText();
                obtenerTodosLosUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre != null && txtApellido != null && txtTelefono != null)
            {
                int idUsu = (int)dgvUsuarios.CurrentRow.Cells[0].Value;
                try
                {
                    CN_Usuario.actualizarUsuario(idUsu, txtNombre.Text, txtApellido.Text, txtTelefono.Text, dtpFechaNac.Value);
                    obtenerTodosLosUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {

                int idUsu = (int)dgvUsuarios.CurrentRow.Cells[0].Value;
                try
                {
                    CN_Usuario.eliminarUsuario(idUsu);
                    txtNombre.ResetText();
                    txtApellido.ResetText();
                    txtTelefono.ResetText();
                    dtpFechaNac.ResetText();
                    obtenerTodosLosUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                txtNombre.Text = (string)dgvUsuarios.CurrentRow.Cells["Nombre"].Value;
                txtApellido.Text = (string)dgvUsuarios.CurrentRow.Cells["Apellido"].Value;
                txtTelefono.Text = (string)dgvUsuarios.CurrentRow.Cells["Telefono"].Value;
                dtpFechaNac.Value = (DateTime)dgvUsuarios.CurrentRow.Cells["FechaNacimiento"].Value;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUsuarios.DataSource = CN_Usuario.obtenerUsuarioPorNombre(txtBuscador.Text);
                txtBuscador.ResetText();
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message, "Error");
            }
            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                obtenerTodosLosUsuarios();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}