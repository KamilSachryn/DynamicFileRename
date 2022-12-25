using System.Text.RegularExpressions;
Console.WriteLine("Simple mass file renamer with dynamic numbering\n\n" +
                  "add \'\\n\' where numbering is desired\n" +
                  "------------\n\n");
Console.Write("Directory: ");
string path = Console.ReadLine();

if(path == "" || path == "/")
{
    path = Directory.GetCurrentDirectory();
}

string[] foundFiles = Directory.GetFiles(path);
foreach (string f in foundFiles)
{
    Console.WriteLine("Found file: " + f);
}


Console.Write("Regex Filename(s): ");
string regexSearch = Console.ReadLine();
Console.Write("New name(s): ");
string replace = Console.ReadLine();

int index = 1;
try
{
    
    Regex rx = new Regex(regexSearch);

    foreach (string f in foundFiles)
    {
        if (rx.IsMatch(f))
        {
            string dir = FileDirectory(f);
            string newFileName = replace.Replace("\\n", index++.ToString());
            Console.WriteLine(dir + newFileName);
            File.Move(f, dir + newFileName);
        }
    }
   
}



catch(Exception e)
{
    Console.WriteLine("The process failed: {0}", e.ToString());
}
Console.ReadLine();


string FileNameFromPath(string path)
{
    int dirIndex = path.LastIndexOf('\\');
    return path.Substring(dirIndex + 1, path.Length - dirIndex - 1);
}

string FileDirectory(string path)
{
    int dirIndex = path.LastIndexOf('\\');
    return path.Substring(0, dirIndex + 1);
}