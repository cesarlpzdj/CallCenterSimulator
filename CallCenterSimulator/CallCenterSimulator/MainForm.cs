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
        private Categoria[] categorias = 
        {
            new Categoria("Devoluciones", 1),
            new Categoria("Exportaciones", 2),
            new Categoria("Entregas", 1),
            new Categoria("Aclaraciones", 1)
        };

        private Agente[] agentes =
        {
            new Agente(1, 1),
            new Agente(2, 1),
            new Agente(3, 1),
            new Agente(4, 2)
        };

        private Queue<Llamada> llamadas;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            llamadas = new Queue<Llamada>();
        }

        private void Call()
        {

            var llamada = new Llamada()
            llamadas.Enqueue(llamada);
        }

        private void AttendCall()
        {

        }
    }
}
