
/*
You are given a phone number as a string number. number consists of digits, spaces ' ', and/or dashes '-'.

You would like to reformat the phone number in a certain manner. Firstly, remove all spaces and dashes. Then, group the digits from left to right into blocks of length 3 until there are 4 or fewer digits. The final digits are then grouped as follows:

2 digits: A single block of length 2.
3 digits: A single block of length 3.
4 digits: Two blocks of length 2 each.
The blocks are then joined by dashes. Notice that the reformatting process should never produce any blocks of length 1 and produce at most two blocks of length 2.

Return the phone number after formatting.
 */

var reformatNumber = function(number) {
    number = number.replace(/(\s|-+)/g,"");
    let newNumber = number.replace(/(\s|-+)/g,"").match(/.{1,3}/g);
    let remainder = Math.round(number.length % 3);
    console.log(newNumber.length)
    if(remainder != 1)
        return newNumber;
    else
    {
        console.log("test");
        let pre = newNumber[newNumber.length-2][2];
        newNumber[newNumber.length - 2] = newNumber[newNumber.length - 2].slice(0,2);
        newNumber[newNumber.length-1] = pre + newNumber[newNumber.length-1]
        return newNumber;
    }
};

console.log(reformatNumber("--17-5 229 35-39475 ").join("-"));