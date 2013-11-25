/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg009.splitingstrings;


public class SplitingStrings {

    public static void main(String[] args) {
        
        String shopList = "meat, milk, eggs, potatos";
        String[] listItems = shopList.split(",");
        
        for (String item : listItems) {
            System.out.println(item);
        }
        
    }

}
