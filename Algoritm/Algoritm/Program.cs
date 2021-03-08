using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp49
{
    class Program
    {
        static void BubbleSort(List<int> minLista) //bubblesort algoritm
        {
            for (int i = 0; i < minLista.Count; i++)
            {
                for (int j = 0; j < minLista.Count - 1 - i; j++)
                {
                    if (minLista[j] > minLista[j + 1])
                    {
                        int temp = minLista[j];
                        minLista[j] = minLista[j + 1];
                        minLista[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort(List<int> minLista) //insertionsort algoritm
        {
            for (int i = 1; i < minLista.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (minLista[j] < minLista[j - 1])
                    {
                        int temp = minLista[j - 1];
                        minLista[j - 1] = minLista[j];
                        minLista[j] = temp;
                    }
                }
            }
        }

        static void SelectionSort(List<int> minLista) //seletionsort algoritm
        {
            for (int i = 0; i < minLista.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < minLista.Count; j++)
                    if (minLista[j] < minLista[min])
                        min = j;

                int temp = minLista[min];
                minLista[min] = minLista[i];
                minLista[i] = temp;
            }
        }

        static void Merge(List<int> minLista, int v, int m, int h) // mergesort algoritm första del
        {
            int i, j; 

            var n1 = m - v + 1;
            var n2 = h - m;

            var vänster = new int[n1];
            var höger = new int[n2];

            for (i = 0; i < n1; i++)
            {
                vänster[i] = minLista[v + i];
            }

            for(j = 0; j < n2; j++)
            {
                höger[j] = minLista[m + j + 1];
            }

            i = 0;
            j = 0;
            var k = v;

            while (i < n1 && j < n2)
            {
                if (vänster[i] <= höger[j])
                {
                    minLista[k] = vänster[i];
                    i++;
                }
                else
                {
                    minLista[k] = vänster[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                minLista[k] = vänster[i];
                i++;
                k++;
            }

            while (i < n2)
            {
                minLista[k] = höger[j];
                j++;
                k++;
            }
        }

        static void SortMerge(List<int> minLista, int v, int h) //mergesort algoritm andra del
        {
            if (v < h)
            {
                int m = v + (h - v) / 2;
                SortMerge(minLista, v, m);
                SortMerge(minLista, m + 1, h);

                Merge(minLista, v, m, h);
            }
        }

        static void QuickSort(List<int> minLista, int low, int high) //quicksort algoritm 
        {
            int pivot = minLista[(low + high) / 2];

            int lowHold = low;
            int highHold = high;

            while (lowHold < highHold)
            {
                while ((minLista[lowHold] < pivot) && (lowHold <= highHold)) lowHold++;

                while ((minLista[highHold] > pivot) && (highHold >= lowHold)) highHold--;

                if (lowHold < highHold)
                {
                    int temp = minLista[lowHold];
                    minLista[lowHold] = minLista[highHold];
                    minLista[highHold] = temp;

                    if (minLista[lowHold] == pivot && minLista[highHold] == pivot)
                        lowHold++;
                }
            }

            if (low < lowHold - 1) QuickSort(minLista, low, lowHold - 1);
            if (high > highHold + 1) QuickSort(minLista, highHold + 1, high);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tal?"); //input med antal tal
            int tal = Convert.ToInt32(Console.ReadLine());

            var tallista = new List<int>();
            Random slump = new Random(); //skapa slumpad tallista

            for (int i = 0; i < tal; i++)
            {
                tallista.Add(slump.Next(tal)); //lägg till antal tal
            }

            var tid0 = Stopwatch.StartNew(); // total tid start

            Console.WriteLine("\nBubbleSort: "); // bubblesort med tid och utskrivning
            var tid = Stopwatch.StartNew();
            BubbleSort(tallista);
            tid.Stop();
            TimeSpan timespan = tid.Elapsed;

            Console.WriteLine("Tid: {0}m {1}s {2}ms", timespan.Minutes, timespan.Seconds, timespan.Milliseconds);

 
            Console.WriteLine("\nInsertionSort: "); // insertionsort med tid och utrskrivning
            var tid2 = Stopwatch.StartNew();
            InsertionSort(tallista);
            tid2.Stop();
            TimeSpan timespan2 = tid2.Elapsed;
                  
            Console.WriteLine("Tid: {0}m {1}s {2}ms", timespan2.Minutes, timespan2.Seconds, timespan2.Milliseconds);
 

            Console.WriteLine("\nSelectionSort: "); // selectionsort med tid och utskrivning
            var tid3 = Stopwatch.StartNew();
            SelectionSort(tallista);
            tid3.Stop();
            TimeSpan timespan3 = tid3.Elapsed;

            Console.WriteLine("Tid: {0}m {1}s {2}ms", timespan3.Minutes, timespan3.Seconds, timespan3.Milliseconds);


            Console.WriteLine("\nMergeSort: "); // mergesort med tid och utskrivning
            var tid4 = Stopwatch.StartNew();
            SortMerge(tallista, 0, tallista.Count - 1);
            tid4.Stop();
            TimeSpan timespan4 = tid4.Elapsed;

            Console.WriteLine("Tid: {0}m {1}s {2}ms", timespan4.Minutes, timespan4.Seconds, timespan4.Milliseconds);


            Console.WriteLine("\nQuickSort: "); // quicksort med tid och utskrivning
            var tid5 = Stopwatch.StartNew();
            QuickSort(tallista, 0, tallista.Count - 1);
            tid5.Stop();
            TimeSpan timespan5 = tid5.Elapsed;

            Console.WriteLine("Tid: {0}m {1}s {2}ms", timespan5.Minutes, timespan5.Seconds, timespan5.Milliseconds);

            tid0.Stop();    //total tid output
            TimeSpan timespan0 = tid0.Elapsed;

            Console.WriteLine("\nTotal Tid: {0}m {1}s {2}ms", timespan0.Minutes, timespan0.Seconds, timespan0.Milliseconds);
        }
    }
}