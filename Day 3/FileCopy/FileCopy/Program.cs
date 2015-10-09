using System;
using System.IO;

namespace FileCopy
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			using (FileStream stream = File.OpenRead("/Users/minimac-kol1/Desktop/Rajlakshmi/one.txt"))
			using (FileStream writeStream = File.OpenWrite("/Users/minimac-kol1/Desktop/Rajlakshmi/six.txt"))
			{
				//BinaryReader reader = new BinaryReader(stream);
				//BinaryWriter writer = new BinaryWriter(writeStream);

				// create a buffer to hold the bytes 
				byte[] buffer = new Byte[1000000];
				int bytesRead;

				// while the read method returns bytes
				// keep writing them to the output stream
				while ((bytesRead =
					stream.Read(buffer, 0, 1000000)) > 0)
				{
					writeStream.Write(buffer, 0, bytesRead);
				}
			}
		}
	}
}
