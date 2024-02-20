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
    public partial class Agregar_Usuario : Form
    {
        private Boolean _Procesar = false;

        public bool Procesar { get => _Procesar; set => _Procesar = value; }
        public Agregar_Usuario()
        {
            InitializeComponent();
        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _Procesar = true;
            Close();
        }

        private void txtboxApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void msboxTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
