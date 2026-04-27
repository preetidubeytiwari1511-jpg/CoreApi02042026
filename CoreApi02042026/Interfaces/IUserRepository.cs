using CoreApi02042026.Models;

namespace CoreApi02042026.Interfaces
{
    public interface IUserRepository
    {
        Task<List<MstUser>> GetAllUsers();
        Task<MstUser> GetUserById(int id);
        Task<MstUser?> ValidateUser(string username, string password);
        Task<int> AddUser(string name, string email, string mobile);   
    }
}
