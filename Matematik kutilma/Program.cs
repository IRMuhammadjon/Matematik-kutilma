double  a, b=0, c;
int n;
Console.WriteLine("nechhi marta takrorlansin: ");
n = int.Parse(Console.ReadLine());

for(int i=0; i < n; i++)
{
    a = (i + 1) * Math.Pow((2/Math.PI),(i+1));
    b = b + a;
    
}
Console.WriteLine("Matematik kutilmamiz M(x) = " + b);
