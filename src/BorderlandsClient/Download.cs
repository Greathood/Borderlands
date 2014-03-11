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
    public class Download
    {

        // Download file from bucket to local location
        public void Downloadfile(String bucket, String file, String storePath)
        {
            try
            {
                TransferUtility fileTransferUtility = new
                    TransferUtility(new AmazonS3Client(Amazon.RegionEndpoint.EUWest1));

                // 2. Specify object key name explicitly.
               fileTransferUtility.Download(storePath,
                                          bucket, file);
                Console.WriteLine(String.Format("Succesfully downloaded file: {0} from bucket: {1} to location: {2}", file, bucket, storePath));

            }
            catch (AmazonS3Exception s3Exception)
            {
                Console.WriteLine(s3Exception.Message,
                                  s3Exception.InnerException);
            }
        }
    }
}
