using System.Net;

namespace Common.Functions.DownloadFile
{
    public static class FileDownloader
    {
        public static void Download(string uri, string destinationFilePath)
        {
            using (var client = new WebClient())
                client.DownloadFile(uri, destinationFilePath);
        }
    }
}
