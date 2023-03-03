
class Program
{
    /// <summary>
    /// Basic class concepts
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        #region Access Modifiers

        // internal - proje icinde erisilebilir,
        // protected - tanimlandigi sinifta veya miras alan siniflardan,
        // protected internal - tanimlandigi sinifta veya miras alan siniflardan erisilebilir.
        // (tanimlamanin ayni proje icerisinde olmasi gerekmez.)

        #endregion
        Kutu kutu = new Kutu();
        kutu.GetMyGuid();
    }
}