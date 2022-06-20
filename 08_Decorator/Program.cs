using Decorator.Abstract;
using Decorator.Concrete.Decorators;
using Decorator.Concrete.Main;

IFileWriter fileWriter = new FileWriter();//basic

fileWriter.Write(@"e:\file.txt", "test text");
Console.WriteLine("----------------------------------");

fileWriter = new CompressFileWriter(fileWriter);//add compression
fileWriter.Write(@"e:\file.txt", "test text");
Console.WriteLine("----------------------------------");

fileWriter = new EncryptedFileWriter(fileWriter);//add encryption
fileWriter.Write(@"e:\file.txt", "test text");
Console.WriteLine("----------------------------------");
