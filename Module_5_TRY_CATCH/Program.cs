
/*Тема: Обработка исключений*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace Module_5_TRY_CATCH
{
    class Program
    {

        /*1. Перехватить исключение запроса к несуществующему веб ресурсу и вывести 
        сообщение о том, что произошла ошибка. Программа должна завершиться без ошибок.*/
        #region 
        static void Main(string[] args)
        {
            string URL = "SvetloeBudushee.kz";
            string UserURL = "";
            int temp = 10;

            Console.Write("\n\tExemple: https:SvetloeBudushee.kz\n\thttps:");
            try
            {
                UserURL = Console.ReadLine();
                if (URL != UserURL)
                {
                    Console.Clear();
                    throw new Exception("\n\t404 server not found!");
                }
                else
                {
                    Console.Write("\n\tConnection");
                    for (int i = 0; i < temp; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(500);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
        #endregion

        /*2. Написать программу, которая обращается к элементам массива по индексу и 
      выходит за его пределы. После обработки исключения вывести в финальном блоке 
      сообщение о завершении обработки массива.*/
        #region
        //static void Main(string[] args)
        //{
        //    int[] a = new int[4];

        //    Console.WriteLine("\n\tВывод элементов массива на экран:");
        //    try
        //    {
        //        for (int i = 0; i < a.Length + 1; i++)
        //        {
        //            a[i] = i;
        //            Console.WriteLine("\tnums[{0}]: {1}", i, a[i]);
        //            Thread.Sleep(500);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("\n\tОшибка: " + ex.Message);
        //    }

        //    Console.ReadLine();
        //}
        #endregion

        /*3. Реализовать несколько методов или классов с методами и вызвать один
      метод из другого. В вызываемом методе сгенерировать исключение и «поднять» 
      его в вызывающий метод. */
        #region
        //static List<int> ArraysDivide(List<int> A, List<int> B)
        //{
        //    List<int> result = new List<int>();

        //    for (int i = 0; i < A.Capacity; i++)
        //    {
        //        try
        //        {
        //            Console.WriteLine("\n\t" + A[i] + " / " + B[i] + " равно " + A[i] / B[i]);
        //            Thread.Sleep(500);
        //        }
        //        catch (DivideByZeroException)
        //        {
        //            Console.WriteLine("\n\tДелить на нуль нельзя!");
        //        }
        //        result.Add(A[i] / B[i]);
        //    }
        //    return result;
        //}

        //static void PrintResult(List<int> A, List<int> B)
        //{
        //    List<int> listForPrint; // = new List<int>();
        //    listForPrint = ArraysDivide(A, B);

        //    foreach (int item in listForPrint)
        //    {
        //        Console.WriteLine("\n\tРезультат деления: {0}");
        //        Thread.Sleep(500);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    List<int> list1 = new List<int>() { 2, 4, 8, 10, 12, 16 };
        //    List<int> list2 = new List<int>() { 1, 2, 4, 5, 6, 0 };

        //    PrintResult(list1, list2);
        //    Console.ReadLine();
        //}
        #endregion

    }

}
