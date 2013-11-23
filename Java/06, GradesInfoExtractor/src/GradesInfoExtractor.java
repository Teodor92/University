import java.util.Scanner;

public class GradesInfoExtractor {

    private static final Scanner input = new Scanner(System.in);

    public static void main(String[] args) {
        // Hardcoded for easy testing
//                double[][] gradesMatrix = {
//                    {4, 4, 4, 4, 4},
//                    {4, 6, 6, 6, 6},
//                    {4, 2, 2, 2, 2},
//                    {4, 4, 4, 4, 4},
//                    {4, 4, 4, 4, 4},
//                    {4, 2, 2, 2, 4},
//                    {6, 6, 6, 6, 6}
//                };

        try {
            double[][] gradesMatrix = readInput();

            System.out.println("Inital print:");
            printDouble2DMatix(gradesMatrix);

            double avgGrade = getAverageGrades(gradesMatrix);

            System.out.println("Average grades:");
            System.out.println(avgGrade);

            System.out.println("Student number of student with highest average grades:");
            System.out.println(getStudentWithMaxAverageGrades(gradesMatrix));

            System.out.println("Student number of student with lowest average grades:");
            System.out.println(getStudentWithMinAverageGrades(gradesMatrix));

            System.out.println("Number of students with average grades above total average:");
            System.out.println(getNumberOfStudentsWithGradesAboveAverage(gradesMatrix, avgGrade));

            System.out.println("Number of students with average grades below total average:");
            System.out.println(getNumberOfStudentsWithGradesBelowAverage(gradesMatrix, avgGrade));
            
        } catch (IllegalArgumentException e) {
            
            System.out.println(e.getMessage());
            System.out.println(e);
            
        } catch (Exception e) {
            
            System.out.println(e.getMessage());
            System.out.println(e);
            
        }
    }

    public static void printDouble2DMatix(double[][] matrix) {

        if (matrix == null) {
            throw new IllegalArgumentException("The grade matrix must not be null!");
        }

        for (int i = 0; i < matrix.length; i++) {
            System.out.printf("Student %d: ", i + 1);

            for (int j = 0; j < matrix[0].length; j++) {
                System.out.printf("%.2f ", matrix[i][j]);
            }

            System.out.println();
        }
    }

    public static double getAverageGrades(double[][] gradesMatrix) {

        if (gradesMatrix == null) {
            throw new IllegalArgumentException("The grade matrix must not be null!");
        }

        double gradeSum = 0;
        int gradeNumber = 0; // This can be calculated for the array length

        for (int i = 0; i < gradesMatrix.length; i++) {
            for (int j = 0; j < gradesMatrix[0].length; j++) {
                gradeSum += gradesMatrix[i][j];
                gradeNumber++;
            }
        }

        return gradeSum / gradeNumber;
    }

    public static int getStudentWithMaxAverageGrades(double[][] gradesMatrix) {
        if (gradesMatrix == null) {
            throw new IllegalArgumentException("The grade matrix must not be null!");
        }

        double maxAvg = Double.MIN_VALUE;
        int studentNumber = 0;

        for (int i = 0; i < gradesMatrix.length; i++) {
            double currentStudentAvg = 0;

            for (int j = 0; j < gradesMatrix[0].length; j++) {
                currentStudentAvg += gradesMatrix[i][j];
            }

            if (currentStudentAvg > maxAvg) {
                maxAvg = currentStudentAvg;
                studentNumber = i;
            }
        }

        return studentNumber;
    }

    public static int getStudentWithMinAverageGrades(double[][] gradesMatrix) {
        if (gradesMatrix == null) {
            throw new IllegalArgumentException("The grade matrix must not be null!");
        }

        double minAvg = Double.MAX_VALUE;
        int studentNumber = 0;

        for (int i = 0; i < gradesMatrix.length; i++) {
            double currentStudentAvg = 0;

            for (int j = 0; j < gradesMatrix[0].length; j++) {
                currentStudentAvg += gradesMatrix[i][j];
            }

            if (currentStudentAvg < minAvg) {
                minAvg = currentStudentAvg;
                studentNumber = i;
            }
        }

        return studentNumber;
    }

    public static int getNumberOfStudentsWithGradesAboveAverage(double[][] gradesMatrix, double averageGrades) {
        if (gradesMatrix == null) {
            throw new IllegalArgumentException("The grade matrix must not be null!");
        }

        int numberOfStudents = 0;

        for (int i = 0; i < gradesMatrix.length; i++) {
            double currentStudentAvg = 0;

            for (int j = 0; j < gradesMatrix[0].length; j++) {
                currentStudentAvg += gradesMatrix[i][j];
            }

            currentStudentAvg = currentStudentAvg / 5;

            if (currentStudentAvg >= averageGrades) {
                numberOfStudents++;
            }
        }

        return numberOfStudents;
    }

    public static int getNumberOfStudentsWithGradesBelowAverage(double[][] gradesMatrix, double averageGrades) {

        if (gradesMatrix == null) {
            throw new IllegalArgumentException("The grade matrix must not be null!");
        }

        int numberOfStudents = 0;

        for (int i = 0; i < gradesMatrix.length; i++) {
            double currentStudentAvg = 0;

            for (int j = 0; j < gradesMatrix[0].length; j++) {
                currentStudentAvg += gradesMatrix[i][j];
            }

            currentStudentAvg = currentStudentAvg / 5;

            if (currentStudentAvg < averageGrades) {
                numberOfStudents++;
            }
        }

        return numberOfStudents;
    }

    private static boolean validateGradeValue(double value) {
        return value >= 2 && value <= 6;
    }

    private static double[][] readInput() {
        System.out.println("Enter the number of students:");
        int numberOfStudents = input.nextInt();
        
        while(numberOfStudents < 1 || numberOfStudents > 30) {
            System.out.println("Invalid number of students! It must be between 1 and 30");
            numberOfStudents = input.nextInt();
        }
        
        double[][] gradesMatrix = new double[numberOfStudents][5];

        for (int i = 0; i < gradesMatrix.length; i++) {
            for (int j = 0; j < gradesMatrix[0].length; j++) {
                System.out.printf("Enter grade %d for student %d:\n", j + 1, i + 1);
                double value = input.nextDouble();

                // Validation
                while (!validateGradeValue(value)) {
                    System.out.println("Invalid value! Try again:");
                    value = input.nextDouble();
                }

                gradesMatrix[i][j] = value;
            }
        }

        return gradesMatrix;
    }
}
