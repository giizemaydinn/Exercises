class Program
{
    /// <summary>
    /// Exception.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        /*
         *  Catchteki exceptionlar sırayla çalışır. En başa Exception verilirse alttakilere gidemez. Çünkü bütün Exceptionları kapsar.
         *  Catch’ten sonra finally ekleyerek hata olsa da olmasa da çalışabilecek alan eklenir.
         *  Catch olmasa da try-finally kullanılabilir. Ama bu durumda hata yönetimi sağlamaz.
         */
        int a = 1, b = 0;

        try
        {
            // hata 1
            int[] dizi = new int[2];
            dizi[3] = 10;

            // hata 2
            Console.WriteLine(a / b);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.ToString());
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            Console.WriteLine("DB kapatma işlemleri vs. yapılır. Hata olsa da olmasa da çalışır.");
        }
    }
}
