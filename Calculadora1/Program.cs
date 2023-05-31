namespace Calculadora1
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new CalculadoraEstudo());
        }
        public static void IntNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


    }
}