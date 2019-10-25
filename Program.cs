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
            //string serverURL = "opc.tcp://192.168.0.122:4840";  //Physical PLC
            string serverURL = "opc.tcp://127.0.0.1:4840";      //Simulated PLC

            using (accessPoint = new OpcClient(serverURL))
            {
                //Connect to server
                accessPoint.Connect();

                //IMachineReadData read = new MachineReadData();
                IMachineWriteData write = new MachineWriteData();
                System.Threading.Thread.Sleep(1000);

                //Debug.WriteLine(read.ReadBatchID(accessPoint));
                //ushort i = 1;
                write.WriteNextBatchID(accessPoint, 1);
                write.WriteNextBatchProductType(accessPoint, 0);
                write.WriteNextBatchSize(accessPoint, 30000);
                write.WriteDesiredMachineSpeed(accessPoint, 600);

                //write.WriteControlCommand(accessPoint, 1);    //Reset
                //write.WriteControlCommand(accessPoint, 2);    //Start
                //write.WriteControlCommand(accessPoint, 3);    //Stop
                //write.WriteControlCommand(accessPoint, 4);    //Abort
                //write.WriteControlCommand(accessPoint, 5);    //Clear


            }


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

        }
    }
}
