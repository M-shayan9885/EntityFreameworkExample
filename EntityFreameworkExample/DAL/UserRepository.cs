using EntityFreameworkExample.DAL.Contraacts;
using EntityFreameworkExample.DAL.Dtos;
using EntityFreameworkExample.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFreameworkExample.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(User user)
        {

            _appDbContext.Users.Add(user);
            _appDbContext.SaveChanges();
        }

        public void Add(List<User> users)
        {
            _appDbContext.Users.AddRange(users);
            _appDbContext.SaveChanges();
        }

        public List<UserDto> GetAll()
        {
            var result = _appDbContext.Users
                .Select(x => new UserDto
                {
                    Name = x.Name,
                    AddressInfo = x.AddressInfo,
                    Books = x.Books
                })
                .ToList();

            return result;

        }

        public User GetById(int id)
        {
            var user = _appDbContext.Users
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);

            return user;
        }

        public void ActiveUser(int id)
        {
            var user = _appDbContext.Users
                .FirstOrDefault(x => x.Id == id);

            user.Active = true;

            _appDbContext.SaveChanges();

        }

        public void DeActiveUser(int id)
        {
            var user = _appDbContext.Users
                .FirstOrDefault(x => x.Id == id);

            user.Active = false;

            _appDbContext.SaveChanges();
        }
    }
}