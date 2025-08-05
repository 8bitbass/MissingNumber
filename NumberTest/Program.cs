public class NumberTest {

    // only works for positive numbers in the range 0 to n and only a single missing number.
    // if no number is missing assumes missing number is n.
    // only visits each element once and doesn't allocate much memory, so that's nice.
    private static int FindMissingNumber(int[] numbers) {
        long sum = 0;
        long actualSum = 0;
        int max = 0;
        for (int i = 0; i < numbers.Length; i++) {
            if (numbers[i] > max) {
                max = numbers[i];
            }
            sum += i;
            actualSum += numbers[i];
        }

        if (sum == actualSum) {
            return max + 1;
        }

        // add the max number because the array is missing a number so adding i each time will be short by the biggest number
        sum += max;

        // we can safely cast to an int because the missing number must be an int
        return (int)(sum - actualSum);
    }

    public static int Main(string[] args) {
        var test1 = new int[] { 3, 0, 1 }; // missing 2
        var test2 = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }; // missing 8
        var test3 = new int[] { 0, 1, 2 }; // missing 3 (biggest number missing)
        var test4 = new int[] { 1, 2, 3 }; // missing 0
        var out1 = FindMissingNumber(test1);
        var out2 = FindMissingNumber(test2);
        var out3 = FindMissingNumber(test3);
        var out4 = FindMissingNumber(test4);
        Console.WriteLine(out1);
        Console.WriteLine(out2);
        Console.WriteLine(out3);
        Console.WriteLine(out4);
        return 0;
    }
}