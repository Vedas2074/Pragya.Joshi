class Array
{

    void Learn1DArray()
    {
        byte[] array1 = new byte[10];

        array1[0] = 23;

        float[] array2 = new float[] {2.1f, 3.5f, 68.88f };
        array2[10] = 28;
        var x = array2.Length;

        char[] array3 = { 'A', 'B', 'C', 'D'};



    }

    void LearnMulDArray()
    {
        //2D array
        int[,] numbers1 = new int[3, 4];
        numbers1[0, 0] = 3456;
        numbers1[2, 3] = -3456; 

        decimal[, ] numbers2 = { {2.3m, 54.2m }, { 56.4m, 12.5m} };
    }

    void LearnJaggedArray()
    {
        short[][] numbers =  new short[3][];
        numbers[0] = new short[] {3, 4, 5 };
        numbers[1] = new short[] {3, 4 };
        numbers[2] = new short[] {3, 4, 5, 12 };
        
    }
}