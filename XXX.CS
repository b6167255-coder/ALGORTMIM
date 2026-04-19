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






static int func3(int[] arr)
{
    if (arr == null || arr.Length <= 1)
        return 0;

    int n = arr.Length;

    int[] tails = new int[n];
    int length = 0; 

    foreach (int num in arr)
    {
        int pos = Search(tails, 0, length, num);

        tails[pos] = num;

        if (pos == length)
            length++;
    }

    return n - length;
}

static int Search(int[] arr, int start, int end, int val)
{
    int left = start;
    int right = end;

    while (left < right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] <= val)
            left = mid + 1;
        else
            right = mid;
    }

    return left;
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


public class class2
{
    private Dictionary<int, (int value, long timestamp)> data;
    private int setAllValue;
    private long setAllTime;
    private long currentTime;

    public class2()
    {
        data = new Dictionary<int, (int, long)>();
        setAllValue = 0;
        setAllTime = 0;
        currentTime = 0;
    }

    public void Set(int key, int val)
    {
        currentTime++;
        data[key] = (val, currentTime);
    }

    public int? Get(int key)
    {
        if (!data.ContainsKey(key))
        {
            if (setAllTime > 0)
                return setAllValue;
            return null;
        }

        var (value, timestamp) = data[key];

        if (timestamp > setAllTime)
            return value;

        return setAllValue;
    }

    public void SetAll(int val)
    {
        currentTime++;
        setAllValue = val;
        setAllTime = currentTime;
    }
}