namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 5, 1, 7, 2, 13, 8 };

            GeneralSort ob = new Insertion();
            ob.Sorting(ref arr);
            ob = new Selection();
            ob.Sorting(ref arr);
            ob = new Bubble();
            ob.Sorting(ref arr);
        }
    }

    abstract class GeneralSort
    {
        public void Sorting(ref int[] arr)
        {
            Sort(ref arr);
            printArr(arr);
        }
        protected void Swap(int i, int j, ref int[] arr)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        protected bool Cond(int i, int j)
        {
            if (i > j)
            {
                return true;
            } else
            {
                return false;
            }
        }
        protected void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        protected abstract void Sort(ref int[] arr);
    }

    class Insertion : GeneralSort
    {
        protected override void Sort(ref int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && Cond(arr[j - 1], arr[j]))
                {
                    Swap(j - 1, j, ref arr);
                    j--;
                }
            }
        }
    }

    class Selection : GeneralSort
    {
        protected override void Sort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = arr[i];
                int minindex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Cond(min, arr[j]))
                    {
                        min = arr[j];
                        minindex = j;
                    }
                }
                Swap(i,minindex, ref arr);
            }
        }
    }

    class Bubble : GeneralSort
    {
        protected override void Sort(ref int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (Cond(arr[j], arr[j + 1]))
                    {
                        Swap(j - 1, j, ref arr);
                    }
                }
            }
        }
    }
}
