namespace exercice_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO 1 : À l'aide du diagramme fourni, déclarer l'interface IFacturable
            // TODO 2 : À l'aide du diagramme fourni, définir les classes CommandeLivraison et SessionJeu qui implémentent IFacturable


            // TODO 3a : Ajouter dans la liste fournie :
            //   - CommandeLivraison  id:"McDo",    prix:3.50$/article, livraison:6.00$
            //   - SessionJeu         id:"Fortnite", tarif:4.00$/h,     abonné:false
            //   - CommandeLivraison  id:"Subway",  prix:8.00$/article, livraison:4.00$
            //   - SessionJeu         id:"GamePass", tarif:5.00$/h,     abonné:true

            List<IFacturable> depenses = new List<IFacturable>();

             CommandeLivraison commande =new CommandeLivraison( "McDo", 3.50, 6.00);
            CommandeLivraison commandes = new CommandeLivraison("Subway", 8.00, 4.00);

            SessionJeu session = new SessionJeu("Fortnite",4.00, false);
            SessionJeu session2 = new SessionJeu("GamePass", 5.00, true);

            depenses.AddRange(new List<CommandeLivraison> {commande, commandes});
            depenses.AddRange(new List<SessionJeu> { session,session2 });







            // TODO 3b : Décommentez le code suivant pour vérifier le comportement de votre programme

            int[] quantites = { 3, 2, 5, 4 };

            double coutTotal = 0;

            for (int i = 0; i < depenses.Count; i++)
            {
                Console.WriteLine(depenses[i].ImprimerFacture(quantites[i]));
                coutTotal += depenses[i].CalculerCout(quantites[i]);
            }

            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine($"Coût total : {coutTotal:F2}$");


            //Résultat attendu :

            //    Commande McDo — 3 article (s) => 16.50$
            //    Session Fortnite(Standard) — 2h => 8.00$
            //    Commande Subway — 5 article (s) => 40.00$ (livraison offerte)
            //    Session GamePass(Abonné) — 4h => 16.00$
            //    ─────────────────────────────────
            //    Coût total : 80.50$

        }
    }
}
