#include<iostream>
using namespace std;
void printMaxActivities(int start[],int finish[],int size)
{
    int i;
    i = 0;
    cout<<i<<endl;
    for(int j = 0;j<size;j++)
    {
        if(start[j] >= finish[i])
        {
            cout<<j<<endl;
            i = j;
        }
    }
}
int main()
{
    int s[] =  {1, 3, 0, 5, 8, 5}; 
    int f[] =  {2, 4, 6, 7, 9, 9}; 
    int n = sizeof(s)/sizeof(s[0]); 
    printMaxActivities(s, f, n); 
    return 0; 
}