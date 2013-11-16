/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Sorters;

import java.util.List;

public class SelectionSorter<T extends Comparable<T>> implements Sorter<T>{
    
    @Override
    public void sort(List<T> collection) {
    
        int collectionLength = collection.size();

            for (int i = 0; i < collectionLength - 1; i++)
            {
                int minElementIndex = i;

                for (int j = i + 1; j < collectionLength; j++)
                {
                    if (collection.get(j).compareTo(collection.get(minElementIndex)) < 0)
                    {
                        minElementIndex = j;
                    }
                }

                if (minElementIndex != i)
                {
                    T oldValue = collection.get(i);
                    collection.set(i, collection.get(minElementIndex));
                    collection.set(minElementIndex, oldValue);
                }
            }
        
    }
}
