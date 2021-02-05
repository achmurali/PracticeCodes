#include<iostream>
#include<unordered_map>
using namespace std;
int partition(string arr[],int l,int r,unordered_map<string,int>& hash)
{
    int pivot = l;
    int i = l;
    for(int j = l+1;j<r;j++)
    {
        if(hash[arr[j]] < hash[arr[pivot]])
        {
            i+=1;
            swap(arr[j],arr[i]);
        }
    }
    swap(arr[pivot],arr[i]);
    return i;
}
void quickSort(string arr[],int l,int r,unordered_map<string,int>& hash)
{   
    if(l < r)
    {
    int pivot = partition(arr,l,r,hash);
    quickSort(arr,l,pivot-1,hash);
    quickSort(arr,pivot+1,r,hash);
    }
}
void SortColoredBalls(string arr[],int n)
{
    unordered_map<string,int> hash;
    hash["blue"] = 1;
    hash["green"] = 2;
    hash["yellow"] = 3;
    quickSort(arr,0,5,hash);
    for(int i = 0;i < 5;i++)
        cout<<arr[i];
}  
int main()
{
    string arr[] = {"red","red","green","blue","green"};
    SortColoredBalls(arr,5);
}