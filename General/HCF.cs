// Program to find the HCF of two numbers using Euclidean Algo

class Program
{   public static int FindHCF(int a, int b)
    {
        if( b == 0)
            return a;
        return FindHCF(b, a % b);
    }
}
