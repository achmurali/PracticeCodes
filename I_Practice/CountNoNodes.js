let arr = [1,4,-1,3,2]
function getCountLinkedList(arr){
	let ele = 0;
  let count = 0;
	while(ele != -1){
  	ele = arr[ele];
    count++;
  }
  return count;
}
console.log(getCountLinkedList(arr));
