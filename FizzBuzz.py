for value in range(1, 101): #goes to 101 because starts at 1 therefore 100 would only be 99
    if value % 3 == 0 and value % 5 == 0: # checks if number is divisible by 3 and 5
        print("FizzBuzz!")
    elif value % 3 == 0: # checks if number is only divisible by 3
        print("Fizz")
    elif value % 5 == 0: # checks if number is only divisible by 5
        print("Buzz")
    else:
        print(value) #if none of the above cases apply, just print the number