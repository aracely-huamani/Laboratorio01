using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    internal class CajeroAutomatico : CuentaBancaria
    {
        public void ConsultarSaldo()
        {

            Console.WriteLine("Saldo actual: " + Saldo);

        }
        public void DepositarFondo(double cantidad)
        {

            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine($"Se depositaron " + cantidad + " soles en la cuenta.");
            }
            else
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
            }

        }
        public void RetirarEfectivo(double cantidad, int PinIngreso)
        {

            if (PinIngreso != PinDeSeguridad)
            {
                Console.WriteLine("PIN incorrecto. Transacción cancelada.");
                return;
            }

            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
                return;
            }

            if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar el retiro.");
                return;
            }

            Saldo -= cantidad;
            Console.WriteLine($"Se retiraron " + cantidad+ " de la cuenta.");

        }
        public void CambiarPin(int pinActual, int nuevoPin)
        {
            if (pinActual != PinDeSeguridad)
            {
                Console.WriteLine("PIN incorrecto. No se puede cambiar el PIN.");
                return;
            }

            if (nuevoPin == PinDeSeguridad)
            {
                Console.WriteLine("El nuevo PIN no puede ser igual al PIN actual.");
                return;
            }

            PinDeSeguridad = nuevoPin;
            Console.WriteLine("Se cambio el PIN exitosamente.");
        }


    }
}

