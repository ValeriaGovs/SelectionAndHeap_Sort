using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionAndHeap_Sort
{
    class Sort
    {


        public static void HeapSort(int[] mass)
        {

            for (int root = mass.Length / 2 - 1; root >= 0; root--)
                heapify(root, mass.Length, mass);

            for (int j = mass.Length - 1; j > 0; j--)
            {
                swap(0, j, mass);
                heapify(0, j, mass);

            }

        }

        private static void heapify(int root, int size, int[] mass) // moveMaxToRoot
        {
            int L = 2 * root + 1;
            int R = 2 * root + 2;
            int X = root;
            if (L < size && mass[L] > mass[X]) X = L;
            if (R < size && mass[R] > mass[X]) X = R;
            if (X == root) return;
            swap(X, root, mass);
            heapify(X, size, mass);
        }



        public static void SelectionSort(int[] mass)
        {


            int indMax = FindMax(mass, mass.Length);
            for (int i = mass.Length - 1; i >= 0; i--)
            {
                swap(indMax, i, mass);
                indMax = FindMax(mass, i);
            }


        }

        private static void swap(int indMax, int i, int[] mass)
        {
            int k = mass[i];
            mass[i] = mass[indMax];
            mass[indMax] = k;
        }

        private static int FindMax(int[] mass, int j)
        {
            int max = 0;
            int ind_max = 0;
            for (int i = 0; i < j; i++)
            {
                if (mass[i] > max)
                {
                    ind_max = i;
                    max = mass[i];
                }
            }
            return ind_max;
        }
    }
}

