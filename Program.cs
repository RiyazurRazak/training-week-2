using System.Text;

namespace week_2
{
    internal class Program  // : AccessSpecifiers
    {
        delegate int DelegateFn(int x, int y);
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> divisibleBy5 = numbers.FindAll((num) => num % 5 == 0);
            divisibleBy5.ForEach((num) => { Console.WriteLine(num); });
            

            //var normalizer = (int num) => num * 10;
            ////var sum = (int num 1, num 2) => num1 + num2;
            //var sum = (int num1, int num2) => {
            //    int sumation = normalizer(num1) + normalizer(num2);
            //   return sumation;
            //};
            //Console.WriteLine(sum(5,5));


            //DelegateFn maskFn = new DelegateFn(delegate (int a, int b) { return a + b; });
            //Console.WriteLine(maskFn(5, 6));
            //var Print = delegate(string message) { Console.WriteLine(message); };
            //Print("hai from anonymous fn");


            //Delegates obj = new Delegates();
            //DelegateSum maskFn = obj.Sum;
            //maskFn += obj.Difference; // multicastDelegate
            ////maskFn(5, 10);
            ////maskFn.Invoke(5, 6);
            //foreach (DelegateSum mask in maskFn.GetInvocationList())
            //{
            //    int x = mask.Invoke(5, 6);
            //    Console.WriteLine(x);   
            //}

            //StockPrice runner = new StockPrice();
            //runner.Run();


            //SpiralMatrix runner = new SpiralMatrix();
            //runner.Run();

            //DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\Hp\\Documents\\prograd\\cs\\testing");
            //dirInfo.Create();
            //dirInfo.Delete();

            //FileInfo file = new FileInfo("C:\\Users\\Hp\\Documents\\prograd\\cs\\demo.txt");
            //file.Create();

            //using (TextReader textReader = File.OpenText("C:\\Users\\Hp\\Documents\\prograd\\cs\\demo.txt"))
            //{
            //    Console.WriteLine(textReader.Read());
            //}
            //using (TextWriter writer = File.CreateText("C:\\Users\\Hp\\Documents\\prograd\\cs\\demo.txt"))
            //{
            //    writer.WriteLine("Hai");
            //}

            //FileStream file = new FileStream("C:\\Users\\Hp\\Documents\\prograd\\cs\\demo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //StreamWriter writer = new StreamWriter(file);
            //writer.WriteLine("hai guys");
            //writer.Close();
            //StreamReader sr = new StreamReader(file);
            //Console.WriteLine(sr.ReadToEnd());
            //sr.Close();
            //file.Close();


            /*File.WriteAllText("C:\\\\Users\\\\Hp\\\\Documents\\\\prograd\\\\cs\\\\demo.txt", "hOW ARE YOU");
            File.AppendAllText("C:\\\\Users\\\\Hp\\\\Documents\\\\prograd\\\\cs\\\\demo.txt", "hey");*/

            /*FileStream file = new FileStream("C:\\Users\\Hp\\Documents\\prograd\\cs\\demo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            file.Write(Encoding.ASCII.GetBytes("hai da"));
            file.Close();*/

            //Iparent demoApp = new App();
            //demoApp.Show();
            //demoApp.Display();

            //Testing test = new Testing();
            //test.Display(5, 5);

            //ChildB test = new ChildB();
            //test.Check();

            //Marks mark = new Marks(450);
            //Student ragul = new Student("Ragul", 21, 133, mark);
            //ragul.Display();

            //Mustang mustang = new Mustang();
            //mustang.Start();
            //mustang.Stop();
            //mustang.EnableNitroBoost();
            //mustang.Start();

            //Ford mustang = new Ford();
            //mustang.Start();
            //mustang.Stop();

            //AccessSpecifiers obj = new AccessSpecifiers();
            // Console.WriteLine(obj.name);
            // Console.WriteLine(obj.count);

            // Program obj = new Program();
            // obj.Display("hai there");

            // Demo demo = new Demo();
            // demo.Display();



        }
    }
}