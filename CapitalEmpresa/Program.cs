// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** CAPITAL EMPRESA ** ");
Console.WriteLine(" ");

double monto1, monto2, monto3;

Console.WriteLine("Ingrese monto socio 01: C$");
monto1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese monto socio 02: C$");
monto2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese monto socio 03: C$");
monto3 = double.Parse(Console.ReadLine());

double capital = monto1 + monto2 + monto3;

double pSocio1 = (monto1 * 100) / capital;
double pSocio2 = (monto2 * 100) / capital;
double pSocio3 = (monto3 * 100) / capital;
Console.WriteLine("-----------------------------------");
Console.WriteLine("CAPITAL: C$ " + capital.ToString("0.00"));
Console.WriteLine("PORCENTAJE SOCIO 1: " + pSocio1.ToString("0.00"));
Console.WriteLine("PORCENTAJE SOCIO 2: " + pSocio2.ToString("0.00"));
Console.WriteLine("PORCENTAJE SOCIO 3: " + pSocio3.ToString("0.00"));