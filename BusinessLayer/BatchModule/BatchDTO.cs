namespace BeerProductionSystem.BusinessLayer.BatchModule {
    class BatchDTO {

        public ushort ProductType { get; set; }
        public ushort BatchID { get; set; }
        public ushort BatchSize { get; set; }
        public float ProductionSpeed { get; set; }

        public BatchDTO(ushort productType, ushort batchID, ushort batchSize, float productionSpeed)
        {
            ProductType = productType;
            BatchID = batchID;
            BatchSize = batchSize;
            ProductionSpeed = productionSpeed;
        }
        public BatchDTO() : this(0,0,0,0) {}
    }
}
