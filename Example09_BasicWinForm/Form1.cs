namespace Example09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            //this.DoubleClick += Form1_DoubleClick;
            this.Click += Form1_Click;
            this.MouseMove += Form1_MouseMove;

            //Buttons 
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

            //Dinamik bir nesne üretmek
            Label label = new Label();
            label.Width = 100;
            label.Height = 100;
            label.Text = "Buraya gelecek.";
            label.Left = label.Left + 400;
            this.Controls.Add(label);

            CheckBox cb = new CheckBox();
            cb.Text = "Seç";
            cb.Name = "checkbox";
            cb.Width = 200;
            cb.Height = 200;
            cb.Left = cb.Width + 100;
            cb.Click += delegate (object sender, EventArgs e)
            {
                if (cb.Checked)
                {
                    label.Text = "Seçildi.";
                }
                else
                {
                    label.Text = "Seçilmedi.";
                }
            };

            this.Controls.Add(cb);

            Button btn = new Button();
            btn.Text = "OK";
            btn.Name = "btnOK";
            btn.Width = 100;
            btn.Height = 100;
            btn.Left = btn.Width + 10;

            btn.Click += delegate (object sender, EventArgs e)
            {
                string msg = (sender as Button).Text;
                MessageBox.Show(msg);


            };

            this.Controls.Add(btn);

            //Lambda Expressions
            Del myDelegate = x => x * x;
            //MessageBox.Show(myDelegate(5).ToString());
            this.Click += (s, e) => { MessageBox.Show("X: " + ((MouseEventArgs)e).Location.ToString()); };

        }

        delegate int Del(int a);
        int Hesapla(int x, int y)
        {
            return x * x;
        }
        private void Form1_Click(object? sender, EventArgs e)
        {
            //var result = ((MouseEventArgs)e).Location.ToString(); // Form'u baz alir.
            //MessageBox.Show(result);
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            //MessageBox.Show("Hareket " + System.Windows.Forms.Cursor.Position); //Ekrani baz alir.
            //var result = ((MouseEventArgs)e).Location.ToString(); // Form'u baz alir.
            //MessageBox.Show(result);
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            //this.DoubleClick -= Form1_DoubleClick;

        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            //this.DoubleClick += Form1_DoubleClick;


        }

        void Form1_DoubleClick(object? sender, EventArgs e)
        {
            MessageBox.Show("Double click");
        }

        void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Loaded!");
        }
    }
}