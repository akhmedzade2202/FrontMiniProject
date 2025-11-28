function findMax(arr) {
    return Math.max(...arr);
}

console.log(findMax([3, 10, 5, 8])); 


function findMin(arr) {
    return Math.min(...arr);
}

 console.log(findMin([3, 10, 1, 8])); 



 function sumArray(arr) {
    return arr.reduce((sum, num) => sum + num, 0);
}

 console.log(sumArray([1, 2, 3, 4])); 


 function linearSearch(arr, target) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === target) return i;
    }
    return -1; 
}

console.log(linearSearch([5, 8, 12], 8)); 


function linearSearch(arr, target) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === target) return i;
    }
    return -1; 
}

 console.log(linearSearch([5, 8, 12], 8)); 
