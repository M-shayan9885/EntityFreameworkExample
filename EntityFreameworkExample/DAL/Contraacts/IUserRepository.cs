using EntityFreameworkExample.DAL.Dtos;
using EntityFreameworkExample.DAL.Entities;

namespace EntityFreameworkExample.DAL.Contraacts;

public interface IUserRepository
{
    void Add(User user);
    void Add(List<User> users);
    List<UserDto> GetAll();
    User GetById(int id);
    void ActiveUser(int id);
    void DeActiveUser(int id);
}