package pkg005.comparingstrings;

public class ComparingStrings {

    public static void main(String[] args) {

        String firstString = "YO i'm a string!";
        String secondString = "YO i'm another string!";
        String thirdString = "YO i'm a string!";
        String upperCaseString = "YO i'm a string!".toUpperCase();

        System.out.println(firstString.equals(secondString));
        System.out.println(firstString.equals(thirdString));
        
        System.out.println(upperCaseString);
        System.out.println(thirdString.equalsIgnoreCase(upperCaseString));
    }

}
