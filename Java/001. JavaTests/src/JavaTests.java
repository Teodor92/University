
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class JavaTests {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String testValue = input.next();
        
        // Using regex
        String pattern = "\\d{10}";
        
        Pattern r = Pattern.compile(pattern);
        Matcher m = r.matcher(testValue);
        if (m.find()) {
            System.out.println("Valid PIN");
        } else {
            System.out.println("Unvalid PIN");
        }

        // Using TryParse method
        
        if (tryParseLong(testValue)) {
            System.out.println("Valid number");
        } else {
            System.out.println("Invalid number");
        }
    }

    private static boolean tryParseLong(String value) {
        try {
            Long.parseLong(value);
            return true;
        } catch (NumberFormatException nfe) {
            return false;
        }
    }
}
