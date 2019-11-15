using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.DTOClasses
{
    /// <summary>
    /// Data object created in the persistence layer
    /// </summary>
    public class LiveRelevantDataDO
    {
        public float Temperature { get; }
        public float Humidity { get; }
        public float Vibration { get; }
        public ushort BatchID { get; set; }
        public ushort BatchSize { get; set; }
        public float ActualMachineSpeed { get; }
        public ushort ProducedProducts { get; }
        public ushort AcceptableProducts { get; set; }
        public ushort DefectProducts { get; }
        public float Barley { get; }
        public float Hops { get; }
        public float Malt { get; }
        public float Wheat { get; }
        public float Yeast { get; }
        public ushort MaintainenceMeter { get; }
        public int CurrentState { get; }

        public LiveRelevantDataDO(float temperature, float humidity, float vibration, float actualMachineSpeed, ushort producedProducts, ushort defectProducts, float barley, float hops, float malt, float wheat, float yeast, ushort maintainenceMeter, int currentState)
        {
            Temperature = temperature;
            Humidity = humidity;
            Vibration = vibration;
            ActualMachineSpeed = actualMachineSpeed;
            ProducedProducts = producedProducts;
            DefectProducts = defectProducts;
            Barley = barley;
            Hops = hops;
            Malt = malt;
            Wheat = wheat;
            Yeast = yeast;
            MaintainenceMeter = maintainenceMeter;
            CurrentState = currentState;
        }



        //values.Add(machineReadData.ReadTemperature(accessPoint));
        //values.Add(machineReadData.ReadHumidity(accessPoint));
        //values.Add(machineReadData.ReadVibration(accessPoint));
        //values.Add(0); //batch id 
        //values.Add(0); // batch size
        //values.Add(machineReadData.ReadActualMachineSpeed(accessPoint));
        //values.Add(machineReadData.ReadProducedProducts(accessPoint));
        //values.Add(0); //acceptable products
        //values.Add(machineReadData.ReadDefectProducts(accessPoint));
        //values.Add(machineReadData.ReadBarleyAmount(accessPoint));
        //values.Add(machineReadData.ReadHopsAmount(accessPoint));
        //values.Add(machineReadData.ReadMaltAmount(accessPoint));
        //values.Add(machineReadData.ReadWheatAmount(accessPoint));
        //values.Add(machineReadData.ReadYeastAmount(accessPoint));
        //values.Add(machineReadData.ReadMaintenanceCounter(accessPoint));
        //values.Add(machineReadData.ReadCurrentState(accessPoint));

    }
}
