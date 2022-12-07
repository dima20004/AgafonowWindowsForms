namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            buttonFill.Visible = true;
            button1.Visible = true;
        }
        public int m, n;
        public int[,] arr;

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
          
              try
            {
                m = Convert.ToInt32(textBoxN.Text);
                n = Convert.ToInt32(textBoxM.Text);

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    }
                }
                int min = arr[0,0];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (min > arr[i, j]) { min = arr[i, j]; }
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {//i++    i = i+1
                        if (arr[i, j] == min) { richTextBox2.AppendText($"{i+1},{j+1} "); }
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        richTextBox1.AppendText($"{arr[i,j]} ");
                    }
                    richTextBox1.AppendText("\n");
                }
               
            }
            catch
            {
              MessageBox.Show("¬ведите число!");
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "";
            textBoxN.Text = "";
            dataGridView1.RowCount=0;
            dataGridView1.ColumnCount = 0;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            buttonFill.Enabled=false;
            dataGridView1.Visible=false;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxN.Text) < 1 || Convert.ToInt32(textBoxM.Text) < 0)
            {
                MessageBox.Show("¬ведите корректные размеры массива!");
                textBoxM.Text = "";
                textBoxN.Text = "";
            }
            else
            {
                try
                {
                    buttonFill.Enabled = true;
                    dataGridView1.Visible = true;
                    m = Convert.ToInt32(textBoxN.Text);
                    n = Convert.ToInt32(textBoxM.Text);
                    arr = new int[m, n];
                    dataGridView1.RowCount = m;
                    dataGridView1.ColumnCount = n;

                }
                catch
                {
                    MessageBox.Show("ќшибка!");
                }
            }
        }
    }
}