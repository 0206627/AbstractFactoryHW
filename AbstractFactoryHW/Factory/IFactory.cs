using System;
namespace AbstractFactoryHW.Factory
{
    public interface IFactory
    {
        float crearCRV(int qty);
        float crearCivic(int qty);
    }
}
