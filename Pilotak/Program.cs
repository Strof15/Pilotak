


namespace Pilotak 
{
    internal class prog 
    {
        static void main(string[] args) 
        {
            Beolvasas();
            harmasfeladat();
            negyesfeladat();
        }
        static List<Class1> pilotatomb = new List<Class1>();
            static void Beolvasas()
            {
                StreamReader olvas = new StreamReader("pilotak.csv");
                olvas.ReadLine();
                while (!olvas.EndOfStream)
                {
                    string[] adat = olvas.ReadLine().Split(';');
            
                    pilotatomb.Add(new Class1(adat[0], adat[1], adat[2], int.Parse(adat[3])));
                }
                olvas.Close();

            }

        static void harmasfeladat() 
        {
            Console.WriteLine($"3. feladat: {pilotatomb.Count}");
        }

        static void negyesfeladat()
        {
            Console.WriteLine($"4. feladat: {pilotatomb.Last().Nev}");
         }





        
    
    
    
    }


}
