using System.Windows.Forms;

namespace TenThousEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //RandList randList = new RandList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OptionAndControlWindow());
            
        }
    }
}
