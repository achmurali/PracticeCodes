/*
1.	Given an array of strings, write a function to return a list of strings which has their reverse present in the array. The result returned should contain the strings and their reverses.
    a.	Strings which are palindrome should also be returned even if they are present once.
    b.	Repeated strings or their reverses should be returned only once in the result.
    Sample Input: cvx, rtx, abc, xtr, pop, rtx, ice, cub, cba
    Sample Output: rtx, xtr, pop, abc, cba
 */

 let findStringandReverse = (strs) => {
    let strMap = new Set();
    let result = [];
    strs.forEach(element => {
        let eleRev = element.split("").reverse().join("");
        if(strMap.has(eleRev))
        {
            result.push(eleRev,element);
        }
        else if(eleRev === element)
        {
            result.push(element);
        }
        else
            strMap.add(element);
    });
    return result;
}

console.log(findStringandReverse(["cvx", "rtx", "abc", "xtr", "pop", "rtx", "ice", "cub", "cba"]));