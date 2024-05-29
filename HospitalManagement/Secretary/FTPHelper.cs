using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Secretary
{
    public class FTPHelper
    {
        public FTPHelper(string address= "\tftp://155.254.244.38/www.sca.somee.com/", string login="sca33", string password = "2XFfX2b6xQUTJ-U")
        {
            Address = address;
            Login = login;
            Password = password;
        }
        public string Upload(MemoryStream stream, string fileName)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Address + @"/" + fileName);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(Login, Password);
                request.UseBinary = true;
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(buffer, 0, buffer.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                return "Profil Resmi Başarıyla Güncellendi!";
            }
            catch (Exception ex)
            {
                return ex.InnerException.ToString();
            }
        }
        public bool CheckFileExistence(string fileName)
        {
            var request = (FtpWebRequest)WebRequest.Create($"{Address}" + fileName);
            request.Credentials = new NetworkCredential(Login, Password);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                return true;
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    return false;
            }
            return false;
        }

        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}

