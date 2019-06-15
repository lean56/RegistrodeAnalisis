using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistrodeAnalisis.BLL;
using RegistrodeAnalisis.Entidades;
using RegistrodeAnalisis.UI.Registro;

namespace RegistrodeAnalisis.UI.Registro
{
    public partial class rAnalisis : Form
    {
        public List<AnalisisDetalle> detalle { get; set; }

        public rAnalisis()
        {
            InitializeComponent();
            ListadoAnalisis();
            ListadoPaciente();
            this.detalle = new List<AnalisisDetalle>();
        }

        private void ListadoAnalisis()
        {
            var listado = new List<TiposAnalisis>();

            listado = TiposAnalisisBLL.GetList(p => true);
            TipoAnalisiscomboBox.DataSource = listado;
            TipoAnalisiscomboBox.DisplayMember = "TipoAnalisis";
            TipoAnalisiscomboBox.ValueMember = "descripcion";
        }

        private void ListadoPaciente()
        {
            var listado = new List<Paciente>();

           
            listado = PacienteBLL.GetList(p => true);
            PacientecomboBox.DataSource = listado;
            PacientecomboBox.DisplayMember = "Paciente";
            PacientecomboBox.ValueMember = "PacienteId";
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0; 
            FechadateTimePicker.Value = DateTime.Now;
            PacientecomboBox.SelectedIndex = 0;
            TipoAnalisiscomboBox.SelectedIndex = 0;
            ResultadotextBox.Text = string.Empty;
           
            this.detalle = new List<AnalisisDetalle>();
            //CargarGrid();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if(ResultadotextBox.Text ==string.Empty)
            {
                MyErrorProvider.SetError(ResultadotextBox, "El campo Resultado no puede estar vacio");
                ResultadotextBox.Focus();
                paso = false;
            }

            if (this.detalle.Count == 0)
            {
                MyErrorProvider.SetError(DetallesdataGridView, "debe agregar Tipo de analisis");
                TipoAnalisiscomboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void TipoAnalisisButton_Click(object sender, EventArgs e)
        {
            rTiposAnalisis ta = new rTiposAnalisis();
            ta.Show();
            ListadoAnalisis();
        }
        private Analisis LlenarClase()
        {
            Analisis analisis = new Analisis();

            analisis.AnalisisId = Convert.ToInt32(IdnumericUpDown.Value);
            analisis.PacienteId = (int)PacientecomboBox.SelectedValue;
            analisis.Fecha = FechadateTimePicker.Value;
            
            analisis.DetallesAnalisis = this.detalle;
    
            return analisis;
        }

        private void CargarGrid()
        {
            DetallesdataGridView.DataSource = null;
            DetallesdataGridView.DataSource = this.detalle;
        }

        private void LlenaCampo(Analisis analisis)
        {
            IdnumericUpDown.Value = analisis.AnalisisId;
            PacientecomboBox.SelectedValue = analisis.PacienteId;
            FechadateTimePicker.Value = analisis.Fecha;

            this.detalle = analisis.DetallesAnalisis;
            CargarGrid();
        }

        private void Pacientebutton_Click(object sender, EventArgs e)
        {
            if (DetallesdataGridView.DataSource != null)
                this.detalle = (List<AnalisisDetalle>)DetallesdataGridView.DataSource;

            this.detalle.Add(
          new AnalisisDetalle(
              id: 0,
              analisisId: (int)IdnumericUpDown.Value,
              tipoAnalisis: TipoAnalisiscomboBox.Text,
              resultado: ResultadotextBox.Text
              )
              );
              CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Analisis analisis = AnalisisBLL.Buscar((int)IdnumericUpDown.Value);

            return (analisis != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Analisis analisis;
            bool paso = false;

            if (!Validar())
                return;

            analisis = LlenarClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso = AnalisisBLL.Guardar(analisis);
                Limpiar();
            }

            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
     
                {
                    paso = AnalisisBLL.Modificar(analisis);
                    MessageBox.Show("Analisis Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
  
            }

            if (paso) 
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }

            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

        private void BuscarButton_Click(object sender, EventArgs e)
        {


            int id;
            Analisis analisis = new Analisis();
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            analisis = AnalisisBLL.Buscar(id);

            if (analisis != null)
            {
                MessageBox.Show("Analisis Encontrado");
                LlenaCampo(analisis);
            }
            else
            {
                MessageBox.Show("Analisis no Encontrado");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();
            if (AnalisisBLL.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                MyErrorProvider.SetError(IdnumericUpDown, "No se puede eliminar una persona que no existe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rPaciente rp = new rPaciente();
            rp.Show();
            ListadoPaciente();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            detalle.RemoveAt(DetallesdataGridView.CurrentRow.Index);
            CargarGrid();
        }
    }
}
