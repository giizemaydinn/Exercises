using System.IO.Compression;

class Program
{
    /// <summary>
    /// İki thread calissin:
    /// Dosya sikistirma yapan thread.
    /// Ekstra is yapan thread.
    /// </summary>
    /// <param name="args"></param>
    /// 
    static List<FileStream> inputFiles = new List<FileStream>();

    static void Main(string[] args)
    {

        //string path = @"C:\Users\Z004PS5Z\Desktop\Exercises\ConsoleThread03\test";

        Thread t = new Thread(() => CreateFile(@"C:\Users\Z004PS5Z\Desktop\Exercises\Challenge10\test"));
        //t.Priority = ThreadPriority.Highest;
        t.Start();

        Thread t1 = new Thread(() => StartCompress(@"C:\Users\Z004PS5Z\Desktop\Exercises\Challenge10\test"));
        t1.Priority = ThreadPriority.Lowest;
        t1.Start();
    }

    public static void CreateFile(string path)
    {

        Console.WriteLine("Dosyalar oluşturulmaya başlandı.");
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(3000);
            Console.WriteLine(i + ". dosya oluşturuluyor.");
            using (FileStream fs = File.Create(path + i + ".jpg"))
            {
                inputFiles.Add(fs);

            }
            Console.WriteLine(i + ". dosya oluşturuldu.");
        }
        Console.WriteLine("Dosyalar oluşturuldu.");
    }

    public static void StartCompress(string path)
    {
        int i = 0;
        while (true)
        {
            if (i >= inputFiles.Count)
            {
                continue;
            }
            else if (i == 9)
            {
                break;
            }
            else
            {
                Console.WriteLine(i + ". dosya için sıkıştırılma işlemi başlıyor.");
                CompressFile(path + i + ".jpg");
                Console.WriteLine(i + ". dosya için sıkıştırılma işlemi bitti.");
            }
            i++;
            Thread.Sleep(5000);

        }

        Console.WriteLine("Sıkıştırma işlemleri bitti.");
    }
    public static void CompressFile(string path)
    {
        Console.WriteLine("Dosya sıkıştırma işlemi başladı.");
        FileStream sourceFile = File.OpenRead(path);
        FileStream destinationFile = File.Create(path + ".gz");

        byte[] buffer = new byte[sourceFile.Length];
        sourceFile.Read(buffer, 0, buffer.Length);

        using (GZipStream output = new GZipStream(destinationFile,
            CompressionMode.Compress))
        {
            //Console.WriteLine("Compressing {0} to {1}.", sourceFile.Name, destinationFile.Name, false);

            output.Write(buffer, 0, buffer.Length);
        }

        // Close the files.
        sourceFile.Close();
        destinationFile.Close();
        Console.WriteLine("Dosya sıkıştırma işlemi bitti.");

    }
}
