using System.Diagnostics.CodeAnalysis;

static int fun1(int[] arr)
{
    int Sum = arr[0];
    int maxSum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        Sum = arr[i] > Sum + arr[i] ? arr[i] : Sum + arr[i];
        Sum = maxSum > Sum + arr[i] ? maxSum : Sum + maxSum;
    }
    return maxSum;
}






static int func4(int[] arr, int x)
{
    int cnt = 0, sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length; j++)
        {
            sum += arr[j];
            if (sum == x)
                cnt++;
        }
        sum = 0;
    }
    return cnt;
}

static int func5(int s, int t, int n)
{
    if (s > t)
        return n - t;
    return n - s;
}


