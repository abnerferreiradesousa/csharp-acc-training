// LISTAS -----------

List<string> listStates = new();

listStates.Add("CE");
listStates.Add("SP");
listStates.Add("RJ");


foreach(string state in listStates)
{
    Console.WriteLine($"State {state}");
}




// using CalculatorPlace;

// var res = new Calculator();

// res.Somar(2, 2);
// res.Potenciacao(2, 3);
// res.Seno(30);
// res.Coseno(30);
// res.Tangente(30);
// res.ProgramList();

// int[] arrayInt = new int[4];

// arrayInt[0] = 12;
// arrayInt[1] = 13;
// arrayInt[2] = 14;
// arrayInt[3] = 1;


// // Array.Resize(ref arrayInt, arrayInt.Length * 2);
// int[] arrayCopy = new int[arrayInt.Length * 2];

// Array.Copy(arrayInt, arrayCopy, arrayInt.Length);
// try
// {
//     arrayInt[3] = 14;
// }
// catch(Exception err)
// {
//     Console.WriteLine(err.Message);
// }

// for (int i = 0; i < arrayInt.Length; i++)
// {
//     Console.WriteLine($"Posição{i} - Valor {arrayInt[i]}");
// }

// foreach (int v in arrayInt)
// {
//     Console.WriteLine(v);
// }
