using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace firstBiggestInRightNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\solutionsForSpaceApp\\2026\\input.txt";
            string outputpath = "D:\\solutionsForSpaceApp\\2026\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива#1
            double a;
            using (var readera = new StreamReader(inputpath))
            {
                a = Convert.ToInt32(readera.ReadLine());  // записываем в переменную
            };
            //запись в строку содержимого 2 строки файла
            string secondLine;
            using (var readersecond = new StreamReader(inputpath))
            {
                readersecond.ReadLine(); //пропуск 1 строки
                secondLine = readersecond.ReadLine();  // записываем в переменную
            }

            //запись из строки в массив строк с разделением
            string[] secondlineforint = secondLine.Split(' ');

            List<int> A = new List<int>();
            int[] B;
            B = new int[Convert.ToInt32(a)];

            int index;
            int counter = 0;
            foreach(var s in secondlineforint)
            {
                A.Add(Convert.ToInt32(s));
            }

            
            for (int i = 0; i < A.Count-1; i++)
            {
                index = i;
                for (int j = index; j < A.Count; j++)
                {
                    if (A[i] < A[j])
                    {
                        A[i] = A[j];
                        B[i] = A[i];
                        break;
                    }
                    else
                    {
                        B[i] = 0;
                    }
                }
                
            }
            string outputstring = "";
            for (int k =0; k<B.Length;k++)
            {
                outputstring = outputstring + B[k] + ' ';
            }
            File.WriteAllText(outputpath, outputstring);

        }
    }
}
