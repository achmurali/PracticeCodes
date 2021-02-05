#include<iostream>
using namespace std;
bool isSubsetSum(int arr[],int n,int sum)
{
    if(sum == 0)
        return true;
    if( n==0 && sum!=0 )
        return false;
    else if(sum < arr[n-1])
        return isSubsetSum(arr,n-1,sum);
    else
    {
        return isSubsetSum(arr,n-1,sum - arr[n-1]) || isSubsetSum(arr,n-1,sum); 
    }
}
bool isSubSetSumDP(int arr[],int n,int sum)
{
    bool set[n+1][sum+1];

    for(int i = 0;i<sum;i++)
        set[0][i] = false;
    for(int i = 0;i<n;i++)
        set[i][0] = true;
    for(int i = 1;i<=n;i++)
    {
        for(int  j = 1;j<=sum;j++)
        {
            if( j < arr[i-1])
                set[i][j]  = set[i-1][j];
            else if(j >= arr[i-1])
            {
                set[i][j] = set[i-1][j] ||  
                                set[i - 1][j-arr[i-1]];  
            }
        }
    }
    return set[n][sum];
}
int main()
{
    int set[] = {3, 34, 4, 12, 2, 2}; 
    int sum = 9; 
    int n = sizeof(set)/sizeof(set[0]); 
    if (isSubSetSumDP(set, n, sum) == true) 
        printf("Found a subset with given sum"); 
    else
        printf("No subset with given sum"); 
    return 0;
}