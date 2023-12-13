namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            string animacao;
            for (int i = 0; i < 20; i++) //Pequena animação
            {
                Console.WriteLine($"Instalando \"{nomeApp}\" no Iphone");
                Console.WriteLine(animacao = new string('.', i));
                Thread.Sleep(800);
                Console.Clear();
            }
            Console.WriteLine($"\"{nomeApp}\" instalado com sucesso no Iphone");
        }
    }
}