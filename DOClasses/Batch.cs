namespace BeerProductionSystem.DOClasses
{
    class Batch
    {
        public float ProductType { get; set; }
        public ushort BatchID { get; set; }
        public ushort BatchSize { get; set; }
        public float ProductionSpeed { get; set; }

        public Batch(float productType, ushort batchID, ushort batchSize, float productionSpeed)
        {
            ProductType = productType;
            BatchID = batchID;
            BatchSize = batchSize;
            ProductionSpeed = productionSpeed;
        }
    }
}
