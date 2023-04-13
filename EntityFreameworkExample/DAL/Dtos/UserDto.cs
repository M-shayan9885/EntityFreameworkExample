using EntityFreameworkExample.DAL.Entities;

namespace EntityFreameworkExample.DAL.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public addressInfo AddressInfo { get; set; }
    }
}
