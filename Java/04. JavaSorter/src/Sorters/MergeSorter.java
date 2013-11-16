package Sorters;

import java.util.ArrayList;
import java.util.List;

public class MergeSorter<T extends Comparable<T>> implements Sorter<T> {

    @Override
    public void sort(List<T> collection) {
        List<T> newCollection = this.MergeSort(collection);
        collection.clear();
        collection.addAll(newCollection);
    }

    private List<T> MergeSort(List<T> collection) {
        if (collection.size() <= 1) {
            return collection;
        }

        List<T> left = new ArrayList<>();
        List<T> right = new ArrayList<>();
        int middle = collection.size() / 2;
        for (int i = 0; i < middle; i++) {
            left.add(collection.get(i));
        }

        for (int i = middle; i < collection.size(); i++) {
            right.add(collection.get(i));
        }

        left = this.MergeSort(left);
        right = this.MergeSort(right);
        return this.Merge(left, right);
    }

    private List<T> Merge(List<T> left, List<T> right) {
        List<T> result = new ArrayList<>();
        while (left.size() > 0 || right.size() > 0) {
            if (left.size() > 0 && right.size() > 0) {
                if (left.get(0).compareTo(right.get(0)) < 0) {
                    result.add(left.get(0));
                    left.remove(0);
                } else {
                    result.add(right.get(0));
                    right.remove(0);
                }
            } else if (left.size() > 0) {
                result.add(left.get(0));
                left.remove(0);
            } else if (right.size() > 0) {
                result.add(right.get(0));
                right.remove(0);
            }
        }

        return result;
    }
}
