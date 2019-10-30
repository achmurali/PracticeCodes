#include<iostream>
using namespace std;
void CountTriplets(int *arr,int n)
{
    int max_val = 0;  
    for (int i = 0; i < n; i++)  
        max_val = max(max_val, arr[i]);  
    int freq[max_val + 1];
    for(int i = 0;i<max_val;i++)
        freq[i] = 0;  
    for (int i = 0; i < n; i++)  
        freq[arr[i]]++;  
 
    int ans = 0; // stores the number of ways  

    // Case 1: 0, 0, 0  
    ans += freq[0] * (freq[0] - 1) * (freq[0] - 2) / 6;  

    // Case 2: 0, x, x  
    for (int i = 1; i < n; i++)  
        ans += freq[0] * freq[arr[i]] * (freq[arr[i]] - 1) / 2;  

    // Case 3: x, x, 2*x  
    for (int i = 1; 2 * i < n; i++)  
        ans += freq[arr[i]] * (freq[arr[i]] - 1) / 2 * freq[2 * arr[i]];  
 
    // Case 4: x, y, x + y  
    // iterate through all pairs (x, y)  
    for (int i = 1; i < n; i++) {  
        for (int j = i + 1; arr[i] + arr[j] <= max_val && j < n; j++)  
            ans += freq[arr[i]] * freq[arr[j]] * freq[arr[i] + arr[j]];  
    }  
    cout<<ans<<endl; 
}   
int main()
{
    int arr[]={ 1, 2, 3, 4, 5 };  
    int n = sizeof(arr)/sizeof(int);  
    CountTriplets(arr, n);
}