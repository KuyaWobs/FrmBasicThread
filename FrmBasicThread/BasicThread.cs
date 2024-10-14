namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyThreadClass myThreadClass = new MyThreadClass();
            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "Thread Process A ";
            ThreadB.Name = "Thread Process B ";

            Console.WriteLine("-Before Starting Thread-");
            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = ("-End of Thread-");

        }
    }
}


