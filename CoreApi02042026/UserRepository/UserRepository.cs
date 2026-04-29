using CoreApi02042026.Data;
using CoreApi02042026.Interfaces;
using CoreApi02042026.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CoreApi02042026.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
       
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task<int> AddUser(string name, string email, string mobile)
        {
            throw new NotImplementedException();
        }
        public async Task<List<MstUser>> GetAllUsers()
        {
            var users = await _context.Database
                .SqlQueryRaw<MstUser>("EXEC sp_GetAllUsers")
                .ToListAsync();

            return users;
        }
        public Task<MstUser> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<MstUser?> ValidateUser(string username, string password)
        {
            var parameters = new[]
            {
                new SqlParameter("@Ind", 7),
                new SqlParameter("@UserLoginId", username),
                new SqlParameter("@PASSWORD", password)
                };

            var result = await _context.Database
                .SqlQueryRaw<MstUser>(
                    "EXEC Sp_OTPBasedLogin @Ind,@UserLoginId,@PASSWORD",
                    parameters)
                .ToListAsync();


            return result.FirstOrDefault();
        }
        //public  async Task<AppUser?> ValidateUser(string username, string password)
        //{
        //    var parameters = new[]
        //    {
        //    new SqlParameter("@Ind", 4),
        //    new SqlParameter("@Username", username),
        //    new SqlParameter("@Password", password)
        //    };

        //    var result = await _context.Database
        //        .SqlQueryRaw<AppUser>(
        //            "EXEC sp_ValidateUser @Username, @Password",
        //            parameters)
        //        .ToListAsync();

        //    return result.FirstOrDefault();
        //}

        //    public async Task<MstUser?> ValidateUser(string username, string password)
        //    {
        //        var parameters = new[]
        //        {
        //    new SqlParameter("@Username", username),
        //    new SqlParameter("@Password", password)
        //};

        //        // ✅ SP Call - MstUser Return करेगा
        //        var result = await _context.Database
        //            .SqlQueryRaw<MstUser>(
        //                "EXEC sp_ValidateUser @Username, @Password",
        //                parameters)
        //            .ToListAsync();

        //        // ✅ MstUser Return करो
        //        return result.FirstOrDefault();
        //    }
    }
}
