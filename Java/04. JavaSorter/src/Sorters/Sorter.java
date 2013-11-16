/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Sorters;

import java.util.List;

/**
 *  
 * @author teodo_000
 */
public interface Sorter<T extends Comparable<T>> {
    void sort(List<T> collection);
}
