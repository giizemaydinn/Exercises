using Challenge13Library.Entities;

namespace Challenge13Library.Business.Abstract
{
    public interface IStudent
    {
        void Add(Student student);
        void TakeBook(int bookId, int studentId);
        void CalcPoint(int studentId, int returnId);
        void ReturnBook(int bookId, int studentId);

    }
}
