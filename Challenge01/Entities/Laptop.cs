namespace Challenge01.Entities
{
    class Laptop : ElectronicDevice
    {
        public int RAM { get; set; }
        public string OS { get; set; }
        public string ProcessorType { get; set; }

        /// <summary>
        /// Base classin constructor'ini da cagirarak nesne initialize edilir.
        /// </summary>
        /// <param name="RAM"></param>
        /// <param name="OS"></param>
        /// <param name="ProcessorType"></param>
        /// <param name="categoryID"></param>
        /// <param name="powerSource"></param>
        public Laptop(int RAM, string OS, string ProcessorType, int categoryID, PowerSource powerSource) : base(categoryID, powerSource)
        {
            this.RAM = RAM;
            this.OS = OS;
            this.ProcessorType = ProcessorType;
            Add(this);
        }

        public void setOS(string OS)
        {
            this.OS = OS;
        }
        /// <summary>
        /// Ram bilgisi kontrolu yaparak ekleme yapar.
        /// </summary>
        /// <param name="laptop"></param>
        /// <exception cref="Exception"></exception>
        public void Add(Laptop laptop)
        {
            if (laptop.RAM < 4 || laptop.RAM > 32)
                throw new Exception("Geçersiz RAM bilgisi");

            RAM = laptop.RAM;
            OS = laptop.OS;
            ProcessorType = laptop.ProcessorType;

            base.Add(this);
        }


    }
}
