using BeerProductionSystem.PersistenceLayer.MachineModule;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BeerProductionSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Debug.WriteLine("Test test");

            OpcClient accessPoint;
            using (accessPoint = new OpcClient("opc.tcp://127.0.0.1:4840"))
            {
                //Connect to server
                accessPoint.Connect();

                IMachineWriteData write = new MachineWriteData();
                Random rnd = new Random();
                while (true)
                {
                    //int num = Debug.ReadLine();
                    //int i = rnd.Next(1, 6);
                    //System.Threading.Thread.Sleep(1000); //Hang out for half a second (testing)
                    write.WriteCommand(accessPoint, 3);
                    //write.WriteCommandChangeRequest();
                    //System.Threading.Thread.Sleep(1000); //Hang out for half a second (testing)
                    //write.WriteCommand(2);
                    //write.WriteCommandChangeRequest();
                    //write.WriteDesiredMachineSpeed(i);

                }
                //write.WriteDesiredMachineSpeed(100);

            }


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

        }
    }
}
