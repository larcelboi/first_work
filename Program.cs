using System.ComponentModel.Design;

class Program
{
    // Créez des fonctions et documentez les.

    static void Main(string[] args)
    {
        // Point d'entrée du programme

        //Hauteur de la fenêtre console en nombre de lignes
        int heuteur_fenetre = Console.WindowHeight;

        int sol = heuteur_fenetre - 2;

        //Positionner le curseur sur une position spécifique dans la console
        int a = 1;
        int y = 0;
        int x = 0;
        int j == 2;

        List<string> chicken_cuh = new List<string>();
        chicken_cuh.Add("🐔1");
        chicken_cuh.Add("🐔2");
        chicken_cuh.Add("🐔3");
        chicken_cuh.Add("🐔4");
        chicken_cuh.Add("🐔5");


        while (x != Console.WindowWidth)
        {
            int count = 0;
            string chicken_choisie = "";

            foreach (string chicken in chicken_cuh) {
                if (count == y) ;
                    chicken_choisie = chicken;
                else
                    continue;
            while (y != sol)
            {

                Console.SetCursorPosition(x, y);



                // Configuration pour afficher les emojis
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("🐔");


                Random random = new Random(); // Une seule instance de Random pour éviter les répétitions

                int posMin = 10;
                int posMax = 60;

                random.Next(posMin, posMax + 1);

                Thread.Sleep(50);

                // Effacer la console 

                Console.Clear();

                y = ++a;

            }
            x = ++a;
        }
    }
}