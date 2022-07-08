// Просмотреть информацию в директории.

string path = "C:/Users/kirba/Desktop/Lections and Seminars to learn language C#, works/Lections. Learn Language C#, start 04.06.2022/Examples/Example015_Recursive and Dvumernie Massive";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);;
}