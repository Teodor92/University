/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Sorters;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class SortableCollection<T extends Comparable<T>> {

    private final List<T> collection;
    private final Random randomProvider;

    public SortableCollection() {
        this.collection = new ArrayList<>();
        this.randomProvider = new Random();
    }

    public SortableCollection(List<T> collection) {
        this.collection = collection;
        this.randomProvider = new Random();
    }

    public List<T> getItems() {
        return this.collection;
    }

    ;
    
    public void sort(Sorter<T> sorter) {
        sorter.sort(this.collection);
    }

    public void shuffle() {
        int itemsCount = this.collection.size();
        for (int i = 0; i < itemsCount; i++) {
            int r = i + randomProvider.nextInt(itemsCount - i);
            T oldValue = this.collection.get(i);
            this.collection.set(i, this.collection.get(r));
            this.collection.set(r, oldValue);
        }
    }

    public void printItemsOnConsole() {
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < this.collection.size(); i++) {
            output.append(this.collection.get(i));
            output.append(" ");
        }

        output.append("\n");

        System.out.println(output.toString());
    }
}
