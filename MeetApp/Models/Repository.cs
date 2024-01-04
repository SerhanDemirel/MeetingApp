namespace MeetApp.Models
{
    public static  class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();

        static Repository()
        {
            _users.Add(new UserInfo() { Id=1, Name = "Ali", Email = "weqfe@gmail.com", Phone = "12341235", WillAttend = true });
            _users.Add(new UserInfo() {Id=2, Name = "Ahmet", Email = "wqtqfe@gmail.com", Phone = "12341215", WillAttend = true });
            _users.Add(new UserInfo() {Id=3, Name = "Canan", Email = "gaqfe@gmail.com", Phone = "12321235", WillAttend = false });

        }

        public static List<UserInfo> Users { get { return _users;} }
   
        public static void CreateUser(UserInfo user)
        {
         user.Id = Users.Count + 1;
        _users.Add(user);
         }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
        
    }
}
