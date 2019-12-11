using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName;
            string data;
            Console.WriteLine("Input file name");
            fileName = Console.ReadLine();
            Console.WriteLine("Input data");
            data = Console.ReadLine();
            if(dsearch(fileName, data) != -1)
            {
                Console.WriteLine(dsearch(fileName, data));
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.ReadLine();
        }

        static int dsearch(string fileName, string data)
        {
            int buffSize = 256;
            FileStream fileStream = new FileStream(fileName,FileMode.Open);
            int fileLength = (int)fileStream.Length;
            byte [] buffer = new byte[buffSize];
            while(true)
            {
                int readed = 0;
                int offset;
                for(offset = 0; offset<fileStream.Length;)
                {
                    readed = fileStream.Read(buffer, 0, 256);
                    if( readed == 0)
                        break;
                    offset += readed;
                    string dataFromFile = System.Text.Encoding.Default.GetString(buffer);
                    if(dataFromFile.Equals(data))
                    {
                        return offset;
                    }
                }
                return -1;
            }
        }
    }
}
