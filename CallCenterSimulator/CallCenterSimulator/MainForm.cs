using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        private List<Agente> llamadasAtendidas;
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
            llamadasAtendidas = new List<Agente>();

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
                callsCounter++;
            }
            worker.RunWorkerAsync();
            SimulateButton.Enabled = true;
        }

        private void AttendEnqueuedCalls()
        {
            while (llamadas.Count > 0)
            {
                int index = 0;
                do
                {
                    index = agentSelector.Next(0, agentes.Count);
                } while (agentes[index].Ocupado);

                agentes[index].Llamada = llamadas.Dequeue();
                agentes[index].Ocupado = true;
                llamadasAtendidas.Add(agentes[index]);

                EndCall(agentes[index]);
            }
        }

        private void EndCall(Agente agente)
        {
            agente.Ocupado = false;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            AttendEnqueuedCalls();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Simulación terminada. ¿Desea ver los datos?", 
                    "Mensaje del sistema", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Simulation-{DateTime.Now.Date.ToString("yyyy-MM-dd")}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.txt");
                using (var writer = new StreamWriter(path, false))
                {
                    int linea = 1;
                    writer.WriteLine("Simulador de Call Center");
                    writer.WriteLine("No\t\tCategoría\t\tDuración\tAtendido por\t\tNivel");
                    foreach (var agente in llamadasAtendidas)
                    {
                        writer.WriteLine($"{linea}\t\t{agente.Llamada.Categoria.Nombre}\t\t{agente.Llamada.Duracion}\t\tAgente {agente.Id}\t\t{agente.Nivel}");
                        linea++;
                    }
                }
                MessageBox.Show("Archivo generado con éxito en el escritorio.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(path);
            }
            callsCounter = 0;
        }
    }
}
