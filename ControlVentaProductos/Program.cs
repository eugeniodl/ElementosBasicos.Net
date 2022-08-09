// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** CONTROL DE VENTA DE PRODUCTOS ** ");
Console.WriteLine(" ");

double precio;
int cantidad;

Console.WriteLine("Ingrese precio del producto: C$ ");
precio = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese cantidad comprada: ");
cantidad = int.Parse(Console.ReadLine());

double importe = cantidad * precio;
double descuento = 11 / 100.0 * importe;
double total = importe - descuento;

Console.WriteLine("---------------------------------------------");
Console.WriteLine("IMPORTE TOTAL: C$ " + importe.ToString("0.00"));
Console.WriteLine("DESCUENTO: C$ " + descuento.ToString("0.00"));
Console.WriteLine("TOTAL A PAGAR: C$ " + total.ToString("0.00"));