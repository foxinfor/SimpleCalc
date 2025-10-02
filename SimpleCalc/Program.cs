namespace SimpleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTask();
        }

        public static double InputNumber(string msg)
        {
            Console.Write(msg);
            while (true)
            {
                var num = Console.ReadLine();

                if (double.TryParse(num, out double result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка: введите корректное число.");
                Console.Write(msg);
            }
        }

        public static string ChoiceOfMathematicalOperation()
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию: ");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. /");
                Console.WriteLine("4. *");
                var procedure = Console.ReadLine();
                switch (procedure)
                {
                    case "1":
                        return "+";
                    case "2":
                        return "-";
                    case "3":
                        return "/";
                    case "4":
                        return "*";

                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.\n");
                        break;
                }
            }
        }

        public static void FullTask()
        {
            while (true)
            {
                double firstNumber = InputNumber("Введите первое число для операции: ");
                string operation = ChoiceOfMathematicalOperation();
                double secondNumber = InputNumber("Введите второе число для операции: ");
                double result; switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль невозможно.");
                            continue;
                        }
                        result = firstNumber / secondNumber;
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

