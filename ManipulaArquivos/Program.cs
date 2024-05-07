// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\\Dados\\";
string path = @"C:\Dados\";
string file = "arquivo.txt";

if(!Directory.Exists(path))
    Directory.CreateDirectory(path);

if (File.Exists(path + file))
{
    StreamReader sr = new StreamReader(path+file);
    string s = sr.ReadToEnd();
    Console.Clear();
    Console.WriteLine(s);
    sr.Close();

    s += "\n";
    s += Console.ReadLine();

    StreamWriter sw = new(path + file);
    sw.WriteLine(s);
    sw.Close();

    Console.Clear();
    Console.WriteLine("Conteudo do arquivo:");
    StreamReader sr2 = new(path + file);
    Console.WriteLine(sr2.ReadToEnd());
    sr2.Close();
}


//StreamWriter sw = new(path+file);

//Console.WriteLine("Informe seu nome:");
//string s = Console.ReadLine();

//sw.WriteLine(s);
//Console.WriteLine("Informe seu email:");
//s = Console.ReadLine();

//sw.WriteLine(s);
//sw.Close();

//StreamReader sr = new(path+file);

//Console.Clear();
//Console.WriteLine(sr.ReadToEnd());
//sr.Close();