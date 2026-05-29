using static System.Net.Mime.MediaTypeNames;

namespace exercice_heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO 1 : À l'aide du diagramme fourni, définir la classe abstraite Personnage
            // TODO 2 : À l'aide du diagramme fourni, définir les classes Guerrier et Mage qui héritent de Personnage



            // TODO 3a : Ajouter les personnages suivants à la liste fournie :
            //   - Guerrier  nom:"Gimli",   pv:75,  force:10
            //   - Mage      nom:"Gandalf",  pv:100,   potions:0
            //   - Guerrier  nom:"Aragorn",  pv:90,  force:8
            //   - Mage      nom:"Saroumane",     pv:85,   potions:15

            List<Personnage> equipe = new List<Personnage>();

            Personnage personnage = new Guerrier("Gimli",75,10);
            Personnage personnage1 = new Mage("Gandalf", 100,0);
            Personnage personnage2 = new Guerrier("Aragorn", 90, 0);
            Personnage personnage3 = new Mage("Saroumane", 85, 15);

            equipe.Add(personnage);
            equipe.Add(personnage1);
            equipe.Add(personnage2);
            equipe.Add(personnage3);






            // TODO 3b : Décommentez le code suivant pour vérifier le comportement de votre programme.

            foreach (Personnage p in equipe)
                Console.WriteLine(p.Etat());

            Personnage champion = equipe[0];
            foreach (Personnage p in equipe)
            {
                if (p.atatquer() > champion.atatquer())
                    champion = p;
            }

            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine($"Champion : {champion.Nom} avec {champion.atatquer()} dégâts!");


            // Résultat attendu :

            //      Nom: Gimli | PV : 75 | Force : 10
            //      Nom: Gandalf | PV : 100 | Potions : 0
            //      Nom: Aragorn | PV : 90 | Force : 8
            //      Nom: Saroumane | PV : 85 | Potions : 5
            //      ─────────────────────────────────
            //      Champion: Saroumane avec 30 dégâts!








            // TODO 4 : Parcourir la liste de personnages. Pour chaque Personnage p dans la liste,
            //          utiliser l'opérateur "is" de manière appropriée pour afficher :
            //
            //          "[Nom] a une force de [Force]" si p est un Guerrier
            //          "[Nom] a [NbPotions] potions" si p est un Mage
            
            foreach(Personnage p in equipe)
            {
                if(p is Guerrier g)
                {
                    if (p is Guerrier )
                        Console.WriteLine($"{g.Nom} a une force de {g.force}");
                    else if (p is Mage m)
                        Console.WriteLine($"{m.Nom} a {m.NbPotion} potions");
                }
            }
            //  Résultat attendu :

            //      Gimli a une force de 10
            //      Gandalf a 0 potions
            //      Aragorn a une force de 8
            //      Saroumane a 15 potions

        }
    }
}
