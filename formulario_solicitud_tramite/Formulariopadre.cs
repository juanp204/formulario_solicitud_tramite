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
    public partial class Formulariopadre : Form
    {
        private int childFormNumber = 0;

        public Formulariopadre()
        {
            InitializeComponent();
            Form1 formularioinicio = new Form1();
            formularioinicio.MdiParent = this;
            formularioinicio.Show();
        }

    }
}
