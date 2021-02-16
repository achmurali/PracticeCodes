/*
2.	Given an array of integer and a number N. Remove all integers from the array which are occurring N times and result the result.
    a.	Preserve the sequence of the other integers which are not supposed to get removed from the array.

Sample Input: A = [3, 5, 6, 7, 1, 3, 7, 9, 5, 5, 2, 7], N = 3
Sample Output: [3, 6, 1, 3, 9, 2]
*/

let removeNOccurences = (arr,k) => {
    let count = {};
    arr.forEach((element) => {
        if(count.hasOwnProperty(element))
            count[element] += 1;
        else
            count[element] = 1;
    })
    console.log(count);
    return arr.filter((ele) => {
        if(count[ele] === k)
            return false;
        return true;
    })
}

console.log(removeNOccurences([3, 5, 6, 7, 1, 3, 7, 9, 5, 5, 2, 7],3))