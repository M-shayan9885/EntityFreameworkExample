using System.Diagnostics;
using EntityFreameworkExample.DAL;
using EntityFreameworkExample.DAL.Contraacts;
using EntityFreameworkExample.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntityFreameworkExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserRepository _userRepository;
        public IndexModel(ILogger<IndexModel> logger,
            IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        public void OnGet()
        {
            var users2 = _userRepository.GetAll();

            var users = new List<User>();

            for (int i = 0; i < 10000; i++)
            {
                users.Add(new User
                {
                    Name = "ALI",
                    Age = 20,
                    AddressInfo = new addressInfo
                    {
                        Address = "Address",
                        City = "Tehran"
                    }

                });
            }
            var st = new Stopwatch();
            st.Start();
            _userRepository.Add(users);
            st.Stop();
            var result = st.ElapsedMilliseconds;

        }
    }
}