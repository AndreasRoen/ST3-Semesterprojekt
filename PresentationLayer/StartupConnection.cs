using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerProductionSystem.PresentationLayer
{
    public partial class StartupConnection : Form
    {
        private ILogicFacade logicFacade;
        private string machine;

        public StartupConnection()
        {
            InitializeComponent();
            logicFacade = new LogicFacade();
            machine = rbSimulation.Text;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (logicFacade.ConnectToMachine(machine))
            {
                UI ui = new UI(logicFacade);
                this.Hide();
                ui.Show();
            }
            else
            {
                labelConnectionFailed.Visible = true;
            }
        }

        private void RB_Click(object sender, MouseEventArgs e)
        {
            machine = rbPhysical.Checked ? rbPhysical.Text : rbSimulation.Text;
        }
    }
}
