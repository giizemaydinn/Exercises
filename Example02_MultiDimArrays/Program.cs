class Program
{
    static void Main(string[] args)
    {
        /*
         * Cok Boyutlu Diziler
         *      +Duzenli 
         *      +Duzensiz (Jagged)
         */

        #region Duzenli Diziler

        // Kullanilabilecek dizi atamalari.
        float[] f1 = new float[4];
        float[] f2 = { 1.2F, 4.7F };
        string[] s1 = { "hello", "arrays" };
        int[] i1 = new int[] { 5, 10, 15, 20 };
        int[,] ikiBoyut = new int[4, 2];
        int[,,] ucBoyut = new int[4, 2, 1];

        #endregion

        #region Jagged

        int[][] jagged =
        {
            new int[] { 1, 2, 3, 4, 5, 6 },
            new int[] { 1, 2 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 1 }
        };

        Console.WriteLine(jagged.Length); // 4

        foreach (var jag in jagged)
        {
            foreach (var ged in jag)
            {
                Console.Write(ged);
            }
            Console.WriteLine();
        }
        #endregion
    }
}
