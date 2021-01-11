using System;
using MyClassLib;


namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTank=5;
            Random random = new Random();
            Tank[] tank = new Tank[countTank];
            Tank[] tankT34 = new Tank[countTank];
            Tank[] tankPantera = new Tank[countTank];
            for(int i = 0; i < tankT34.Length; i++)
            {
                tankT34[i] = new Tank("T-34",random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
            }
            for (int i = 0; i < tankPantera.Length; i++)
            {
                tankPantera[i] = new Tank("Pantera", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));

            }
            Console.WriteLine("Моделирование боя между танками: ");
            for (int i = 0; i < tank.Length; i++)
            {
                tank[i] = tankT34[i] * tankPantera[i];
                
                Console.WriteLine($"{ tankT34[i].GetTankName()}\t\t VS \t\t {tankPantera[i].GetTankName()}");
                Console.WriteLine($"Боекомплект -  {tankT34[i].GetAmmunitionLevel()}\t\t Боекомплект - {tankPantera[i].GetAmmunitionLevel()}");
                Console.WriteLine($"Уровень брони - {tankT34[i].GetArmorLevel()}\t\t Уровень брони - {tankPantera[i].GetArmorLevel()}");
                Console.WriteLine($"Уровень маневренности - {tankT34[i].GetLevelOfAgility()}\t Уровень маневренности - {tankPantera[i].GetLevelOfAgility()}");               
                Console.WriteLine($"В {i + 1} сватке победил танк {tank[i].GetTankName()}");                
                Console.WriteLine();
                Console.WriteLine();
                               
                
            }
            Console.ReadLine();


        }
    }
}
