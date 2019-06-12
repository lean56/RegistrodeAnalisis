using RegistrodeAnalisis.BLL;
using RegistrodeAnalisis.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrodeAnalisis.UI.Registro
{
    public partial class rPaciente : Form
    {
        public rPaciente()
        {
            InitializeComponent();
        }

        private Paciente LlenarClase()
        {
            Paciente paciente = new Paciente();

            paciente.PacienteId = (int)(IdnumericUpDown.Value);
            paciente.Nombres = NombretextBox.Text;
            paciente.Cedula = CedulatextBox.Text;
            paciente.Sexo = SexocomboBox.Text;
            paciente.Edad = (int)(EdadnumericUpDown.Value);
            paciente.Direccion = DirecciontextBox.Text;
     
            return paciente;
        }


        private void LlenaCampo(Paciente paciente)
        {
            IdnumericUpDown.Value = (int)paciente.PacienteId;
            NombretextBox.Text = paciente.Nombres;
            CedulatextBox.Text = paciente.Cedula;
            SexocomboBox.Text = paciente.Sexo;
            EdadnumericUpDown.Value = (int)paciente.Edad;
            DirecciontextBox.Text = paciente.Direccion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Paciente paciente = PacienteBLL.Buscar((int)IdnumericUpDown.Value);

            return (paciente != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombretextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombretextBox, "El campo Nombre no puede estar vacio");
                NombretextBox.Focus();
                paso = false;
            }

            if (CedulatextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CedulatextBox, "El campo Cedula no puede estar vacio");
                CedulatextBox.Focus();
                paso = false;
            }

            if (SexocomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(SexocomboBox, "El campo Sexo no puede estar vacio");
                SexocomboBox.Focus();
                paso = false;
            }

            if (EdadnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(EdadnumericUpDown, "Edad Invalido");
                EdadnumericUpDown.Focus();
                paso = false;
            }

            return paso;
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            CedulatextBox.Text = string.Empty;
            SexocomboBox.Text = string.Empty;
            EdadnumericUpDown.Value = 0;
            DirecciontextBox.Text = string.Empty;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Paciente paciente;

            bool paso = false;

            if (!Validar())
                return;

            paciente = LlenarClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso = PacienteBLL.Guardar(paciente);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un paciente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = PacienteBLL.Modificar(paciente);

                MessageBox.Show("Paciente Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Limpiar();

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
                MessageBox.Show("Error al Guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IdnumericUpDown.Text, out id);

            if (IdnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(IdnumericUpDown, "El campo ID no puede estar vacio");
                IdnumericUpDown.Focus();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Eliminar un Paciente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                if (PacienteBLL.Eliminar(id))
                {
                    MessageBox.Show("Paciente Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MyErrorProvider.SetError(IdnumericUpDown, "Id no Existe");

            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Paciente paciente = new Paciente();
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            paciente = PacienteBLL.Buscar(id);

            if (paciente != null)
            {
                MessageBox.Show("Paciente Encontrado");
                LlenaCampo(paciente);
            }
            else
            {
                MessageBox.Show("Paciente no Encontrado");
            }
        }
    }
}
