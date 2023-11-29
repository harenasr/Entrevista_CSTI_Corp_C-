using System;
using System.IO.Ports;

namespace Entrevista_CSTI_Corp_C
{
    internal class SerialExampleCSharp
    {
        static void Main()
        {
            SerialPort serialPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);

            try
            {
                serialPort.Open();
                Console.WriteLine("Esperando mensaje...");

                string receivedMessage = serialPort.ReadLine();
                Console.WriteLine("Mensaje recibido: " + receivedMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                serialPort.Close();
            }
        }
    }
}
