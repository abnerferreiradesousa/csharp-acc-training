// See https://aka.ms/new-console-template for more information


public class Playground {
  public static void Main () 
  {
    long number = 85990526057;
    string fmt = "(00) 00000-0000";
    Console.WriteLine(number.ToString(fmt));
  }

  public void playWithDates () {
    string customFormat = "MMMM dd, yyyy (dddd)";
    DateTime date1 = new DateTime(2009, 8, 15);
    Console.WriteLine(date1.ToString(customFormat));
  }
}


