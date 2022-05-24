int n = 13195;
long nn = 600851475143;
bool[] sinpleNumbers = new bool[n];
List<long> numOK = new();
sinpleNumbers[0] = sinpleNumbers[1] = true;

for (int i = 2; i < n; i++)
{
    if (!sinpleNumbers[i])
    {
        for (int j = i; j < n; j++)
        {
            if (j % i == 0 && i != j)
            {
                sinpleNumbers[j] = true;
            }
        }
    }
}

for (int i = 0; i < n; i++)
{
    while (!sinpleNumbers[i] && nn % i == 0 && nn != 0)
    {
            nn /= i;
            numOK.Add(i);
    }
    if(nn == 1 || nn == 0)
    {
        break;
    }
}

foreach (var item in numOK)
{
    Console.WriteLine(item);
}