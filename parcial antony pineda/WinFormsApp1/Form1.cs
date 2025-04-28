using MinecraftManager.Utils;
using MinecraftManager.Services;
using MinecraftManager.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        private readonly InventarioService _inventarioService;

        public Form1()
        {
            InitializeComponent();

            var dbManager = new MinecraftManager.Utils.DatabaseManager();
            _jugadorService = new JugadorService(dbManager);
            _bloqueService = new BloqueService(dbManager);
            _inventarioService = new InventarioService(dbManager, _jugadorService, _bloqueService);

            CargarJugadores();
            CargarBloques();
            CargarInventario();
        }

        private void CargarJugadores()
        {
            dgvJugadores.DataSource = _jugadorService.ObtenerTodos();
        }

        private void CargarBloques()
        {
            dgvBloques.DataSource = _bloqueService.ObtenerTodos();
        }

        private void CargarInventario()
        {
            dgvInventario.DataSource = _inventarioService.ObtenerTodos();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                var jugador = new Jugador
                {
                    Nombre = txtNombreJugador.Text,
                    Nivel = (int)nudNivelJugador.Value
                };

                _jugadorService.Crear(jugador);
                MessageBox.Show("Jugador agregado con éxito.");
                CargarJugadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar jugador: {ex.Message}");
            }
        }

        private void btnBuscarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombreJugador.Text;
                dgvJugadores.DataSource = _jugadorService.ObtenerTodos()
                    .FindAll(j => j.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar jugador: {ex.Message}");
            }
        }

        private void btnActualizarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJugadores.SelectedRows.Count > 0)
                {
                    var jugador = dgvJugadores.SelectedRows[0].DataBoundItem as Jugador;
                    if (jugador != null)
                    {
                        jugador.Nombre = txtNombreJugador.Text;
                        jugador.Nivel = (int)nudNivelJugador.Value;

                        _jugadorService.Actualizar(jugador);
                        MessageBox.Show("Jugador actualizado con éxito.");
                        CargarJugadores();
                    }
                    else
                    {
                        MessageBox.Show("Error: No se pudo obtener el jugador seleccionado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un jugador para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar jugador: {ex.Message}");
            }
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJugadores.SelectedRows.Count > 0)
                {
                    var jugador = dgvJugadores.SelectedRows[0].DataBoundItem as Jugador;
                    if (jugador != null)
                    {
                        var confirmResult = MessageBox.Show(
                            $"¿Estás seguro de que deseas eliminar al jugador '{jugador.Nombre}'?",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            _jugadorService.Eliminar(jugador.Id);
                            MessageBox.Show("Jugador eliminado con éxito.");
                            CargarJugadores();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: No se pudo obtener el jugador seleccionado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un jugador para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar jugador: {ex.Message}");
            }
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            try
            {
                var inventario = new Inventario
                {
                    NombreJugador = txtNombreItem.Text,
                    NombreBloque = cmbTipoItem.Text,
                    Cantidad = 1
                };

                _inventarioService.Agregar(inventario);
                MessageBox.Show("Ítem agregado al inventario con éxito.");
                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar ítem al inventario: {ex.Message}");
            }
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombreItem.Text;
                dgvInventario.DataSource = _inventarioService.ObtenerTodos()
                    .FindAll(i => i.NombreJugador.Contains(nombre, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar ítem en el inventario: {ex.Message}");
            }
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.SelectedRows.Count > 0)
                {
                    var inventario = dgvInventario.SelectedRows[0].DataBoundItem as Inventario;
                    if (inventario != null)
                    {
                        var confirmResult = MessageBox.Show(
                            $"¿Estás seguro de que deseas eliminar el ítem '{inventario.NombreBloque}' del inventario?",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            _inventarioService.Eliminar(inventario.Id);
                            MessageBox.Show("Ítem eliminado del inventario con éxito.");
                            CargarInventario();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: No se pudo obtener el ítem seleccionado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un ítem para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar ítem del inventario: {ex.Message}");
            }
        }

        private void btnAgregarBloque_Click(object sender, EventArgs e)
        {
            try
            {
                var bloque = new Bloque
                {
                    Nombre = txtNombreBloque.Text,
                    Tipo = cmbTipoBloque.Text,
                    Rareza = cmbRarezaBloque.Text
                };

                _bloqueService.Crear(bloque);
                MessageBox.Show("Bloque agregado con éxito.");
                CargarBloques();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar bloque: {ex.Message}");
            }
        }

        private void btnBuscarBloque_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombreBloque.Text;
                dgvBloques.DataSource = _bloqueService.ObtenerTodos()
                    .FindAll(b => b.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar bloque: {ex.Message}");
            }
        }

        private void btnActualizarBloque_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBloques.SelectedRows.Count > 0)
                {
                    var bloque = dgvBloques.SelectedRows[0].DataBoundItem as Bloque;
                    if (bloque != null)
                    {
                        bloque.Nombre = txtNombreBloque.Text;
                        bloque.Tipo = cmbTipoBloque.Text;
                        bloque.Rareza = cmbRarezaBloque.Text;

                        _bloqueService.Actualizar(bloque);
                        MessageBox.Show("Bloque actualizado con éxito.");
                        CargarBloques();
                    }
                    else
                    {
                        MessageBox.Show("Error: No se pudo obtener el bloque seleccionado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un bloque para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar bloque: {ex.Message}");
            }
        }

        private void btnEliminarBloque_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBloques.SelectedRows.Count > 0)
                {
                    var bloque = dgvBloques.SelectedRows[0].DataBoundItem as Bloque;
                    if (bloque != null)
                    {
                        var confirmResult = MessageBox.Show(
                            $"¿Estás seguro de que deseas eliminar el bloque '{bloque.Nombre}'?",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            _bloqueService.Eliminar(bloque.Id);
                            MessageBox.Show("Bloque eliminado con éxito.");
                            CargarBloques();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: No se pudo obtener el bloque seleccionado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un bloque para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar bloque: {ex.Message}");
            }
        }

        private void btnBuscarPorIdBloque_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtNombreBloque.Text, out int id))
                {
                    var bloque = _bloqueService.ObtenerPorId(id);
                    if (bloque != null)
                    {
                        dgvBloques.DataSource = new[] { bloque };
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún bloque con el ID especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvBloques.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar bloque por ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarPorRarezaBloque_Click(object sender, EventArgs e)
        {
            try
            {
                var rareza = cmbRarezaBloque.Text;
                if (string.IsNullOrWhiteSpace(rareza))
                {
                    MessageBox.Show("Por favor, selecciona una rareza para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvBloques.DataSource = _bloqueService.BuscarPorRareza(rareza);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar bloques por rareza: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRarezaItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rarezaSeleccionada = cmbRarezaItem.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(rarezaSeleccionada))
            {
                dgvInventario.DataSource = _inventarioService.ObtenerTodos()
                    .FindAll(i => i.NombreBloque.Contains(rarezaSeleccionada, StringComparison.OrdinalIgnoreCase));
            }
        }

        private void cmbTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoSeleccionado = cmbTipoItem.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(tipoSeleccionado))
            {
                dgvInventario.DataSource = _inventarioService.ObtenerTodos()
                    .FindAll(i => i.NombreBloque.Contains(tipoSeleccionado, StringComparison.OrdinalIgnoreCase));
            }
        }

        private void cmbRarezaBloque_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rarezaSeleccionada = cmbRarezaBloque.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(rarezaSeleccionada))
            {
                dgvBloques.DataSource = _bloqueService.BuscarPorRareza(rarezaSeleccionada);
            }
        }

        private void cmbTipoBloque_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoSeleccionado = cmbTipoBloque.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(tipoSeleccionado))
            {
                dgvBloques.DataSource = _bloqueService.BuscarPorTipo(tipoSeleccionado);
            }
        }

        private void nudCantidadBloque_ValueChanged(object sender, EventArgs e)
        {
            var cantidad = (int)nudCantidadBloque.Value;
            dgvBloques.DataSource = _bloqueService.ObtenerTodos()
                .FindAll(b => b.Id <= cantidad);
        }

        private void nudNivelJugador_ValueChanged(object sender, EventArgs e)
        {
            var nivel = (int)nudNivelJugador.Value;
            dgvJugadores.DataSource = _jugadorService.ObtenerTodos()
                .FindAll(j => j.Nivel == nivel);
        }

        private void txtNombreBloque_TextChanged(object sender, EventArgs e)
        {
            var texto = txtNombreBloque.Text;
            dgvBloques.DataSource = _bloqueService.ObtenerTodos()
                .FindAll(b => b.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase));
        }

        private void txtNombreItem_TextChanged(object sender, EventArgs e)
        {
            var texto = txtNombreItem.Text;
            dgvInventario.DataSource = _inventarioService.ObtenerTodos()
                .FindAll(i => i.NombreBloque.Contains(texto, StringComparison.OrdinalIgnoreCase));
        }

        private void txtNombreJugador_TextChanged(object sender, EventArgs e)
        {
            var texto = txtNombreJugador.Text;
            dgvJugadores.DataSource = _jugadorService.ObtenerTodos()
                .FindAll(j => j.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase));
        }

        private void dgvBloques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}