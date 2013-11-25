/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg013.parsingstrings;

import java.util.Scanner;

public class ParsingStrings {

    public static void main(String[] args) {
        //Да се инициализира масив с имената на n-брой служители
        //във фирма Х и да се изведе името на служителя с най-дългото име
        //n да е между 2 и 10

        Scanner scan = new Scanner(System.in);

        System.out.println("Enter n:");
        int n = scan.nextInt();

        while (n < 2 || n > 10) {
            System.out.println("Enter n");
            n = scan.nextInt();
        }

        String[] employees = new String[n];

        System.out.println("Enter employees names:");
        for (int i = 0; i < employees.length; i++) {
            employees[i] = scan.next();
        }

        String longestName = "";
        for (int i = 0; i < employees.length; i++) {
            if (employees[i].length() > longestName.length()) {
                longestName = employees[i];
            }
        }
        
        System.out.println(longestName);
    }

}
