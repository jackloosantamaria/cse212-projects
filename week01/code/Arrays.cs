public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Plan Multiple Of:
        //1. Create an array of type double equal in size of variable length
        //2. Use a for loop starting from 0
        /*3. In each iteration of the loop, calculate the current multiple using (i+1)
             as I want the multiples starting from 1*/
        //4. Store that multiple in position i of the array
        //5. Return the array filled with multiples

        //create array length size
        double [] multiples = new double[length];

        //loop to fill array
        for (int i=0; i < length; i++){
            //calculate number
            multiples[i] = number * (i+1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Get the last elements to place in front
        List<int> tail = data.GetRange(data.Count - amount, amount);

        //Get rid of the last elements to avoid duplicates
        data.RemoveRange(data.Count - amount, amount);

        //Insert elements at the beginning of the list
        data.InsertRange(0, tail);


    }
}
