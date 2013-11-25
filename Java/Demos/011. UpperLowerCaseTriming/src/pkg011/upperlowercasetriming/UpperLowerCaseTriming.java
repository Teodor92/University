/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg011.upperlowercasetriming;


public class UpperLowerCaseTriming {

    public static void main(String[] args) {
        String sentence = "                                I'm a sample sentence! ";
        
        String newSentence = sentence.toUpperCase();
        
        System.out.println(newSentence);
        
        
        System.out.println(newSentence.trim());
    }

}
