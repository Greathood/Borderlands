using System;
using System.IO;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace BorderlandsClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hey, welcome to our AWS testing utility you numnut! :)");
            Console.WriteLine("Please give me some info now to talk to AWS");

            Console.WriteLine("From which bucket should I get a file?");
            string _AWSBucket = Console.ReadLine();
            Console.WriteLine("Okay, and which file should I get?");
            string _AWSFile = Console.ReadLine();
            Console.WriteLine("Awesome, and to what location should I save it?");
            string _filePath = Console.ReadLine();
            Console.WriteLine("Great, we're all set, prepare to see a file! ;)");

            var download = new Download();
            download.Downloadfile(_AWSBucket, _AWSFile, _filePath);


            //var read = new Read();
            //read.Readfile();
            

            //var upload = new Upload();
            //upload.uploadfile();
        }
    }
}
