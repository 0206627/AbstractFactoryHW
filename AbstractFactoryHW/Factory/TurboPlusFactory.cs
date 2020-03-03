using System;
using AbstractFactoryHW.Enum;
using AbstractFactoryHW.Models;

namespace AbstractFactoryHW.Factory
{
    public class TurboPlus : IFactory
    {
        public TurboPlus()
        {
        }

        public float crearCivic(int qty)
        {
            var crv = new CRVCar((float)PricesCRV.TurboPlus);
            return crv.getTotal(qty);
        }

        public float crearCRV(int qty)
        {
            var civic = new CivicCar((float)PricesCivic.TurboPlus);
            return civic.getTotal(qty);
        }
    }
}
