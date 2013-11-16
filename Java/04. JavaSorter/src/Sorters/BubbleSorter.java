package Sorters;

import java.util.List;

public class BubbleSorter<T extends Comparable<T>> implements Sorter<T> {

    @Override
    public void sort(List<T> collection) {
        T temp;

        for (int write = 0; write < collection.size(); write++)
        {
            for (int sort = 0; sort < collection.size() - 1; sort++)
            {
                if (collection.get(sort).compareTo(collection.get(sort + 1)) > 0)
                {
                    temp = collection.get(sort + 1);
                    collection.set(sort + 1, collection.get(sort));
                    collection.set(sort, temp);
                }
            }
        }
    }
    
}
