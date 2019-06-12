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
       //     this.detalle = new List<AnalisisDetalle>();
        }

        private void ListadoAnalisis()
        {
            var listado = new List<TiposAnalisis>();

            listado = TiposAnalisisBLL.GetList(p => true);
            TipoAnalisiscomboBox.DataSource = listado;
            TipoAnalisiscomboBox.DisplayMember = "TipoAnalisis";
            TipoAnalisiscomboBox.ValueMember = "descripcion";
        }

        private void TipoAnalisisButton_Click(object sender, EventArgs e)
        {
            rTiposAnalisis ta = new rTiposAnalisis();
            ta.ShowDialog();
        }
        private Analisis LlenarClase()
        {
            Analisis analisis = new Analisis();

            analisis.AnalisisId = Convert.ToInt32(IdnumericUpDown.Value);
            
            /*
            producto.ProductoId = Convert.ToInt32(IdnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Existencia = Convert.ToInt32(ExistencianumericUpDown.Value);
            producto.Costo = Convert.ToInt32(CostonumericUpDown.Value);
            producto.ValorInventario = Convert.ToInt32(ValorInventarionumericUpDown.Value);
            producto.Detalles = this.detalle;
            //          producto.TipoPrecio = TIpoPreciotextBox.Text;
            //            producto.Precio = PrecionumericUpDown.Value;

            //  producto.Detalles = this.detalle;
            */
            return analisis;
        }

        private void Pacientebutton_Click(object sender, EventArgs e)
        {
            rPaciente rp = new rPaciente();
            rp.Show();
        }
    }
}
