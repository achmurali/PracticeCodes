/* Naive Approach */
// #include<iostream>
// using namespace std;
// int knapSack(int W,int weight[],int val[],int n)
// {   
//     if (n == 0 || W == 0) 
//     {
//         return 0;
//     }
//     if(weight[n-1] > W)
//         return knapSack(W,weight,val,n-1);
//     else
//         return max(val[n-1] + knapSack(W - weight[n-1],weight,val,n-1),knapSack(W,weight,val,n-1)); 
    
// }
// int main()
// {
//     int val[] = {60, 100, 120};  
//     int wt[] = {10, 20, 30};  
//     int W = 50;  
//     int n = sizeof(val)/sizeof(val[0]);  
//     cout<<knapSack(W, wt, val, n);  
//     return 0; 
// }

//Dynamic Programming Approach
#include<iostream>
using namespace std;
int knapSack(int W,int weight[],int val[],int n)
{
    int K[n+1][W+1];
    for(int i = 0;i<=n;i++)
    {
        for(int j = 0; j <= W ;j++)
        {
            if( i == 0 || j == 0)
            {
                K[i][j] = K[i-1][j]; 
            }
            else if(weight[i - 1] > W)
            {
                K[i][j] = 0;
            }
            else
            {
                K[i][j] = max(val[i-1] + K[i-1][j - weight[i-1]],K[i-1][j]);
            }
            
        }
    }
    return K[n][W]; 
}
int main()
{
    int val[] = {60, 100, 120};  
    int wt[] = {10, 20, 30};  
    int W = 50;  
    int n = sizeof(val)/sizeof(val[0]);  
    cout<<knapSack(W, wt, val, n);  
    return 0; 
}