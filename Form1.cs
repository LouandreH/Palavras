namespace PALAVRAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContarP_Click(object sender, EventArgs e)
        {
            
            string escrever = textEscrever.Text;
            string[] palavras = escrever.Split(' ');
            int totalDePalavra = palavras.Length;

            textResultado.Text = totalDePalavra.ToString();

            MessageBox.Show("Numero de Palavras é: "+ textResultado.Text);

            textEscrever.Clear();
            textResultado.Clear();
        }

        private void btnContarL_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            string texto = textEscrever.Text.Replace(" ", string.Empty);

            MessageBox.Show("Numer de letras é: " + texto.Length);


            textEscrever.Clear();




        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            
            textResultado.Text = textEscrever.Text.ToUpper();

           
        }

        private void btnMinu_Click(object sender, EventArgs e)
        {
            
            textResultado.Text = textEscrever.Text.ToLower();
            
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            string[] palavra = textEscrever.Text.Split();
            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                textResultado.Text += palavra[i] + " ";
            }
        }

        private void btnInveterL_Click(object sender, EventArgs e)
        {
            textResultado.Text = " ";
            string guarda = string.Empty;
            char[] palavra = textEscrever.Text.ToCharArray();
            for (int i = palavra.Length -1; i >=0; i--)
            {
                guarda += palavra[i];
            }
            textResultado.Text = guarda;
        }

        private void btnQuebrar_Click(object sender, EventArgs e)
        {
            string escrever = textEscrever.Text;
            string palavras = escrever.Replace(" ", Environment.NewLine);


            textResultado.Text = palavras.ToString();
        }

        private void btnEmba_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            Random random = new Random();
            List<string> listaDeEntrada = textEscrever.Text.Split().ToList();
            List<string> listaSaida = new List<string>();
            while ( listaDeEntrada.Count > 0 )
            {
                var valorEntrada = listaDeEntrada[random.Next(listaDeEntrada.Count)];
                listaSaida.Add(valorEntrada.ToString());

                if (listaDeEntrada.Contains(valorEntrada)
                ) listaDeEntrada.Remove(valorEntrada);

                textResultado.Text += valorEntrada + " ";
            }
        }

        private void btnEmbarL_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            Random random = new Random();
            char[] charArray = textEscrever.Text.ToCharArray();
            string valor = string.Empty;

            charArray = charArray.OrderBy(c => random.Next()).ToArray();

            foreach (var i in charArray)
                if (i != ' ')
                {
                
                    valor += i;
                textResultado.Text = valor;

            }
            else
            {
                    valor.Replace(" ", string.Empty);
            }
        }   

            
            

            
        
    }
}