public class FizzBuzz {
    public static void main(String[] args) throws Exception {
        for (int i = 1; i <= 100; i++) { //updates i by 1 ever loop
            if (i % 3 == 0 && i % 5 == 0) {  //checks if i is a multiple of 3 and 5
                System.out.println("FizzBuzz");
            } else if (i % 3 == 0) { //checks if i is a multiple of 3
                System.out.println("Fizz");

            } else if (i % 5 == 0) { //check if i is a multiple of 5
                System.out.println("Buzz");
            } else {
                System.out.println(i);
            }
        }
    }
}
