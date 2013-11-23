/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg013.parsingstrings;


public class ParsingStrings {

    public static void main(String[] args) {

        String simpleNumber = "123";
        
        int parsedNumber = Integer.parseInt(simpleNumber);
        double parsedDouble = Double.parseDouble(simpleNumber);
        
        System.out.println(parsedNumber);
        System.out.println(parsedDouble);
        
    }

}
