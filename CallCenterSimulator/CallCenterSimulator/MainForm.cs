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
        private Random categorySelector = new Random();
        private Random agentSelector = new Random();
        private Random durationSelector = new Random();

        private List<Categoria> categorias;
        private List<Agente> agentes;
        private List<Llamada> llamadasAtendidas;
        private Queue<Llamada> llamadas;
        private int callsCounter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            if (!(DevoulcionesCheckBox.Checked || EntregasCheckBox.Checked || ExportacionesCheckBox.Checked || AclaracionesCheckBox.Checked))
            if (!(Agente1CheckBox.Checked || Agente2CheckBox.Checked || Agente3CheckBox.Checked || Agente4CheckBox.Checked))
            {
                MessageBox.Show("Seleccione al menos una categoría y un agente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SimulateButton.Enabled = false;

            llamadas = new Queue<Llamada>();
            llamadasAtendidas = new List<Llamada>();

            categorias = new List<Categoria>();

            if (DevoulcionesCheckBox.Checked)
            {
                categorias.Add(new Categoria("Devoluciones", 1));
            }
            if (ExportacionesCheckBox.Checked)
            {
                categorias.Add(new Categoria("Exportaciones", 2));
            }
            if (EntregasCheckBox.Checked)
            {
                categorias.Add(new Categoria("Entregas", 1));
            }
            if (AclaracionesCheckBox.Checked)
            {
                categorias.Add(new Categoria("Aclaraciones", 1));
            }

            agentes = new List<Agente>();

            if (Agente1CheckBox.Checked)
            {
                agentes.Add(new Agente(1, 1));
            }
            if (Agente2CheckBox.Checked)
            {
                agentes.Add(new Agente(2, 1));
            }
            if (Agente3CheckBox.Checked)
            {
                agentes.Add(new Agente(3, 1));
            }
            if (Agente4CheckBox.Checked)
            {
                agentes.Add(new Agente(4, 2));
            }

            int totalLlamadas = (int)NumberOfCallsNum.Value;

            while (callsCounter <= totalLlamadas)
            {
                int index = categorySelector.Next(0, categorias.Count);
                var llamada = new Llamada(categorias[index], durationSelector.Next((int)DurationMinNum.Value, (int)DurationMaxNum.Value + 1));
                llamadas.Enqueue(llamada);
                AttendCall();
                callsCounter++;
            }
            SimulateButton.Enabled = true;
        }

        private void AttendCall()
        {
            var agentesLibres = agentes.Select(i => !i.Ocupado);
            if (agentesLibres.Count() > 0)
            {
                int index = agentSelector.Next(0, agentes.Count);
                agentesLibres.ToArray()[index] = llamadas.Dequeue();
            }
            else
            {
                AttendCall();
            }
            EndCall();
        }

        private void EndCall()
        {
            throw new NotImplementedException();
        }
    }
}
