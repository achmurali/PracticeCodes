#include<iostream>
#include<list>
#include<vector>
using namespace std;
class Graph
{
        int V;
        list<int> *adjacency_list;
    public:
        Graph(int V)
        {
            this->V = V;
            this->adjacency_list = new list<int>[this->V]; 
        }
        void addEdge(int v,int w)
        { 
            this->adjacency_list[v].push_back(w);
        }
        void BFS(int s)
        {
            bool visited[this->V];
            for(int i = 0;i<this->V;i++)
                visited[i] = false;
            list<int> queue;
            queue.push_front(s);
            visited[s] = true;
            list<int> :: iterator i;
            while(!queue.empty())
            {
                s = queue.front();
                cout<<s<<endl;
                queue.pop_front();
                for(i = this->adjacency_list[s].begin();i!=adjacency_list[s].end();i++)
                {
                    if(!visited[*i])
                    {
                        queue.push_front(*i);
                        visited[*i] = true;
                    }
                }
            }
        }
};
int main()
{
    Graph g(4); 
    g.addEdge(0, 1); 
    g.addEdge(0, 2); 
    g.addEdge(1, 2); 
    g.addEdge(2, 0); 
    g.addEdge(2, 3); 
    g.addEdge(3, 3); 
  
    cout << "Following is Breadth First Traversal "
         << "(starting from vertex 2) \n"; 
    g.BFS(2);
}