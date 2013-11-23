/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg012.stringbuilderuse;


public class StringBuilderUse {

    public static void main(String[] args) {
        StringBuilder buffer = new StringBuilder();
        
        for (int i = 0; i < 5000; i++) {
            buffer.append("test");
        }
        
        System.out.println(buffer.toString());
    }

}
