// See https://aka.ms/new-console-template for more information



using Laboratorio01;
using System.Net.Http.Headers;

CajeroAutomatico cajero = new CajeroAutomatico
{
    NumeroDeCuenta = 8738302,
    Titular = "Aracely",
    Saldo = 1500.45,
    PinDeSeguridad = 010604
};

bool salir = false;

while (!salir)
{
    Console.WriteLine("1. Consultar Saldo");
    Console.WriteLine("2. Depositar Fondos");
    Console.WriteLine("3. Retirar Efectivo");
    Console.WriteLine("4. Cambiar PIN");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            cajero.ConsultarSaldo();
            break;
        case 2:
            Console.Write("Ingrese la cantidad a depositar: ");
            double cantidadDeposito = Convert.ToDouble(Console.ReadLine());
            cajero.DepositarFondo(cantidadDeposito);
            break;
        case 3:
            Console.Write("Ingrese la cantidad a retirar: ");
            double cantidadRetiro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese su PIN: ");
            int pinRetiro = Convert.ToInt32(Console.ReadLine());
            cajero.RetirarEfectivo(cantidadRetiro, pinRetiro);
            break;
        case 4:
            Console.Write("Ingrese su PIN actual: ");
            int pinActual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nuevo PIN: ");
            int nuevoPin = Convert.ToInt32(Console.ReadLine());
            cajero.CambiarPin(pinActual, nuevoPin);
            break;
        case 5:
            salir = true;
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    Console.WriteLine();
}