import java.util.Scanner;

public class PalindromeFinder {
    
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        System.out.println("Enter a word");
        String word = input.next();
        
        if (CheckForPalindrome(word)) {
            System.out.printf("The word %s is a palindrom! \n", word);
        } else {
            System.out.printf("The word %s is NOT a palindrom! \n", word);
        }
    }
    
    public static boolean CheckForPalindrome(String word) {
        boolean isPalindrome = true;
        
        for (int i = 0; i < word.length() / 2; i++) {
            if (word.charAt(i) != word.charAt(word.length() - i - 1)) {
                isPalindrome = false;
                break;
            }
        }
        
        return isPalindrome;
    }
    
}
