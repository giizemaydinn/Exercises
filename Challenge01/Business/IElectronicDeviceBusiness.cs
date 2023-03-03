using Challenge01.Entities;

namespace Challenge01.Business
{
    interface IElectronicDeviceBusiness
    {
        public void Add(ElectronicDevice electronicDevice);
        public void Delete(int id);
        public void Update(ElectronicDevice electronicDevice);

    }
}
