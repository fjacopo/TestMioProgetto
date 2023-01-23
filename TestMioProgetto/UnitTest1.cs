using bacheca_pausaidattica;
namespace TestMioProgetto
{
    public class UnitTest1
    {
        Promemoria p;
        Bacheca b;

        [Fact]
        public void Test1()
        {
            
            b = new Bacheca("bacheca", "ciao belo", "jacopo");
            Assert.True(b.getPromemoria(10) == null);

        }
    
        
        [Fact]
        public void TestOttieniPromemoriaConNome()
        {
            p = new Promemoria("efghijkl", "20/01/2015");
            Promemoria p2 = new Promemoria("qualcosa", "data");
            string str = "qualcosa";
            b = new Bacheca("bacheca", "ciao belo", "jacopo");
            b.Aggiungi(p);
            b.Aggiungi(p2);

            string[] test = { p.P, p2.P, "?????" };
            string[] risultato = b.getPromemoriaConParola(str, test); 
            Assert.True(risultato != null);
        }

        [Fact]
        public void TestOttieniPromemoriaConData()
        {
            string str = "20/20/1000";
            p = new Promemoria("qualcosa da fare", "datafalsa");
            Promemoria p1 = new Promemoria("qualcosa da fare", str);
            b = new Bacheca("bacheca", "ciao belo", "jacopo");

            string[] test = { p.Data, str, p1.Data, "?????", "111111" };
            string[] risultato = b.getPromemoriaConData(str, test);
            Assert.True(risultato != null);

        }

        [Fact]
        public void TestElimina()
        {
            p= new Promemoria("abcdefg", "23/01/2023");
            b = new Bacheca("bacheca", "ciao belo", "jacopo");

            b.Aggiungi(p);
            b.Rimuovi(p);

            Assert.True(b.getPromemoria(1) != p);
            Assert.True(b.getPromemoria(1) == null);
        }

        [Fact]
        public void TestSposta()
        {
            p = new Promemoria("qualcosa", "23/01/2023");
            b= new Bacheca("bacheca", "ciao belo", "jacopo");
            Bacheca b1 = new Bacheca("ahhhhhha", "ciao beloooooo", "jacopo");

            b.Aggiungi(p);
            b.Sposta(b1, p);

            Assert.True(b.getPromemoria(1) == null);
            Assert.False(b1.getPromemoria(1) == p);
        }
    }
}