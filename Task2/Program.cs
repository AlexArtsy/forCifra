namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = args[0];
            String line;
            List<int> lines = new List<int> ();
            
            try
            {
                StreamReader sr = new StreamReader(filePath);
                line = sr.ReadLine() ?? ""; //  линтер ругался, пришлось присваивать значение не null
                lines.Add(Int32.Parse(line));

                while (line != "")
                {
                    line = sr.ReadLine() ?? "";
                    if(line != "")
                    {
                        lines.Add(Int32.Parse(line));
                    }
                }
                sr.Close();
                
                int[] nums = lines.ToArray();
                Array.Sort(nums);

                int median = nums.Length % 2 == 0 ? nums[nums.Length / 2 - 1] : nums[(nums.Length / 2)];

                int sum = 0;
                foreach (int num in nums)
                {
                    sum += Math.Abs(median - num);
                }

                Console.WriteLine(sum);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}