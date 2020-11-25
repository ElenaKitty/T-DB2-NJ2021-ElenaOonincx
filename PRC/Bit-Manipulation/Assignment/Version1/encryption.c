void encrypt(int arrayLength, int numbers[], char string[])
{
    //encrypt doormiddel van bitshift.
    for (int i = 0; i < arrayLength; i++)
    {
        numbers[i] = string[i];
        if(string[i] % 2 == 0)
        {
            string[i] >>= 1; //delen door 2
            numbers[i] = string[i];
        }
        else
        {
            numbers[i] = numbers[i] / 2 + 1;
        }
        string[i] = numbers[i];
    }
}

void decrypt(int arrayLength, int numbers[], char string[])
{
    //counter to fix the slipups. See pattern excelfile.
    int counter = 0;
    //decrypt doormiddel van bitshift.
    for (int i = 0; i < arrayLength; i++)
    {
        if(numbers[i] % 2 == 0)
        {
            string[i] <<= 1; //vermenigvuldigen met 2
            numbers[i] = string[i];
        }
        else
        {
            numbers[i] = numbers[i] * 2 -1;
        }
        if(counter == 1)
        {
            numbers[i] = numbers[i] + 1;
        }
        else if(counter == 2)
        {
            numbers[i] = numbers[i] - 1;
            counter = -2;
        }
        string[i] = numbers[i];
        counter++;
    }
}
