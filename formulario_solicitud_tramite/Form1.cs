using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_solicitud_tramite
{
    public partial class Form1 : Form
    {
        List<Solicitud_tramite> tramites = new List<Solicitud_tramite>();

        string texto_anterior_numdoc = "";
        string texto_anterior_capavehi = "";
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(cbcoloresvehi.Items);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((tbnumdoc.Text == "")|(tbcapacidadvehi.Text == "")|(tbplaca.Text=="")|(cbtipovehi.Text==""))
            {
                MessageBox.Show("llenar como minimo tipo,placa,capacidad del vehiculo y documento de identificación");
                return;
            }
            Solicitud_tramite nuevotramite = new Solicitud_tramite();
            nuevotramite.fecha_tramite = Convert.ToString(dtpfecha.Value);
            nuevotramite.propietario.primer_apellido = tbprimapellido.Text;
            nuevotramite.propietario.segundo_apellido = tbsegunapellido.Text;
            nuevotramite.propietario.nombre = tbnombres.Text;
            nuevotramite.propietario.tipo_identificacion = cbtipodoc.Text;
            nuevotramite.propietario.num_documento = Convert.ToInt32(tbnumdoc.Text);
            nuevotramite.vehiculonuevo.placa = tbplaca.Text;
            nuevotramite.vehiculonuevo.Tipo_vehiculo = cbtipovehi.Text;
            nuevotramite.vehiculonuevo.Marca = tbmarcavehiculo.Text;
            nuevotramite.vehiculonuevo.combustible = cbcombusvehi.Text;
            nuevotramite.vehiculonuevo.color = cbcoloresvehi.Text;
            nuevotramite.vehiculonuevo.capacidad = Convert.ToDouble(tbcapacidadvehi.Text);
            tramites.Add(nuevotramite);
            MessageBox.Show("guardado");
        }

        private void tbnumdoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(tbnumdoc.Text == "")
                {
                    return;
                }
                Convert.ToInt32(tbnumdoc.Text);
                texto_anterior_numdoc = tbnumdoc.Text;
            }
            catch
            {   
                if (tbnumdoc.Text.Length == 1)
                {
                    tbnumdoc.Text = "";
                }
                else
                {
                    tbnumdoc.Text = texto_anterior_numdoc;
                }
                MessageBox.Show("sin letras o espacios");
            }
        }

        private void tbcapacidadvehi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbcapacidadvehi.Text == "")
                {
                    return;
                }
                Convert.ToDouble(tbcapacidadvehi.Text);
                texto_anterior_capavehi = tbcapacidadvehi.Text;
            }
            catch
            {
                if (tbcapacidadvehi.Text.Length == 1)
                {
                    tbcapacidadvehi.Text = "";
                }
                else
                {
                    tbcapacidadvehi.Text = texto_anterior_capavehi;
                }
                MessageBox.Show("sin letras o espacios");
            }
        }

        private void cbtipodoc_TextUpdate(object sender, EventArgs e)
        {
           // if (cbtipodoc.Text != cbtipodoc.Items)
        }
    }
}
