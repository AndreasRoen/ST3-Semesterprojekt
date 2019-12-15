using System.Windows.Forms;

namespace BeerProductionSystem.PresentationLayer
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartupConnection sc = new StartupConnection();
            Application.Run(sc);
        }
    }
}
