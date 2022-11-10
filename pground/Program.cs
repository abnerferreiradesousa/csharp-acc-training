// See https://aka.ms/new-console-template for more information
using pground;



// =================================== Desconstrutor ======================================
Person p1 = new(name: "Abner", age: 22);

(int age, string name) = p1;

Console.WriteLine($"{age} - {name}");


// =================================== Tupla ======================================

(int Id, string Name, string SecondName) tupla = (1, "Abner", "Sousa");

// Outras formas de declarar uma Tupla...
(int Id, string Name, string SecondName) = (1, "Abner", "Sousa");

ValueTuple<int, string> tuple = (1, "Abner");
var outherTuple = (1, "Abner");

Console.WriteLine($"Value: {Id}");
Console.WriteLine($"Value: {Name}");
Console.WriteLine($"Value: {SecondName}");

var (sucesso, linhasDoArquivo, _) = ReadFile.LerArquivo("FileRead/user.txt");

if(sucesso) 
{
    // Console.WriteLine($"Quantidade de linhas: {quantLines}");
    foreach (string item in linhasDoArquivo)
    {
        Console.WriteLine(item);
    }
}






// =================================== Dictionary ======================================

Dictionary<string, string> dict = new()
{
    { "SP", "São Paulo" },
    { "CE", "Ceará" },
    { "RJ", "Rio Janeiro" },
    { "PR", "Paraná" }
};

foreach (KeyValuePair<string, string> item in dict)
{
    Console.WriteLine($"Read object {item.Key} - {item.Value}");
}

dict.Remove("CE");

foreach (KeyValuePair<string, string> item in dict)
{
    Console.WriteLine($"Read object {item.Key} - {item.Value}");
}



// =================================== Pilha - LIFO =====================================

Stack<string> pilha = new();

pilha.Push("Abner");
pilha.Push("Bruna");
pilha.Push("Larissa");
pilha.Push("Amanda");

foreach (string item in pilha)
{   
    Console.WriteLine(item);
}

Console.WriteLine($"Removeu o elemento: {pilha.Pop()}");

pilha.Push("Filipe");

foreach (string item in pilha)
{   
    Console.WriteLine(item);
}




// =================================== Filas - FIFO ======================================

Queue<string> fila = new();

fila.Enqueue("Abner");
fila.Enqueue("Bruna");
fila.Enqueue("Larissa");
fila.Enqueue("Amanda");

foreach (string item in fila)
{   
    Console.WriteLine(item);
}

Console.WriteLine($"Removeu o elemento: {fila.Dequeue()}");

fila.Enqueue("Filipe");

foreach (string item in fila)
{   
    Console.WriteLine(item);
}




// ================================= Lendo um arquivo ====================================

    try
    {
        string[] text = File.ReadAllLines("FileRead/user.txt");

        foreach (string item in text)
        {   
            Console.WriteLine(item);
        }
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine($"Erro: {ex}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex}");
    }
    finally
    {
        //Executa mesmo quando lançada uma exceção ou não...
        Console.WriteLine("Envia um email com o resultado da avaliação.");
    }