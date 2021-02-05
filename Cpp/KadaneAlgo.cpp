#include<iostream>
using namespace std;
int MaxSubArray(int a[],int n)
{
    int curr_sum = a[0]; 
    int max_sum = a[0];
    for(int i=1;i<n;i++)
    {
        curr_sum = max(a[i],curr_sum + a[i]); 
        max_sum = max(max_sum,curr_sum);
    }
    return max_sum;
}
using namespace std;
int main()
{
    int a[] = {-1,-2,-3,-4,-5};
    cout<<MaxSubArray(a,5);
}