int katet1 = 3;
int katet2 = 4;
int gipatenuza = 5;

double gip2 = (katet1*katet1) + (katet2*katet2);  // гипотенуза в квадрате
double gip = Math.Sqrt(gip2);
Console.WriteLine(gip);

double kat2 = (gipatenuza*gipatenuza) - (katet2*katet2);  // катет 2-ой в квадрате
double kat = Math.Sqrt(kat2);
Console.WriteLine(kat);