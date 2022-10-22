namespace JSONinCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            var Nomes = new Nomes();
            Nomes.NomeCompleto = txtNomes.Text;

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
                    txtList.Text = Nomes.NomeCompleto;
                txtNomes.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail" + ex.Message);
            }
        }
    }
}