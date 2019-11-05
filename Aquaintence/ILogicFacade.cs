using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.Aquaintence
{
    public interface ILogicFacade
    {
        string UpdateData();

        void setSpeed(float speed);

        void setSize(ushort size);

        void setProductType(ushort productID);
    }
}
