using System;
using AbstractFactoryHW.Enum;
using AbstractFactoryHW.Models;

namespace AbstractFactoryHW.Factory
{
    public class TouringFactory
    {
        public TouringFactory()
        {
        }

        public float crearCRV(int qty)
        {
            var crv = new CRVCar((float)PricesCRV.Touring);
            return crv.getTotal(qty);
        }

        public float crearCivic(int qty)
        {
            var civic = new CivicCar((float)PricesCivic.Touring);
            return civic.getTotal(qty);
        }
    }
}
