
   string[] Array;
            Console.WriteLine("Введите массив строк через пробел");
            string stringUser = Console.ReadLine();
            Array = stringUser.Split(' ');
           
            var result = new string[Array .Length];
            var values = 0;
            
           foreach (var value in Array )
            {
                if (value.Length <= 3)
                {
                    result[values] = value;
                    values++;
                }
            }
            Console.Write((string.Join("  " , result )));
            Console.ReadKey(true);