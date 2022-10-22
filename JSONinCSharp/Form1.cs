namespace JSONinCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Nomes> listaNomes = new List<Nomes>(); 

        private void txtAdd_Click(object sender, EventArgs e)
        {
            var Nomes = new Nomes();
            Nomes.NomeCompleto = txtNomes.Text;
            listaNomes.Add(Nomes);

            if (Nomes.JsonSerializarLista(listaNomes, @"C:\Users\Eduardo9\source\repos\JSONinCSharp\lista.json"))
            {
                MessageBox.Show("Save");
            }

            listaNomes = Nomes.JsonDesserializarLista(@"C:\Users\Eduardo9\source\repos\JSONinCSharp\lista.json");
            dtExibe.DataSource = listaNomes;
            txtList.Text = (listaNomes);
            #region old code
            /*
            try
            {
                using(StreamWriter sw = new StreamWriter(@"C:\Users\Eduardo9\source\repos\JSONinCSharp\lista.json"))
                {
                    sw.WriteLine(Nomes.JsonSerializar(Nomes));
                }
                MessageBox.Show("Salvo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail" + ex.Message);

            }

            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(@"C:\Users\Eduardo9\source\repos\JSONinCSharp\lista.json")) {
                    strJson = sr.ReadToEnd();
                
                }
                var nome = Nomes.JsonDesserializar(strJson);
                dtExibe.DataSource = null;
                dtExibe.DataSource = listaNomes;
                txtNomes.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail" + ex.Message);
            }
            */
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaNomes = Nomes.JsonDesserializarLista(@"C:\Users\Eduardo9\source\repos\JSONinCSharp\lista.json");
            dtExibe.DataSource = listaNomes;
           
        }
    }
}