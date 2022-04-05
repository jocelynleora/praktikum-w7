namespace praktikum_w7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_konversi_Click(object sender, EventArgs e)
        {
            char awal = Convert.ToChar(tbox_hurufAwal.Text);
            char akhir = Convert.ToChar(tbox_hurufAkhir.Text);
            int selisih = akhir - awal;
            if(selisih < 0)
            {
                selisih += 26;
            }
            var letters = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
            char[] letter = letters.ToUpper().ToCharArray();
            char[] input = tbox_input.Text.ToUpper().ToCharArray();
            int hasil = awal + selisih;
            int panjangInput = tbox_input.TextLength;
            string output = "";
            for (int i=0; i< panjangInput; i++)
            {
                if (input[i] == ' ')
                {
                    output += input[i];
                }
                for (int j=0; j<26; j++)
                {
                    if (input[i] == letter[j])
                    {
                        output += letter[j + selisih];
                    }
                }
            }
            lbl_output.Text = output.ToUpper();
        }
    }
}