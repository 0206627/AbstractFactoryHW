using System;
namespace AbstractFactoryHW.Models
{
    public class CRVCar : ICar
    {
        private float _price;

        public CRVCar(float price)
        {
            this._price = price;
        }

        public float getTotal(int qty)
        {
            return qty * this._price;
        }
    }
}
