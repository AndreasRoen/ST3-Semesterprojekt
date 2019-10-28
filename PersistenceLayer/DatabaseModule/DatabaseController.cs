using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule {
    class DatabaseController : IDatabaseController {
        public DatabaseController() {

        }

        public void SaveBatchReport(String batchReport)
        { 

            try
            {
                using (StreamWriter file = new StreamWriter("TextFile.txt"))
                {
                    file.Write(batchReport + Environment.NewLine);
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"The file was not found: '{e}'");
            }

        }
    }

}
