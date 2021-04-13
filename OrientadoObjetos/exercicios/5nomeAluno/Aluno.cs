namespace _5nomeAluno
{
    public class Aluno
    {
        public string Nome;

        public double Primeiro, Segundo, Terceiro;
        
        public double NotaFinal()
        {
            return Primeiro + Segundo + Terceiro;
        }
        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}