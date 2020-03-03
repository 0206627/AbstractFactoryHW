using System;
using AbstractFactoryHW.Enum;
using AbstractFactoryHW.Models;

namespace AbstractFactoryHW.Factory
{
    public class TurboFactory : IFactory
    {
        public TurboFactory()
        {
        }

        public float crearCRV(int qty)
        {
            var crv = new CRVCar((float)PricesCRV.Turbo);
            return crv.getTotal(qty);
        }

        public float crearCivic(int qty)
        {
            var civic = new CivicCar((float)PricesCivic.Turbo);
            return civic.getTotal(qty);
        }
    }
}
