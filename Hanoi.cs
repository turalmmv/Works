using System;
class GFG
{
    static void towerOfHanoi(int n, char from_rod,char to_rod, char helper_rod)
    {
        if (n == 0)
        {
            return;
        }
        towerOfHanoi(n - 1, from_rod, helper_rod, to_rod);
        Console.WriteLine("Move disk " + n + " from rod " + from_rod + " to rod " + to_rod);
        towerOfHanoi(n - 1, helper_rod, to_rod, from_rod);
    }
    public static void Main(String[] args)
    {
        int N = 3;

        towerOfHanoi(N, 'A', 'C', 'B');
    }
}