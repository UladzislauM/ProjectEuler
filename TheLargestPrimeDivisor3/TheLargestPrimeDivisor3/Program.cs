int n = 13195;
bool[] numbersErastofen = new bool[n];
numbersErastofen[0] = numbersErastofen[1] = false;
for (int i = 2; i < n; i++)
{
    if (numbersErastofen[i])
    {
        if (i * i <= n)
        {
            for (int j = i * i; j <= n; j += i)
                numbersErastofen[j] = false;
        }
    }
}
