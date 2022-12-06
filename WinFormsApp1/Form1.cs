namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string textoTelegrama;
                char tipoTelegrama = 'o';
                int numPalabras = 0;
                double coste = 0;

                //Leo el telegrama
                textoTelegrama = txtTelegrama.Text;
                // telegrama urgente?
                if (cbUrgente.Checked)
                    tipoTelegrama = 'u';

                //Obtengo el número de palabras que forma el telegrama
                numPalabras = textoTelegrama.Split (" ").Length;
                //Si el telegrama es ordinario

                if (tipoTelegrama == 'o')
                    if (numPalabras <= 10)
                        coste = 2.5;
                    else
                        coste = 0.5 * numPalabras;
                else
                
                //Si el telegrama es urgente
                if (tipoTelegrama == 'u')
                    if (numPalabras <= 10)
                        coste = 2.5;
                    else
                        coste = 5 + 0.75 * (numPalabras - 10);
                else
                    coste = 5;
                txtPrecio.Text = coste.ToString() + " euros";
            
        }
    }
}