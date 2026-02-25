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

public class class2
{
            private Dictionary<int, (int value, long timestamp)> data;
            private int setAllValue;
            private long setAllTime;
            private long currentTime;
            
            public SetAll()
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
            
            public int Get(int key)
            {
                if (!data.ContainsKey(key))
                {
                    if (setAllTime > 0)
                        return setAllValue;
                    return;
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
        
using System;
using System.Collections.Generic;

public class LinkedListNode
{
    public int Value;
    public LinkedListNode Next;
    public LinkedListNode(int val) { Value = val; }
}

    public static int MinRemovals(LinkedListNode head)
    {
        List<int> nums = new List<int>();
        while (head != null)
        {
            nums.Add(head.Value);
            head = head.Next;
        }

        if (nums.Count == 0) return 0;

        List<int> tails = new List<int>();
        
        foreach (int x in nums)
        {
            int left = 0, right = tails.Count;
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (tails[mid] <= x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            
            if (left == tails.Count)
                tails.Add(x);
            else
                tails[left] = x;
        }
        
        return nums.Count - tails.Count;
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


