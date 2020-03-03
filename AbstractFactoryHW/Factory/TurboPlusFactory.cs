using System;
using AbstractFactoryHW.Enum;
using AbstractFactoryHW.Models;

namespace AbstractFactoryHW.Factory
{
    public class TurboPlusFactory : IFactory
    {
        public TurboPlusFactory()
        {
        }

        public float crearCRV(int qty)
        {
            var crv = new CRVCar((float)PricesCRV.TurboPlus);
            return crv.getTotal(qty);
        }

        public float crearCivic(int qty)
        {
            var civic = new CivicCar((float)PricesCivic.TurboPlus);
            return civic.getTotal(qty);
        }
    }
}
