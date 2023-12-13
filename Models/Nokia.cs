namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            string animacao;
            for (int i = 0; i < 20; i++) //Pequena animação
            {
                Console.WriteLine($"Instalando \"{nomeApp}\" no Nokia");
                Console.WriteLine(animacao = new string('.', i));
                Thread.Sleep(800);
                Console.Clear();
            }
            Console.WriteLine($"\"{nomeApp}\" instalado com sucesso no Nokia");
        }
    }

}

