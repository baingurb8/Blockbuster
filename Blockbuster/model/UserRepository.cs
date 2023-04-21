using System.IO;

namespace Blockbuster.model
{
    public class UserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            _users = new List<User>();

            _users.Add(new User()
            {
                firstName = "Gurbir",
                lastName = "Bains",
                userName = "gurbirbains",
                password = "1234",
                admin = true


            });
            _users.Add(new User()
            {
                firstName = "Mr.",
                lastName = "Teacher",
                userName = "teacher1234",
                password = "1234",
                admin = true


            });
        }
        

    }
}