int iterations = 0;

for (int a = 999; a >= 0; a--)
{
    string SNumberLeft = a.ToString();
    string SNumberRight = Reverse(a.ToString());
    int aR = Convert.ToInt32(SNumberRight);

    int R = a * 1000 + aR;
    int b = 999;
    int s = R / b;

    while (b >= s)
    {
        iterations++;
        if (R == b * s)
        {
            Console.WriteLine($"multiplier 1 = {s}; multiplier = 2 = {b}; polindrom = {R} iteration = {iterations}");
            return;
        }
        else
        {
            b--;
            s = R / b;
        }
    }
}

string Reverse(String s)
{
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}