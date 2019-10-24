namespace BeerProductionSystem.BusinessLayer.BatchModule {
    class BatchModel {

        public ushort ProductType { get; set; }
        public ushort BatchID { get; set; }
        public ushort BatchSize { get; set; }
        public float ProductionSpeed { get; set; }

        public BatchModel(ushort productType, ushort batchID, ushort batchSize, float productionSpeed) {
            ProductType = productType;
            BatchID = batchID;
            BatchSize = batchSize;
            ProductionSpeed = productionSpeed;

        }
    }
}
