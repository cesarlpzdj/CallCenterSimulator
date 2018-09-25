using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenterSimulator
{
    public partial class MainForm : Form
    {
        private Random categorySelector;
        private Random agentSelector;

        private Categoria[] categorias;

        private Agente[] agentes;

        private Queue<Llamada> llamadas;

        private List<Llamada> llamadasAtendidas;

        private int callsCounter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            llamadas = new Queue<Llamada>();
            llamadasAtendidas = new List<Llamada>();

            categorias = new Categoria[4];
            categorias[0] =
                new Categoria("Devoluciones", 1, DevoulcionesCheckBox.Checked);
            categorias[1] =
                new Categoria("Exportaciones", 2, ExportacionesCheckBox.Checked);
            categorias[2] =
                new Categoria("Entregas", 1, EntregasCheckBox.Enabled);
            categorias[3] =
                new Categoria("Aclaraciones", 1, AclaracionesCheckBox.Checked);

            agentes = new Agente[4];

            agentes[0] = new Agente(1, 1, Agente1CheckBox.Checked);
            agentes[1] = new Agente(2, 1, Agente2CheckBox.Checked);
            agentes[2] = new Agente(3, 1, Agente3CheckBox.Checked);
            agentes[3] = new Agente(4, 2, Agente4CheckBox.Checked);

            int totalLlamadas = (int)NumberOfCallsNum.Value;

            while (callsCounter <= totalLlamadas)
            {

            }
        }

        private void Call()
        {

        }

        private void AttendCall()
        {

        }
    }
}
