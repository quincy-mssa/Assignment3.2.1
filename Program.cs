namespace Assignment3._2._1
{
    internal class Program
    {
        //Create a 2D array to store integers and print them in matrix format with proper formatting.
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1 , 2 , 3 },
                { 4 , 5 , 6 },
            };

            int row = 0;
            int col = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

        }

        
    }
}
