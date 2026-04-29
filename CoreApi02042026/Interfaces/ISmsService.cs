using CoreApi02042026.Model;
using CoreApi02042026.Models;

namespace CoreApi02042026.Interfaces
{
    public interface ISmsService
    {
        Task<APIResponse> SendSmsAsync(MstUser Objlogin);
    }
}
