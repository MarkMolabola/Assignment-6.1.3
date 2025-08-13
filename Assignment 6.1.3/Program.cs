namespace Assignment_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 0, 1, 2, 0,3, 4, 5, 0,6, 7, 8, 9,0, 10, 0 };
            MoveTheZeros(ints);



        }
        static void MoveTheZeros(int[] ints)
        {
            //for (int i = 0, j = ints.Length - 1; i < ints.Length; i++)
            //{
            //    if (ints[i] == 0)
            //    {
            //        for (int k = i; k < j; k++)
            //        {
            //            ints[k] = ints[k + 1];
            //        }
            //        ints[j] = 0;

            //    }
            //}

            //return ints;
            int count = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] != 0)
                {
                    ints[count++] = ints[i];
                }
            }
            while (count < ints.Length)
            {
                ints[count++] = 0;
            }
            
        }
    }
}
