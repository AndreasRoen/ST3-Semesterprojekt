
using Opc.UaFx.Client;

namespace BeerProductionSystem.PersistenceLayer.MachineModule
{
    interface IMachineWriteData
    {
        void WriteDesiredMachineSpeed(OpcClient accessPoint, float speed);

        void WriteControlCommand(OpcClient accessPoint, int commandValue);

        void WriteCommandChangeRequest(OpcClient accessPoint);

        void WriteNextBatchID(OpcClient accessPoint, ushort batchID);

        void WriteNextBatchProductType(OpcClient accessPoint, ushort productTypeValue);

        void WriteNextBatchSize(OpcClient accessPoint, ushort batchSize);
    }
}
