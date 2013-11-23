/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg010.replacingstrings;


public class ReplacingStrings {

    public static void main(String[] args) {
        String sentence = "I love Microsoft. C# is great!";
        
        String newSentence = sentence.replace("Microsoft", "Java");
        String newerSentence = newSentence.replace("C#", "Java");
        System.out.println(newerSentence);
    }

}
