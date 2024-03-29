namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 5, 1, 7, 2, 13, 8, 25, 15, 17 };

            GeneralSort ob = new Insertion();
            ob.Sort(ref arr);
            ob = new Selection();
            ob.Sort(ref arr);
            ob = new Bubble();
            ob.Sort(ref arr);
        }
    }

    abstract class GeneralSort
    {
        public void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        protected int j = 1;
        public void Sort(ref int[] arr) 
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int min = arr[i - 1];
                int minindex = i - 1;
                int k = 0;
                for (j = jdef(i); Cond1(j, arr, ref k) && Cond2(k, arr[j]); Jchanger(ref j))
                {
                    try { k = arr[j + 1];} catch { k = 0;}
                    if (Cond(arr[j], k, min))
                    {
                        min = arr[j];
                        minindex = j;
                        Swap1(j - 1, j, ref arr);
                    }
                }
                Swap2(i - 1, minindex, ref arr);
            }
            printArr(arr);
        }
        protected abstract int jdef(int i);
        protected abstract bool Cond(int i, int j, int k);
        protected abstract bool Cond1(int j, int[] arr, ref int k);
        protected abstract bool Cond2(int i, int j);
        protected abstract void Jchanger(ref int j);
        protected abstract void Swap1(int i, int j, ref int[] arr);
        protected abstract void Swap2(int i, int j, ref int[] arr);
    }

    class Insertion : GeneralSort
    {
        protected override int jdef(int i)
        {
            return i;
        }
        protected override bool Cond1(int j, int[] arr, ref int k)
        {
            try { k = arr[j - 1]; } catch { k = 0; }
            if (j > 0)
            {
                return true;
            } else 
            {
                return false; 
            }
        }
        protected override void Jchanger(ref int j)
        {
            j--;
        }
        protected override bool Cond2(int i, int j)
        {
            if (i > j)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected override bool Cond(int fB1, int fB2, int k)
        {
            return true;
        }
        protected override void Swap1(int fI1, int fI2, ref int[] arr)
        {
            int temp = arr[fI1];
            arr[fI1] = arr[fI2];
            arr[fI2] = temp;
        }
        protected override void Swap2(int fI1, int fI2, ref int[] arr)
        {
            return;
        }
    }

    class Selection : GeneralSort
    {
        protected override int jdef(int i)
        {
            return i;
        }
        protected override bool Cond1(int j, int[] arr, ref int k)
        {
            try { k = arr[j - 1]; } catch { k = 0; }
            if (j < arr.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected override bool Cond2(int i, int j)
        {
            return true;
        }
        protected override void Jchanger(ref int j)
        {
            j++;
        }
        protected override bool Cond(int fS2, int k, int fS1)
        {
            if (fS1 > fS2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected override void Swap1(int fI1, int fI2, ref int[] arr)
        {
            return;
        }
        protected override void Swap2(int fI1, int fI2, ref int[] arr)
        {
            int temp = arr[fI1];
            arr[fI1] = arr[fI2];
            arr[fI2] = temp;
        }
    }

    class Bubble : GeneralSort
    {
        protected override int jdef(int i)
        {
            return 0;
        }
        protected override bool Cond1(int j, int[] arr, ref int k)
        {
            try { k = arr[j - 1]; } catch { k = 0; }
            if (j < arr.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected override bool Cond2(int i, int j)
        {
            return true;
        }
        protected override void Jchanger(ref int j)
        {
            j++;
        }
        protected override bool Cond(int fB1, int fB2, int k)
        {
            if (fB1 > fB2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected override void Swap1(int fI1, int fI2, ref int[] arr)
        {
            int temp = arr[fI1];
            arr[fI1] = arr[fI2];
            arr[fI2] = temp;
        }
        protected override void Swap2(int fI1, int fI2, ref int[] arr)
        {
            return;
        }
    }
}
