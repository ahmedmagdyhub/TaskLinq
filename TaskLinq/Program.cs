namespace TaskLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task02
            int[] arr = { 13, 20, 3, 4, 5, 66, 77, 68, 90, 10 };
            var res01=  arr.MyOrderByDescending(x => x);
            foreach (var item in res01)
            {
                Console.WriteLine(item);
            }
            var res02 = arr.MyOrderBy(x => x);
            foreach (var item in res02)
            {
                Console.WriteLine(item);
            }

            var res03 = arr.MyTake(5);
            foreach (var item in res03)
            {
                Console.WriteLine(item);
            }
            var res04 = arr.MySkip(5);
            foreach (var item in res04)
            {
                Console.WriteLine(item);
            }
            var res05 = arr.MyLast();
            Console.WriteLine(res05);
            var res06 = arr.MyTakeWhile(x => x < 50);
            foreach (var item in res06)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Task01
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1,"Ahmed ",50000),
                new Employee(2,"yassmin",60000),
                new Employee(3,"reham",55000),
                new Employee(4,"asmaa",70000),
                new Employee(5,"ali",65000)
            };
            var result = employees.Where(e => e.salary >= 60000).Select(e => new { e.name, e.salary });
            //foreach (var item in result)
            //{
            //    Console.WriteLine( item);
            //}
            
            var result2 = employees .Take(2).OrderByDescending(e => e.salary).Select(e => new { e.name, e.salary });
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            var result3 = employees.OrderBy(e => e.id).Reverse().Skip(1).Take(3)
             .Select(e => new { e.name, e.salary });


            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item);
            //}

            var result4 = employees.OrderByDescending(e => e.salary).Skip(2).Last();
            

            
            var result5 = employees.OrderBy(e => e.salary).TakeWhile(e => e.salary < 65000).Select(e => new { e.name, e.salary });

            //foreach (var item in result5)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
