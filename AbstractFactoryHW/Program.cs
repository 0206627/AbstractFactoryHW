using System;
using AbstractFactoryHW.Enum;
using AbstractFactoryHW.Factory;

namespace AbstractFactoryHW
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] type = new string[3] { "Turbo", "Turbo Plus", "Touring" };
            float[] pricesCRV = new float[3] { (float)PricesCRV.Turbo, (float)PricesCRV.TurboPlus, (float)PricesCRV.Touring };
            float[] pricesCivic = new float[3] { (float)PricesCivic.Turbo, (float)PricesCivic.TurboPlus, (float)PricesCivic.Touring };
            int crv = 0;
            int civic = 0;
            float grandTotal = 0;
            float subTotal = 0;
            string grandResult = "";

            Console.WriteLine("¡Bienvenido a la concesionaria!");
            for (int i=0; i<3; i++)
            {
                do
                {
                    Console.WriteLine($"¿Cuántos CRV {type[i]} (${pricesCRV[i]})? (0-n)");
                    crv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"¿Cuántos Civic {type[i]} (${pricesCivic[i]})? (0-n)");
                    civic = Convert.ToInt32(Console.ReadLine());
                } while (!(crv >= 0 && civic >= 0));

                switch (i)
                {
                    case 0:
                        var car = new TurboFactory();
                        subTotal = car.crearCRV(crv);
                        grandResult += crv.ToString() + " CRV " + type[i] + " $" + subTotal.ToString() + "\n";
                        grandTotal += subTotal;
                        subTotal = car.crearCivic(civic);
                        grandResult += civic.ToString() + " Civic " + type[i] + " $" + subTotal.ToString() + "\n";
                        grandTotal += subTotal;
                        break;
                    case 1:
                        var car2 = new TurboPlusFactory();
                        subTotal = car2.crearCRV(crv);
                        grandResult += crv.ToString() + " CRV " + type[i] + " $" + subTotal.ToString() + "\n";
                        grandTotal += subTotal;
                        subTotal = car2.crearCivic(civic);
                        grandResult += civic.ToString() + " Civic " + type[i] + " $" + subTotal.ToString() + "\n";
                        grandTotal += subTotal;
                        break;
                    case 2:
                        var car3 = new TouringFactory();
                        subTotal = car3.crearCRV(crv);
                        grandResult += crv.ToString() + " CRV " + type[i] + " $" + subTotal.ToString() + "\n";
                        grandTotal += subTotal;
                        subTotal = car3.crearCivic(civic);
                        grandResult += civic.ToString() + " Civic " + type[i] + " $" + subTotal.ToString() + "\n";
                        grandTotal += subTotal;
                        break;
                }
            }
            Console.WriteLine("\n"+grandResult);
            Console.WriteLine($"Total: ${grandTotal}");
        }
    }
}
