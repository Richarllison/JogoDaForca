
namespace JogoDaForca;

public class Palavra
{
    private string palavra;
    private Categoria numCategoria;

    public Palavra()
    {
        using (StreamReader lendo = new StreamReader(@"/home/richarlison/RiderProjects/JogoDaForca/palavras.csv"))
        {
            string linha;
            List<string> listaPalavrasPossiveis = new List<string>();
            
            Random num = new Random();
            this.numCategoria = (Categoria)num.Next(4);

            while ((linha = lendo.ReadLine()) != null)
            {
                string[] splitted = linha.Split(';');

                if (this.numCategoria.Equals((Categoria) Int16.Parse(splitted[1])))
                {
                    listaPalavrasPossiveis.Add(new string(splitted[0]));
                }
            }
            this.palavra = new string(listaPalavrasPossiveis[num.Next(3)]);
        }
    }
    public string Palavra1 => palavra;

    public Categoria NumCategoria => numCategoria;
}