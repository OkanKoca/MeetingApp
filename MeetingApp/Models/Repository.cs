namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();

        static Repository(){
            _users.Add(new UserInfo
            {
                Id = 1,
                Name = "okok",
                Phone = "5466606715",
                Email = "Oasfasf@gmail.com",
                WillAttend = true
            });
            _users.Add(new UserInfo
            {
                Id = 2,
                Name = "oasfk",
                Phone = "5966606715",
                Email = "hjufasf@gmail.com",
                WillAttend = false
            });
            _users.Add(new UserInfo
            {
                Id = 3,
                Name = "oka",
                Phone = "89526715",
                Email = "asfkasf@gmail.com",
                WillAttend = true
            });
        }

        public static List<UserInfo> Users
        {
            get { return _users; }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? getById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
