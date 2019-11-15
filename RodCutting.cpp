#include<iostream>
using namespace std;
int cutRod(int arr[],int size)
{   
    if(size <= 0)
        return 0;
    int maxl = -1; 
    for(int i = 0;i<size;i++)
    {    
        maxl = max(maxl,arr[i] + cutRod(arr,size-i-1)); 
    }
    return maxl;
}
int cutRodDP(int arr[],int size)
{
    
}
int main()
{
    int arr[] = {1, 5, 8, 9, 10, 17, 17, 20}; 
    int size = sizeof(arr)/sizeof(arr[0]); 
    printf("Maximum Obtainable Value is %d", cutRod(arr, size)); 
    getchar(); 
    return 0;
}