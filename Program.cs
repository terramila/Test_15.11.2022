
   string[] Array;
            Console.WriteLine("Введите массив строк через пробел");
            string stringUser = Console.ReadLine();
            Array = stringUser.Split(' ');
           
            var result = new string[Array .Length];
            var values = 0;
            
           