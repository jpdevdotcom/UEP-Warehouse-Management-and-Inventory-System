namespace UEP_Warehouse_Management_and_Inventory_System.Access
{
    public class LoginData
    {
        public static string? username { get; set; }
        public static string? password { get; set; }

        public static string? user_lname { get; set; }
        public static string? user_position { get; set; }

        public static bool isLoggedIn { get; set; } = false;
    }
}
