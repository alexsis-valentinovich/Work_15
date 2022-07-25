using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

//метод void SetStart(int x) -устанавливает начальное значение
//метод int GetNext() -возвращает следующее число ряда
//метод void Reset() -выполняет сброс к начальному значению
//Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
//В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии
//соответственно.
namespace Rart_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ариметическая: начальная установка");
            Console.Write("Ввeдите начальное значение = ");
            int startPointA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввeдите шаг = ");
            int stepA = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithPro = new ArithProgression();
            arithPro.SetStart(startPointA);
            arithPro.setStep(stepA);
            Console.WriteLine(startPointA);
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            arithPro.Reset();
            Console.WriteLine("Ариметическая: сброс");
            Console.WriteLine(startPointA);
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine(arithPro.GetNext());
            Console.WriteLine();
            GeomProgression geomPro = new GeomProgression();
            Console.WriteLine("Геометрическая: начальная установка");
            Console.Write("Ввeдите начальное значение = ");
            int startPointG = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввeдите шаг = ");
            int stepG = Convert.ToInt32(Console.ReadLine());
            geomPro.SetStart(startPointG);
            geomPro.setStep(stepG);
            Console.WriteLine(startPointG);
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            
            geomPro.Reset();
            Console.WriteLine("Геометрическая: сброс");
            Console.WriteLine(startPointG);
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            Console.WriteLine(geomPro.GetNext());
            Console.ReadKey();
        }
    }
}
