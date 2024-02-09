function FizzBuzz() {
        for (let i = 1; i <= 100; i++) {
            if (i % 3 === 0 && i % 5 === 0) { //if divisible by 3 and 5
                console.log("FizzBuzz");
            } else if (i % 3 === 0) { //if divisible by 3 only 
                console.log("Fizz");
            } else if (i % 5 === 0) { //if divisible by 5 only 
                console.log("Buzz");
            } else {
                console.log(i); //if it's not divisible by anything 
            }
        }
    }

FizzBuzz(); //call function 