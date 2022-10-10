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
