/*
3.	Given an array of integers and a number X. Return a list of integers which are occurring X times in the array.
    a.	The integers should be returned in an order based on the first occurrence of it in the array.
Sample Input: A = [3, 5, 6, 7, 1, 3, 7, 9, 5, 5, 2, 7], N = 3
Sample Output: [5, 7]
*/

console.log(((arr,k) => {
    const arrMap = new Map();
    const result = []
    arr.forEach((ele) => {
        if(arrMap.has(ele)){
            arrMap.set(ele,arrMap.get(ele) + 1);
        }
        else
            arrMap.set(ele,1);
        if(arrMap.get(ele) === k)
            result.push(ele);
        else if(arrMap.get(ele) > k)
            result.splice(result.indexOf(ele),1);
    })
    return result;
})([3, 5, 6, 7, 1, 3, 7, 9, 5, 5, 2, 7],3));
