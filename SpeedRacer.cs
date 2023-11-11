using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";

    float maxAcceleration = 0.98f;

    int carWeight = 1609;
    int yearMade = 2009;

    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;


    void Start()
    {
        print("The racer model is " + carModel + ". It has a " + engineType + " engine.");
        // Check if the car weighs less than 1500 kg.
        // This is a function call to the function named 'CheckWeight', which is defined further below
        CheckWeight();

        /* If the car is made in the year 2009 or earlier, do what is in the first block of curly braces
         * otherwise, do what is in the second block of braces directly after it (marked by 'else' keyword).
         */
        if (yearMade <= 2009)
        {
            print("It was first introduced in " + yearMade);

            // Call the 'CalculateAge' function, passing the 'yearMade' variable as the argument. Then, store the return result in 'carAge' variable.
            int carAge = CalculateAge(yearMade);

            print("That makes it " + carAge + " years old.");

        }else
        {
            print("It was introduced in the 2010's");
            print("And its maximum acceleration is " + maxAcceleration + " m/s2");
        }

        print(CheckCharacteristics());
    }
     {
        /* if the weight is less than 1500, do what is in the first block of curly braces
         * otherwise, do what is in the second block of curly braces (after the 'else' keyword)
         */
        if (carWeight< 1500)
        {
            print("The " + carModel + " weighs less than 1500 kg.");
}
        else
{
    print("The " + carModel + " weighs over 1500 kg.");
}
{
    return 2023 - yearMade;
}

// Check if the car is a sedan type, or if it has a front engine.
string CheckCharacteristics()
{
    /* First check if the car is a sedan. If not, then check if it has a front engine.
     * Notice in the Console window how only one message is shown. Depending on which check is passed, only one block will be triggered.
     */
    if (isCarTypeSedan)
    {
        return "The car is a sedan type.";

    }
    else if (hasFrontEngine)
    {
        return "The car is not a sedan, but has a front engine.";

    }
    else
    {
        return "The car is neither a sedan, nor is its engine a front engine.";
    }
}



void Update()
    {

    }
}
