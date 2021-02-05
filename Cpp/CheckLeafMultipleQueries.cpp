#include<iostream>
#include<vector>
using namespace std;
void performQueries(vector<pair<int,int> > tree,vector<int> queries,int n)
{   
    bool arr[n];
    for(int i=0;i<n;i++)
        arr[i] = false;
    for(int i = 0;i<tree.size();i++)
    {
        arr[tree[i].first] = true;
    }
    for(int i = 0;i<queries.size();i++)
        cout<<(!arr[queries[i]])<<endl; 
}
int main()
{
        vector<pair<int, int> > edges = { 
        { 0, 1 }, { 0, 2 }, { 1, 3 }, { 1, 4 }, { 4, 5 } 
    };
    vector<int> queries = { 0, 3, 4, 5 };
    performQueries(edges,queries,6);
}