/**
 * @param {number[]} nums
 * @return {number}
 */

let factorial = (num) => {
    if(typeof num === 'number' && !isNaN(num))
    {
        let factorial = 1;
        for(let i = 1;i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    return 0;
}

var numIdenticalPairs = function(nums) {
    let dict = {}
    nums.forEach(ele => {
        if(!dict.hasOwnProperty(ele))
            dict[ele] = 1;
        else
            dict[ele] += 1
    });
    let result = 0;
    for(let [key,value] of Object.entries(dict))
    {
        if(value >= 2)
        {
            result += factorial(value) / (factorial(value - 2) * 2);
        }
    }
    return result;
};

//console.log(factorial(4))
console.log(numIdenticalPairs([1,2,3,1,1,3]));