using System.Globalization;

namespace verificaDiRipasso
{
    public partial class cifra : Form
    {
        List<string> Lettura = new List<string>();
        string alfabeto = "abcdefghijklmnopqrstuvwxyz";
        
        public cifra()
        {
            InitializeComponent();

        }
        private void converti_Click_1(object sender, EventArgs e)
        {
            char[] alfa = alfabeto.ToCharArray();
            int l = 0;
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                while (!sr.EndOfStream)
                {
                    l++;
                    string riga = sr.ReadLine();
                    Lettura.Add(riga);
                }
                
            }
            string parola;
            
            for (int i = 0; i < Lettura.Count; i++)
            {
                if (i % 2 != 0 && i != 0)
                {
                    
                    Lettura[i].ToLower();
                    parola = Lettura[i];
                    parola.Split();
                    char[] pa = parola.ToCharArray();
                    for (int k = 0; k < pa.Length; k++)
                    {
                        
                    }
                    lista.Items.Add(Lettura[i]);

                }
                else
                {
                }
            }

        }
    }
}
