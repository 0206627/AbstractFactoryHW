using System;
namespace AbstractFactoryHW.Models
{
    public class CivicCar : ICar
    {
        private float _price;

        public CivicCar(float price)
        {
            this._price = price;
        }

        public float getTotal(int qty)
        {
            return qty * this._price;
        }
    }
}
