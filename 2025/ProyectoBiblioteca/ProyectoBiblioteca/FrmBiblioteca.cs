using System;
using System.Data;
using System.Windows.Forms;
using ClienteSqlServer;

namespace ProyectoBiblioteca
{
    public partial class FrmBiblioteca: Form
    {
        // Propiedades
        private readonly AsistenteSql _asistenteSql;
        private readonly string _cadenaDeConexion = "Server=localhost;Database=Biblioteca;Trusted_Connection=True;";

        public Libro _libroSeleccionado { get; set; }

        // Constructor
        public FrmBiblioteca()
        {
            InitializeComponent();

            _asistenteSql = new AsistenteSql(_cadenaDeConexion);
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void DgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            ObtenerLibroSeleccionado();

            if (_libroSeleccionado != null)
            {
                TxtTitulo.Text = _libroSeleccionado.Titulo;
                TxtAutor.Text = _libroSeleccionado.Autor;
                TxtAnio.Text = _libroSeleccionado.AnioPublicacion.ToString();
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = TxtTitulo.Text.Trim();
            string autor = TxtAutor.Text.Trim();
            if (!int.TryParse(TxtAnio.Text.Trim(), out int anio))
            {
                MessageBox.Show("El año debe ser un número válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Título y autor son campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try 
            {
                ObtenerLibroSeleccionado();
                string consulta;
                string mensaje;

                if (_libroSeleccionado == null) // Modo Agregar
                {
                    consulta = $"INSERT INTO Libros (Titulo, Autor, AnioPublicacion) VALUES ('{titulo}', '{autor}', {anio})";
                    mensaje = "Libro agregado exitosamente.";
                }
                else // Modo Actualizar
                {
                    consulta = $"UPDATE Libros SET Titulo = '{titulo}', Autor = '{autor}', AnioPublicacion = {anio} WHERE Id = {_libroSeleccionado.Id}";
                    mensaje = "Libro actualizado exitosamente.";
                }

                int filasAfectadas = _asistenteSql.EjecutarNoConsulta(consulta);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLibros();
                    LimpiarCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvLibros.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un libro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(DgvLibros.SelectedRows[0].Cells["Id"].Value);
                string consulta = $"DELETE FROM Libros WHERE Id = {id}";
                int filasAfectadas = _asistenteSql.EjecutarNoConsulta(consulta);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Libro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLibros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarLibros()
        {
            try
            {
                string consulta = "SELECT Id, Titulo, Autor, AnioPublicacion FROM Libros";
                DataTable dt = _asistenteSql.EjecutarConsulta(consulta);
                DgvLibros.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerLibroSeleccionado()
        {
            if (DgvLibros.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DgvLibros.SelectedRows[0];

                _libroSeleccionado = new Libro
                {
                    Id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value),
                    Titulo = filaSeleccionada.Cells["Titulo"].Value.ToString(),
                    Autor = filaSeleccionada.Cells["Autor"].Value.ToString(),
                    AnioPublicacion = Convert.ToInt32(filaSeleccionada.Cells["AnioPublicacion"].Value)
                };

                BtnGuardar.Text = "Guardar";
            }
            else
            {
                _libroSeleccionado = null;
            }
        }

        private void LimpiarCampos()
        {
            _libroSeleccionado = null;

            DgvLibros.ClearSelection();
            TxtTitulo.Clear();
            TxtAutor.Clear();
            TxtAnio.Clear();

            BtnGuardar.Text = "Agregar";
        }
    }
}
