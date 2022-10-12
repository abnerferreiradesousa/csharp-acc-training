namespace CalculatorPlace 
{
    public class Calculator
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potenciacao(int x, int y)
        {
            double result = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {result}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 2)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Conseno de {angulo} = {Math.Round(coseno, 2)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 2)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quandrada de {x} = {raiz}");
        }

        public void ClassLoop(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"{i} * {x} = {i * x}");
            }
        }
        
        public void ClassLoopWhile(int x)
        {
            int count = 0;
            while (true)
            {
                if(count > 7) 
                    break;

                count += 1;
                Console.WriteLine($"{count} * {x} = {count * x}");
            }
        }

        public void ClassLoopDoWhile()
        {
            int numero, sum = 0;
            do
            {
                Console.WriteLine("Digite um número para ser somado: ");
                numero = Convert.ToInt32(Console.ReadLine());
                sum += numero;
                Console.WriteLine(sum);
            } while (numero != 0);
        }

        public void ProgramList()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Opção 1");
                Console.WriteLine("Opção 2 - Encerrar");

                var res = Console.ReadLine();

                switch(res)
                {
                    case "1":
                        Console.WriteLine("buscando...");
                        break;
                    case "2":
                        Environment.Exit(0);
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("NOt found");
                        break;
                }
                
            } 
        }
    }
}

