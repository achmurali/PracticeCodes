#include<iostream>
#include<vector>
using namespace std;
void CheckifBalanced(string seq)
{
    vector<char> stack;
    int count = 0;
    for(int i=0;i<seq.length();i++)
    {
        if(seq[i] == '(')
        {
            stack.push_back(seq[i]);
        }
        else if(seq[i] == ')' && !stack.empty() && stack.back() == '(')
        {
            stack.pop_back();
        } 
        else
        {
            if(count == 0)
            {
                stack.push_back(seq[i]);
                count++;
            }
            else
            {
                cout<<"false"<<endl;
                break;                
            }
        }
    }
    if(count <= 1)
        cout<<"true"<<endl;
}
int main()
{
    string sequence = ")(()";
    CheckifBalanced(sequence);
}