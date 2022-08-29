string textOne = "Você está aprendendo sobre ";
string textTwo = "Strings em C#, ";
string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";

string concatResult = string.Concat(textOne, textTwo, textThree);

string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com";

string[] e = emails.Split(";");

for (int i = 0; i < e.Length; i++) 
{
  Console.WriteLine(e[i]);
}

List<string> languages = new List<string> 
{
 "c#",
 "java",
 "javascript",
 "python"
};

bool languageExists = languages.Contains("java");

IEnumerable<int> listNumbers = Enumerable.Range(1, 10);

string numbersText = string.Join(',', listNumbers);
Console.Write(numbersText);

string text = "Eu aprendi a lidar com as propriedades e funções da classe String na Trybe!";
int index = text.IndexOf("p", 20);
Console.WriteLine(index);  