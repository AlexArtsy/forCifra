namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            long getNextValue(long maxValue, long m, long currentValue, long startValue) 
            {
                for(long i = 1; i < m; i++)
                {
                    if(currentValue == maxValue)
                    {
                        currentValue = startValue;
                    }
                    else
                    {
                        currentValue++;
                    }
                }
                return currentValue;
            }
            long n = Int64.Parse(args[0]);
            long m = Int64.Parse(args[1]);
            long startValue = 1;//    Int64.Parse(args[2]);
            long maxValue = startValue + n - 1;
            List<long> list = new List<long> (){ startValue };
            long currentValue = -999999999990;  // сори за костыль (:

            if(n == 0)
            {
                Console.WriteLine("Ошибка: по условию задания n >= 1");
                return;
            }

            while(currentValue != startValue)
            {
                currentValue = getNextValue(maxValue, m, list.Last(), startValue);
                if(currentValue != startValue)
                {
                    list.Add(currentValue);
                }
            }
            var result = String.Join("", list);
            Console.WriteLine(result);
        }
    }
}