namespace challenges_and_data_structures
{
    public class ArrayManipulation
    {
        public static int MostFrequentNumber(int[] arr)
        {
            int mostFrequentNumber = arr[0];
            int maxFrequency = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                int frequency = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        frequency++;
                }
                if (frequency > maxFrequency || (frequency == maxFrequency && arr[i] < mostFrequentNumber))
                {
                    mostFrequentNumber = arr[i];
                    maxFrequency = frequency;
                }
            }

            return mostFrequentNumber;
        }
    }

}
