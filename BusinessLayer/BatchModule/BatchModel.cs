namespace BeerProductionSystem.BusinessLayer.BatchModule {
    class BatchModel {

        private ushort productType;
        private ushort batchID;
        private ushort batchSize;
        private float productionSpeed;

        public ushort ProductType { get => productType; set => productType = value; }
        public ushort BatchID { get => batchID; set => batchID = value; }
        public ushort BatchSize { get => batchSize; set => batchSize = value; }
        public float ProductionSpeed { get => productionSpeed; set => productionSpeed = value; }

        public BatchModel(ushort productType, ushort batchID, ushort batchSize, float productionSpeed) {
            this.productType = productType;
            this.batchID = batchID;
            this.batchSize = batchSize;
            this.productionSpeed = productionSpeed;

        }
    }
}
