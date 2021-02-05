#include<iostream>
#include<list>
using namespace std;
struct node 
{
    int data;
    struct node *right,*left;
};
node* newNode(int data)
{
    node *temp = new node;
    temp->data = data;
    temp->left = temp->right = NULL;
    return temp;
}
void levelOrderTraversal(node *root)
{
    if(root == NULL)
        return;
    list<node*> queue;
    queue.push_front(root);
    while(!queue.empty())
    {
        node *temp = queue.front();
        cout<< temp->data;
        queue.pop_front();
        if(temp -> left != NULL)
            queue.push_back(temp->left);
        if(temp->right != NULL)
            queue.push_back(temp->right);
    }
}
int main()
{
    node *root = newNode(1);  
    root->left = newNode(2);  
    root->right = newNode(3);  
    root->left->left = newNode(4);  
    root->left->right = newNode(5);  
  
    cout << "Level Order traversal of binary tree is \n";  
    levelOrderTraversal(root);  
}