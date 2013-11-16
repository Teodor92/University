package Sorters;

import java.util.ArrayList;
import java.util.List;

public class QuickSorter<T extends Comparable<T>> implements Sorter<T> {

    @Override
    public void sort(List<T> collection) {
        if (collection == null) {
            throw new IllegalArgumentException("A collection must be given!");
        }
        
        if (collection.size() == 1) {
            return;
        }
        
        List<T> sortedCollection = this.quickSort(collection);
        collection.clear();
        
        collection.addAll(sortedCollection);
    }

    private List<T> quickSort(List<T> collection) {
        if (collection.size() <= 1) {
            return collection;
        }

        int pivot = (collection.size() - 1) / 2;
        T pivotValue = collection.get(pivot);
        collection.remove(pivot);
        List<T> lesser = new ArrayList<>();
        List<T> greater = new ArrayList<>();

        for (T element : collection) {
            if (element.compareTo(pivotValue) < 0) {
                lesser.add(element);
            } else {
                greater.add(element);
            }
        }

        List<T> result = new ArrayList<>();
        result.addAll(this.quickSort(lesser));
        result.add(pivotValue);
        result.addAll(this.quickSort(greater));
        return result;
    }

}
