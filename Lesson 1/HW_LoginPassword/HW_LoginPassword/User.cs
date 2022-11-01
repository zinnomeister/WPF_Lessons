namespace HW_LoginPassword
{
    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public string GetStringUserData()
        {
            return $"{Name}|{Password}";
        }


        public string GetName()
        {
            return Name;
        }

        public static string GetName(User user)
        {
            return user.Name;
        }

    }
   
}
//TextChanged = "TextBox_TextChanged"
  
////namespace Authorization
//{
//    public class User
//    {
//        public string Name { get; set; }
//        public string Password { get; set; }

//        public string GetStringUserData()
//        {
//            return $"{Name}|{Password}";
//        }
//    }
//}
