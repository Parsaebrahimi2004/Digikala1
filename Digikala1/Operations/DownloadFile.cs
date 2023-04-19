using System.Net;

namespace Digikala1.Operations
{
    public class FileDownloader
    {
        public void DownloadFile()
        {
            string Folder = @"D:\digikala dataset\";
            Directory.CreateDirectory(Folder);

            string Dfile = "http://alihafezi.com/fa/wp-content/uploads/2023/03/orders.csv";
            string Flocation = @"D:\digikala dataset\orders.csv";

            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(Dfile, Flocation);
                    Console.WriteLine("File downloaded");
                }
                catch (Exception error)
                {
                    Console.WriteLine("Something went wrong : " + error.Message);
                }
                
            }
        }
    }
}

