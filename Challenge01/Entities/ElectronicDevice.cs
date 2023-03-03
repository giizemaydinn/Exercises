using Challenge01.Business;

namespace Challenge01.Entities
{
    class ElectronicDevice : IElectronicDeviceBusiness
    {
        static int id = 0;
        static List<ElectronicDevice> list = new List<ElectronicDevice>();

        public int ID { get; set; }
        public int CategoryID { get; set; }
        public PowerSource PowerSource { get; set; }

        public ElectronicDevice(int categoryID, PowerSource powerSource)
        {
            CategoryID = categoryID;
            PowerSource = powerSource;

            id++;
            list.Add(this);
        }

        /// <summary>
        /// Kategori bilgisi kontrol edilerek ekleme yapilir.
        /// </summary>
        /// <param name="electronicDevice"></param>
        /// <exception cref="Exception"></exception>
        public void Add(ElectronicDevice electronicDevice)
        {
            //*yetki kontrolu eklenmeli*
            if (electronicDevice.CategoryID > Category.id)
                throw new Exception("Geçersiz index");

            id++;
            list.Add(electronicDevice);
        }

        /// <summary>
        /// Cihaz mevcutsa silinir.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <exception cref="Exception"></exception>
        public void Delete(int deviceId)
        {
            //*yetki kontrolu eklenmeli*
            if (deviceId > id)
                throw new Exception("Geçersiz index");
            list.RemoveAt(id);
        }

        /// <summary>
        /// Cihaz mevcutsa guncellenir.
        /// </summary>
        /// <param name="electronicDevice"></param>
        public void Update(ElectronicDevice electronicDevice)
        {
            //*yetki kontrolu eklenmeli*
            foreach (var item in list)
            {
                if (item.ID == electronicDevice.ID)
                {
                    item.PowerSource = electronicDevice.PowerSource;
                    item.CategoryID = electronicDevice.CategoryID;
                }
            }
        }
    }

    enum PowerSource
    {
        electric = 0,
        battery = 1,
        charge = 2
    }
}
