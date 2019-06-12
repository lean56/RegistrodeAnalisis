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
    public partial class rTiposAnalisis : Form
    {
        public rTiposAnalisis()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private TiposAnalisis LlenarClase()
        {
            TiposAnalisis tiposAnalisis = new TiposAnalisis();

            tiposAnalisis.TipoId = Convert.ToInt32(IDnumericUpDown.Value);
            tiposAnalisis.Descripcion = DescripciontextBox.Text;

            return tiposAnalisis;
        }

        private void LlenaCampo(TiposAnalisis tiposAnalisis)
        {
            IDnumericUpDown.Value = tiposAnalisis.TipoId;
            DescripciontextBox.Text = tiposAnalisis.Descripcion;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            try
            {
                if (TiposAnalisisBLL.Duplicado(DescripciontextBox.Text))
                {
                    paso = false;
                    MyErrorProvider.SetError(DescripciontextBox, "La descripcion ya esta registrada");
                }
            }
            catch (Exception)
            {
                throw;
            }

            if (DescripciontextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripciontextBox, "El campo Descripcion no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            return paso;
        }


        private bool ExisteEnLaBaseDeDatos()
        {
            TiposAnalisis tiposAnalisis = TiposAnalisisBLL.Buscar((int)IDnumericUpDown.Value);

            return (tiposAnalisis != null);
        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            TiposAnalisis tiposAnalisis;

            bool paso = false;

            if (!Validar())
                return;

            tiposAnalisis = LlenarClase();


            if (IDnumericUpDown.Value == 0)
            {
                paso = TiposAnalisisBLL.Guardar(tiposAnalisis);
            }

            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una ubicacion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = TiposAnalisisBLL.Modificar(tiposAnalisis);

                MessageBox.Show("Ubicacion Modificada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Limpiar();

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error al Guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            if (IDnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(IDnumericUpDown, "El campo ID no puede estar vacio");
                IDnumericUpDown.Focus();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Eliminar un Analisi que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                if (TiposAnalisisBLL.Eliminar(id))
                {
                    MessageBox.Show("Analisi Eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MyErrorProvider.SetError(IDnumericUpDown, "Id no Existe");

            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            TiposAnalisis tiposAnalisis = new TiposAnalisis();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            tiposAnalisis = TiposAnalisisBLL.Buscar(id);

            if (tiposAnalisis != null)
            {
                MessageBox.Show("Analisis Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(tiposAnalisis);
            }
            else
            {
                MessageBox.Show("Analisis no Encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
