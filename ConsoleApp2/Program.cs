// See https://aka.ms/new-console-template for more information

    int max = 500;
    byte previous = 0;  

    for (byte i = 0; i < max; i++)
    {
        Console.WriteLine(i);

        // Check if the current value of i is less than the previous value, indicating an overflow
        if (i < previous)
        {
            Console.WriteLine("Warning: Byte overflow occurred, 'i' has wrapped around to 0.");
        }

        previous = i;  
    }

//What happens?
/*There is an overflow in the byte variable i because a byte can only hold values from 0 to 255.
    When i reaches 255 and is incremented, it will overflow and wrap around to 0.This will result in an infinite loop 
    where the values from 0 to 255 are printed continuously.*/

