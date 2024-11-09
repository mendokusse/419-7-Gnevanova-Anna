using Microsoft.Data.SqlClient;

namespace BookingApp
{
    internal static class Program
    {
        public static SqlConnection connection = new SqlConnection("Server=94.241.174.143;Database='bookingresort'" +
            ";User Id='sa';Password='<CK6d/ehm>';TrustServerCertificate=True;");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogScreen());
        }
    }
}