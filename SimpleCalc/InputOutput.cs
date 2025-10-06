namespace SimpleCalc
{
    public static class InputOutput
    {
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
    }
}
