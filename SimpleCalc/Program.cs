namespace SimpleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTask();
        }
        public static void FullTask()
        {
            while (true)
            {
                double firstNumber = InputOutput.InputNumber("Введите первое число для операции: ");
                string operation = InputOutput.ChoiceOfMathematicalOperation();
                double secondNumber = InputOutput.InputNumber("Введите второе число для операции: ");
                double result; switch (operation)
                {
                    case "+":
                        result = MathOperations.Add(firstNumber,secondNumber);
                        break;
                    case "-":
                        result = MathOperations.Subtract(firstNumber, secondNumber);
                        break;
                    case "*":
                        result = MathOperations.Multiply(firstNumber, secondNumber);
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль невозможно.");
                            continue;
                        }
                        result = MathOperations.Divide(firstNumber, secondNumber);
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция.");
                        continue;
                }

                Console.WriteLine($"Результат операции: {firstNumber} {operation} {secondNumber} = {result}\n");
                Console.WriteLine("Хотите выполнить ещё одну операцию? (да/нет): ");

                var answer = Console.ReadLine()?.Trim().ToLower();

                if (answer != "да")
                {
                    Console.WriteLine("Завершение работы."); break;
                }
            }
        }
    }
}

