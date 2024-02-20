using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class ControlesGestion : Form
    {
        DataTable _DATOS = new DataTable();
        
        private void ConfigurarTabla()
        {
            _DATOS.TableName = "Contactos";
            _DATOS.Columns.Add("cNombres");
            _DATOS.Columns.Add("cApellidos");
            _DATOS.Columns.Add("cGenero");
            _DATOS.Columns.Add("cTelefono");
            dtvContactos.AutoGenerateColumns = false;
            dtvContactos.DataSource = _DATOS;
        }
        private void LeerXml()
        {
            try
            {
                _DATOS.ReadXml("Contactos.xml");

            }
            catch (Exception)
            {
                throw;
            }
        }
        private void GuardarXml()
        {
            try
            {
                _DATOS.WriteXml("Contactos.xml");
            }
            catch(Exception)
            {
                throw;
            }
        }
        private int ConteoActual()
        {
            // Retorna el conteo actual de filas en la tabla
            return dtvContactos.Rows.Count;
        }

        private void ActualizarConteo()
        {
            // Actualiza el texto del label con el conteo actual
            lblResultado.Text = ConteoActual().ToString();
        }


        public ControlesGestion()
        {
            InitializeComponent();
            ConfigurarTabla();

        }

        private void ControlesGestion_Load(object sender, EventArgs e)
        {
            LeerXml();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Usuario f = new Agregar_Usuario();
            f.ShowDialog();
            if (f.Procesar)
            {
                try
                {
                    DataRow NuevaFila = _DATOS.NewRow();
                    NuevaFila["cNombres"] = f.txtboxNombres.Text;
                    NuevaFila["cApellidos"] = f.txtboxApellidos.Text;
                    NuevaFila["cGenero"] = f.comboGenero.Text;
                    NuevaFila["cTelefono"] = f.msboxTelefono.Text;
                    _DATOS.Rows.Add(NuevaFila);
                    MessageBox.Show("Registro Agregado",
                        "Confirmado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    GuardarXml();
                    // Después de agregar, actualiza el conteo
                    
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "¿Desea realizar una modificación del registro seleccionado?", "Confirmación",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                Agregar_Usuario f = new Agregar_Usuario();
                f.txtboxNombres.Text = dtvContactos.CurrentRow.Cells["Nombres"].Value.ToString();
                f.txtboxApellidos.Text = dtvContactos.CurrentRow.Cells["Apellidos"].Value.ToString();
                f.comboGenero.Text = dtvContactos.CurrentRow.Cells["Generos"].Value.ToString();
                f.msboxTelefono.Text = dtvContactos.CurrentRow.Cells["Telefono"].Value.ToString();
                f.ShowDialog();
                if (f.Procesar)
                {
                    try
                    {
                        dtvContactos.CurrentRow.Cells["Nombres"].Value = f.txtboxNombres.Text;
                        dtvContactos.CurrentRow.Cells["Apellidos"].Value = f.txtboxApellidos.Text;
                        dtvContactos.CurrentRow.Cells["Generos"].Value = f.comboGenero.Text;
                        dtvContactos.CurrentRow.Cells["Telefono"].Value = f.msboxTelefono.Text;

                        MessageBox.Show("Se ha realizado la modificación con exito ",
                            "Confirmado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtvContactos.Rows.Remove(dtvContactos.CurrentRow);
                MessageBox.Show("Se ha eliminado el registro con exito ",
                            "Confirmado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                GuardarXml();
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            ActualizarConteo();
        }
    }
}
