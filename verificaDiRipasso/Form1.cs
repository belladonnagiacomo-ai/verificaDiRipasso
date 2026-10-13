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
            bool ver = false;
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                while (!sr.EndOfStream)
                {
                    l++;
                    string riga = sr.ReadLine();
                    Lettura.Add(riga);
                }
                
            }
            int b = 0;
            string pa = "";
            for (int i = 0; i < Lettura.Count; i = i++)
            {
                char[] parola = Lettura[i].ToCharArray();

                for(int a = 0;  a < parola.Length; a++)
                {
                    b = 0;
                    while (parola[a] != alfa[b])

                    {
                        b++;
                    }
                    if(b > 2)
                    {
                        b -= 3;
                    }
                    else
                    {
                        b = alfa.Length - (3 - b);
                    }
                    parola[a] = alfa[b];
                    for(int m = 0; m < parola.Length; m++)
                    {
                        pa = pa + parola[m];
                    }
                    lista.Items.Add(pa);

                }



            }


        }
    }
}
