// See https://aka.ms/new-console-template for more information
using System.Globalization;

public class Playground {
  public static void Main () 
  {
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

    long someLongNumber = 346;
    int intNumber = Convert.ToInt32(someLongNumber);

    // int intNumber = (int) someLongNumber;

    // Console.WriteLine("Teste de hoje " + intNumber);
    decimal num = 132.34M;
    // Formando valor numérico para uma variável.
		// Console.WriteLine($"{num:C}");
		// Console.WriteLine(num.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
		// Console.WriteLine(num.ToString("C"));

    double porc = .3456;
    int n = 556677;
		Console.WriteLine(porc.ToString("P"));
		Console.WriteLine(n.ToString("##/##/##"));


  }

  public static void PlayWithDates () {
    string customFormat = "MMMM dd, yyyy (dddd)";
    DateTime date1 = new DateTime(2009, 8, 15);
    Console.WriteLine(date1.ToString(customFormat));
  }

  public static void PlayCoins () {
      decimal value = 1603.42m;
      Console.WriteLine(value.ToString("C3", new CultureInfo("pt-BR")));
  }

  public static void Conversion()
  {        
    long number = 85990526057;
    string fmt = "(00) 00000-0000";
    Console.WriteLine(number.ToString(fmt));
  } 



}


