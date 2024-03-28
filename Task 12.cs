namespace C__classes
{
    abstract class GeneralSort
    {
        public void Swap(int i, int j, ref int[] arr)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    class InsertionS : GeneralSort
    {
        public int[] arr = { 4, 3, 5, 1, 7, 2 };
        public void ins_sort()
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 1 + i; j < arr.Length; j++)
                {
                    Swap(j - 1, j, ref arr);
                }
            }
            Console.WriteLine(arr);
        }

    }

    class SelectionS : GeneralSort
    {

    }

    class BubbleS : GeneralSort
    {

    }

    internal class Task_12
    {
        public int[] arr = { 1, 3, 5 };
    }
}
