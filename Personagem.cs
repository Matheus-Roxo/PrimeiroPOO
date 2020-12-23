namespace PrimeiroPOO
{
    public class Personagem
    {
        public string nome;

        public int idade;

        public string armadura;
        public string Atacar(){
            return "Ataque!";
        }

        public string Defender(){
            return "Defendido!";
        }
    }
}