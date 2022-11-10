using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pground;


public class ReadFile
{
    public static (bool result, string[] linhasDoArquivo, int quantLines) LerArquivo(string path) 
    {
        try 
        {
            string[] lines = File.ReadAllLines(path);
            return (true, lines, lines.Length);
        }
        catch(Exception) 
        {
            return (false, Array.Empty<string>(), 0);
        }
    }
}