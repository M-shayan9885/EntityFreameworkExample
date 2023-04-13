using EntityFreameworkExample.DAL.Entities;

namespace EntityFreameworkExample.DAL.Contraacts
{
    public interface IBookRepository
    {
        void Add(Book book);
        List<Book> GetAll();
    }
}
