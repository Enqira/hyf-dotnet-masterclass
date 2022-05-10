public class Shared
{
    public static string ConnectionString = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb")) ?
  "Server=localhost;Database=meal-sharing;Uid=root;Pwd=;convert zero datetime=true" :
   Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb");
}