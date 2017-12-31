using System;
using System.Net;

namespace Common.Functions.DownloadFile
{
    public static class FileDownloader
    {
        public static void Download(Uri uri, string destinationFilePath)
        {
            using (var client = new WebClient())
                client.DownloadFile(uri, destinationFilePath);
        }
    }
}
