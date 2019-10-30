#include<iostream>
using namespace std;
bool FindPartition(int x[],int y[],int values[],int n)
{
    int size = (2*1000) + 1;
    int arr[size];
    for(int i = 0 ;i<size;i++)
        arr[i] = 0;
    for(int i = 0;i<n;i++)
        arr[size + x[i]] += values[i];
    for(int i = 0;i<size;i++)
        cout<<arr[i];
    for(int i = 1;i<size;i++)
        arr[i] += arr[i-1];
    if(arr[size] == 0)
    {
        cout<<"1"<<endl;
        return true;
    }
    if(arr[size] - arr[0] == 0)
    {   
        cout<<"2"<<endl;
        return true;
    }
    for(int i = 1;i<size;i++)
    {   
        //cout<<"3"<<endl;
        if(arr[i-1] == arr[size-1] - arr[i-1])
            return true;
        if(arr[i-1] == arr[size-1] - arr[i])
            return true;
        if(arr[i] == arr[size-1]-arr[i])
            return true;
    }
    if(arr[size - 2] == 0)
    {
        return true;
    }
    return false;
}
int main()
{
    int x[] = {-3,5,8};
    int y[] = {8,7,9};
    int v[] = {8,2,11};
    int n = sizeof(x)/sizeof(int);
    cout<<(FindPartition(x,y,v,n));
}