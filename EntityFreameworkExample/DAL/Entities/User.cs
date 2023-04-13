using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFreameworkExample.DAL.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Active { get; set; } = false;
    public List<Book> Books { get; set; }
    public addressInfo AddressInfo { get; set; }

}

public class addressInfo
{
    public int UserId { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public User user { get; set; }
}