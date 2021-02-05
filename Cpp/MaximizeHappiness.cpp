// C++ implementation of the approach 
#include <iostream>
#include<vector>  
using namespace std; 

// Function to return the maximized happiness 
int MaxHappiness(int A, int N, vector<string> v) 
{ 
	string str; 

	// Two arrays similar to 
	// 0 1 knapsack problem 
	int val[N], wt[N], c = 0; 
	for (int i = 0; i < N; i++) { 
		str = v[i]; 

		// To store the happiness 
		// of the current group 
		c = 0; 
		for (int j = 0; str[j]; j++) { 

			// Current person is a child 
			if (str[j] == 'c') 
				c += 4; 

			// Woman 
			else if (str[j] == 'w') 
				c += 3; 

			// Man 
			else if (str[j] == 'm') 
				c += 2; 

			// Old person 
			else
				c++; 
		} 

		// Group's happiness is the sum of happiness 
		// of the people in the group multiplied by 
		// the number of people 
		c *= str.length(); 
		val[i] = c; 
		wt[i] = str.length(); 
	} 

	// Solution using 0 1 knapsack 
	int k[N + 1][A + 1]; 
	for (int i = 0; i <= N; i++) { 
		for (int w = 0; w <= A; w++) { 
			if (i == 0 || w == 0) 
				k[i][w] = 0; 
			else if (wt[i - 1] <= w) 
				k[i][w] = max(val[i - 1] 
								+ k[i - 1][w - wt[i - 1]], 
							k[i - 1][w]); 
			else
				k[i][w] = k[i - 1][w]; 
		} 
	} 
	return k[N][A]; 
} 

// Driver code 
int main() 
{ 

	// Number of seats 
	int A = 5; 

	// Groups 
	vector<string> v = { "mmo", "oo", "cmw", "cc", "c" }; 
	int N = v.size(); 
	cout << MaxHappiness(A, N, v); 

	return 0; 
} 

