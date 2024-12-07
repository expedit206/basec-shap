
using System.Text;
using System;
class App
{
    //static void Main(string[] args)
    //{
    //    string nom = "Expedit";
        //string nom2 = "Domingo";
        //int age = 15;
        //Console.WriteLine("Bonjour ", +nom);
        //Console.WriteLine($"Bonjour {nom}");
        //Console.WriteLine(string.Concat(nom, " ", nom2));
        //Console.WriteLine(string.Format("{0} à {1} ans", nom, age));

        //StringBuilder sb = new StringBuilder();

        //sb.Append("Bonjour");
        //sb.Append(" expedit!");
       
        //Console.WriteLine(sb.ToString().Length);
        //Console.WriteLine(sb.ToString().ToUpper());
        //Console.WriteLine(sb.ToString().ToLower());
        //Console.WriteLine(sb.ToString().Substring(0, 3));
        //Console.WriteLine(sb.ToString().Replace('o', 'i'));
        
            //Console.WriteLine(nom == "Expedit" ? $"bonjour {nom}":"Error");

        //int jour = 4;

        //switch (jour)
        //{
        //    case 1: Console.WriteLine("Lundi");
        //        break;
                
        //    case 2: Console.WriteLine("Mardi");
        //        break;
                
        //    case 3: Console.WriteLine("Mercredi");
        //        break;
                
        //    case 4: Console.WriteLine("Jeudi");
        //        break;
                
        //    case 5: Console.WriteLine("Vendredi");
        //        break;
                
        //    case 6: Console.WriteLine("Samedi");
        //        break;
                
        //    case 7: Console.WriteLine("dimanche");
        //        break;


        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine($"Compteur : {i}");
        //}

        //int compteur = 0;

        //while (compteur < 5)
        //{
        //    Console.WriteLine($"Compteur : {compteur}");
        //    compteur++;
        //};

        //string[] noms = { "Devinsto", "Eva", "Alice" };

        //foreach (var item in noms)
        //{
        //    Console.WriteLine($"Bonjour : {item}");

        //}
    
        //string nombreInput = Console.ReadLine();
        //float nombre = float.Parse(nombreInput); 
        //Console.WriteLine(nombre);
        //Console.WriteLine($"l'inverse de {nombre} est 1/{nombre} = {1/nombre}");


    //int a = int.Parse()
    //}
    public  static int Additionner(int a ,int b)
        {
            return a+b;
        }

}
    static void Main(string[] args)
    {


    Console.WriteLine("Entre le premier nombre");
        int aInput = int.Parse(Console.ReadLine());
    Console.WriteLine("Entre le deuxieme nombre");
        int bInput = int.Parse(Console.ReadLine());

        int resultat =App.Additionner(aInput, bInput);
        Console.WriteLine($"Le resultat de l'addition est {resultat}");
    }