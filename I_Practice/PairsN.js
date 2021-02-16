/*
4.	Given an array of integers and a number X. Return a list of pair of integers which sums up to X from the array.
    a.	The pairs returned should be distinct. [x, y] is the same as [y, x] and should be returned only once either [x, y] or [y, x].
Sample Input: A = [3, 5, 6, 7, 1, 3, 7, 9, 5, 5, 2, 7], N = 10
Sample Output: [[3, 7], [5, 5], [9,1]]

*/

console.log(((arr,k) => {
    arr.sort((a,b) => a - b);
    let result = [];
    let set = new Set();
    for(let i = 0;i < arr.length;++i){
        if(arr[i] > k)
            continue;
        let remainder = k - arr[i];
        let res = arr.find((ele,index) => {
            if(index > i)
                return remainder === ele;
            return false;
        })
        if(res)
        {
            let res = [arr[i],remainder];
            if(!set.has(res.toString())){
                set.add(res.toString());
                result.push(res);
            }
        }
    }
    return result;
})([3, 5, 6, 7, 1, 3, 7, 9, 5, 5, 2, 7],10))