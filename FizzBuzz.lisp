;; Corrected FizzBuzz in Common Lisp
(dotimes (i 100)  ; Loop from 0 to 99, effectively giving us 1 through 100 because of (1+ i)
  (let ((n (1+ i)))  ; Adjust i to start from 1
    (format t "~a~%"
            (cond ((zerop (mod n 15)) "FizzBuzz")  ; If divisible by both 3 and 5
                  ((zerop (mod n 3)) "Fizz")  ; If divisible by 3
                  ((zerop (mod n 5)) "Buzz")  ; If divisible by 5
                  (t n)))))  ; Otherwise, just print the number
