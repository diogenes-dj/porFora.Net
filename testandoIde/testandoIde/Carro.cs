namespace testandoIde
{
    internal class Carro
    {
        //As propriedades são sempre substantivos
        public string Cor { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public bool UnicoDono { get; set; }

        //Métodos são sempre verbos pq eles definem o q a classe pode fazer
       
        public void Ligar()
        {
            Console.WriteLine("BrBrBrBr");
        }

        public void Buzinar()
        {
            Console.WriteLine("BiiiiiBiiiii");
        }
    }
}
