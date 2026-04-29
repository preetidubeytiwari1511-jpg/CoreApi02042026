using CoreApi02042026.Data;
using CoreApi02042026.Interfaces;
using CoreApi02042026.Model;
using CoreApi02042026.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace CoreApi02042026.UserRepository
{
    public class SmsService : ISmsService
    {
        private readonly AppDbContext _context;
      public SmsService(AppDbContext context)
        {
            _context = context;
        }   
        public  async Task<APIResponse> SendSmsAsync(MstUser Objlogin)
        {
            APIResponse res = new APIResponse();
            try
            {
                //await Task.Run(() =>
                //{
                if (Objlogin != null)
                {
                    string MobileNo = Objlogin.MobileNo.ToString();
                    string UserFullName = Objlogin.UserName.ToString();

                    if (MobileNo != null && MobileNo != "")
                    {
                        var parameters = new[]
                         {
                          new SqlParameter("@Ind", 1),
                          new SqlParameter("@MobileNo", MobileNo),
                          new SqlParameter("@Username", UserFullName)
                          };

                        var result = await _context.Database
                            .SqlQueryRaw<OTPResponse>(
                                "EXEC Sp_OTPBasedLogin @Ind,@MobileNo,@Username",
                                parameters)
                            .ToListAsync();
                        if (result != null)
                        {
                            string resOTP = result[0].OTP.ToString();
                            SendSMS2MobileAsync(MobileNo, resOTP).GetAwaiter().GetResult();
                            if (result[0].res.ToString() == "1")
                            {
                                string msg = result[0].Msg.ToString();
                                string starmsg = MobileNo.Substring(MobileNo.Length - 4, 4);
                                res.msg = result[0].Msg.ToString() + " ******" + starmsg;
                                res.successcode = 1;
                                //  res.msg = msgResp;
                            }
                            else
                            {
                                res.successcode = 0;
                                // res.msg = msgResp;
                                res.msg = result[0].Msg.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                res.successcode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                res.msg = ex.Message;
            }
            return res;
        }
        public async Task SendSMS2MobileAsync(string MobileNo, string resOTP)
        {

            try
            {
                await Task.Run(async () =>
                {
                    string message = $"Dear Sir, Your OTP for BDA portal is " + resOTP + ". BDA Bhopal";
                    string smsResponse = await sendSingleSMS("bdamobusr", "@2icbda1710", "BDABPL", MobileNo, message, "184dca9a-8569-437b-96e0-1405b9bc7841", "1007702281231437061");
                    //return smsResponse;
                });
            }
            catch (Exception ex)
            {
                string exp = ex.Message.ToString();
                // return exp;
            }
            // return "";
        }
        public async Task<string> sendSingleSMS(String username, String password, String senderid, String mobileNo, String message, String secureKey, String templateid)
        {
            String smsservicetype = "singlemsg"; //For single message.
            String encryptedPassword = encryptedPasswod(password);
            String NewsecureKey = hashGenerator(username.Trim(), senderid.Trim(), message.Trim(), secureKey.Trim());
            var x = await CallSmsApi(username.Trim(), encryptedPassword, senderid.Trim(), mobileNo, message.Trim(), NewsecureKey.Trim(), templateid.Trim(), smsservicetype);
            return x;

        }
        protected String encryptedPasswod(String password)
        {

            byte[] encPwd = Encoding.UTF8.GetBytes(password);
            //static byte[] pwd = new byte[encPwd.Length];
            HashAlgorithm sha1 = HashAlgorithm.Create("SHA1");
            byte[] pp = sha1.ComputeHash(encPwd);
            // static string result = System.Text.Encoding.UTF8.GetString(pp);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in pp)
            {

                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();

        }
        protected String hashGenerator(String Username, String sender_id, String message, String secure_key)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(Username).Append(sender_id).Append(message).Append(secure_key);
            byte[] genkey = Encoding.UTF8.GetBytes(sb.ToString());
            //static byte[] pwd = new byte[encPwd.Length];
            HashAlgorithm sha1 = HashAlgorithm.Create("SHA512");
            byte[] sec_key = sha1.ComputeHash(genkey);

            StringBuilder sb1 = new StringBuilder();
            for (int i = 0; i < sec_key.Length; i++)
            {
                sb1.Append(sec_key[i].ToString("x2"));
            }
            return sb1.ToString();
        }
        public async Task<string> CallSmsApi(String username, String password, String senderid, String mobileNo, String message, String secureKey, String templateid, string smsservicetype)
        {
            var client = new HttpClient();
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //forcing .Net framework to use TLSv1.2
            var request = new HttpRequestMessage(HttpMethod.Post, "https://msdgweb.mgov.gov.in/esms/sendsmsrequestDLT");
            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new KeyValuePair<string, string>("username", username));
            collection.Add(new KeyValuePair<string, string>("password", password));
            collection.Add(new KeyValuePair<string, string>("smsservicetype", smsservicetype));
            collection.Add(new KeyValuePair<string, string>("content", message));
            collection.Add(new KeyValuePair<string, string>("mobileno", mobileNo));
            collection.Add(new KeyValuePair<string, string>("senderid", senderid));
            collection.Add(new KeyValuePair<string, string>("key", secureKey));
            collection.Add(new KeyValuePair<string, string>("templateid", templateid));

            var content = new FormUrlEncodedContent(collection);
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
