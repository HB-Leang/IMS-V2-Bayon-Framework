using BayonFramework.Database.Driver;
using BayonFramework.Database;
using Microsoft.Data.SqlClient;
using IMS_Services.Entities;
using BayonFramework.Security.Request;
using IMS_Services.SecurityConfig;
using BayonFramework.Database.Builder.Core;
using BayonFramework.Database.Builder.Query.Condition.Enum;

namespace IMS_Services.Services.Implementation
{
    public class LoginService
    {
        private static IDatabase db = Database.Instance.GetDatabase();
        private static SqlConnection connection = (SqlConnection)db.GetConnection()!;

        public static bool Login(string username, string password, out string errorMsg)
        {
            User user = UserServices.GetUserByUserName(username);

            if (user == null)
            {
                errorMsg = "User Not Found";
                return false;
            }

            var auth = new AuthRequest(user.Username!, password)
                .WithLocked(user.IsLocked ?? false)
                .WithAttempt(user.Attempt ??  0)
                .WithHashPassword(user.Password!)
                .Build();
            
            var security = new CustomLoginSecurityConfiguration(auth);

            if (!security.Execute())
            {              
                errorMsg = security.ErrorMessage;
                if (errorMsg.Equals("Password: Wrong"))
                {
                    UpdateAttempt(user.ID, user.Attempt ?? 0);
                }
                return false;
            }

            errorMsg = string.Empty;
            UpdateAttempt(user.ID, -1);
            return  true;
        }

        public static bool UpdateAttempt(short id, short attempt)
        {
            SqlQuery query = new QueryBuilder(User.TableName).Update(new Dictionary<string, object>
            {
                {"Attempt", attempt+1}
            }).Where("UserID", ComparisonCondition.Equal, id).Build();

            using (SqlCommand cmd = new SqlCommand(query.Query, connection))
            {
                try
                {
                    int effected = query.GetSqlCommand(cmd).ExecuteNonQuery();
                    return effected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Failed in updating new Staff > {ex.Message}");

                }
            }
        }
    }
}
