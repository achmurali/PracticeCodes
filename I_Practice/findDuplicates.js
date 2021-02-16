/*
5.	Given two arrays of strings. Return a list of strings which are common in both the arrays.
    a.	Duplicate strings in any array should be returned only once, i.e., return should contain distinct strings in it.
Sample Input: A = [ pop, cvv, txt, lol, mov, pop, cvv, zoo], B = [ txt, pap, zap, pop, yet]
Sample Output: [ pop, txt]
*/

console.log(((arr1,arr2) => {
    let stringSet = {};
    if(arr1.length > arr2.length)
    {
        stringSet = new Set([...arr2]);
        return [...new Set(arr1.filter((ele) => stringSet.has(ele)))];
    }
    else{
        stringSet = new Set([...arr1]);
        return [...new Set(arr2.filter((ele) => stringSet.has(ele)))];
    }
})(["pop", "cvv", "txt", "lol", "mov", "pop", "cvv", "zoo"],[ "txt", "pap", "zap", "pop", "yet"]));