namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getNextValue(int n, int m, int currentValue) 
            {
                for(int i = 1; i < m; i++)
                {
                    if(currentValue == n)
                    {
                        currentValue = 1;
                    }
                    else
                    {
                        currentValue++;
                    }
                }
                return currentValue;
            }

            int n = Int32.Parse(args[0]);
            int m = Int32.Parse(args[1]);
            List<int> list = new List<int> (){ 1 };
            int currentValue = 0;

            if(n == 0)
            {
                Console.WriteLine("Ошибка: по условию задания n >= 1");
                return;
            }

            while(currentValue != 1)
            {
                currentValue = getNextValue(n, m, list.Last());
                if(currentValue != 1)
                {
                    list.Add(currentValue);
                }
            }
            var result = String.Join("", list);
            Console.WriteLine(result);
        }
    }
}