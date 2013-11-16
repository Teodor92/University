
import Sorters.BubbleSorter;
import Sorters.MergeSorter;
import Sorters.QuickSorter;
import Sorters.SelectionSorter;
import Sorters.SortableCollection;
import java.util.ArrayList;
import java.util.Arrays;


/**
 *
 * @author Teodor Kurtev
 */
public class JavaSorter {

    public static void main(String[] args) {
        System.out.println("Starting value:");
        SortableCollection<Integer> collection = new SortableCollection<>(new ArrayList(Arrays.asList(22, 11, 101, 33, 0, 101)));
        collection.printItemsOnConsole();
        
        System.out.println("Selection sort:");
        collection.sort(new SelectionSorter<Integer>());
        collection.printItemsOnConsole();
        
        System.out.println("Shuffle:");
        collection.shuffle();
        collection.printItemsOnConsole();
        
        System.out.println("Quick Sort:");
        collection.sort(new QuickSorter<Integer>());
        collection.printItemsOnConsole();
        
        System.out.println("Shuffle:");
        collection.shuffle();
        collection.printItemsOnConsole();
        
        System.out.println("Buble Sort:");
        collection.sort(new BubbleSorter<Integer>());
        collection.printItemsOnConsole();
        
        System.out.println("Shuffle:");
        collection.shuffle();
        collection.printItemsOnConsole();
        
        System.out.println("Merge Sort:");
        collection.sort(new MergeSorter<Integer>());
        collection.printItemsOnConsole();
        
        System.out.println("Shuffle:");
        collection.shuffle();
        collection.printItemsOnConsole();
    }
}
