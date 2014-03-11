using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace TestAWSConsole
{
    public class Upload
    {
        public string existingBucketName = "borderlands";
        public string keyName = "teamspeak.txt";
        public string filePath = "C:/Users/Jari/Documents/teamspeak.txt";

        public void uploadfile()
        {
            try
            {
                TransferUtility fileTransferUtility = new
                    TransferUtility(new AmazonS3Client(Amazon.RegionEndpoint.EUWest1));

                // 2. Specify object key name explicitly.
                fileTransferUtility.Upload(filePath,
                                          existingBucketName, keyName);
                Console.WriteLine("Upload 2 completed");

            }
            catch (AmazonS3Exception s3Exception)
            {
                Console.WriteLine(s3Exception.Message,
                                  s3Exception.InnerException);
            }
        }
    }
}
