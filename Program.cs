using System.Text;

namespace week_2
{
    internal class Program  // : AccessSpecifiers
    {
      
        static void Main(string[] args)
        {
            SpiralMatrix runner = new SpiralMatrix();
            runner.Run();

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