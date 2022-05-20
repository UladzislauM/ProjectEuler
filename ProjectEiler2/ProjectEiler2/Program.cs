List<int> numFibonachi = new List<int>();
int sumFib = 2;

numFibonachi.Add(1);
numFibonachi.Add(2);

for (int i = 2; numFibonachi[i-1] < 4_000_001; i++)
{
    numFibonachi.Add(numFibonachi[i-2] + numFibonachi[i-1]);

    if (numFibonachi[i] % 2 == 0)
    {
        sumFib += numFibonachi[i];
    }
}

Console.WriteLine(sumFib);