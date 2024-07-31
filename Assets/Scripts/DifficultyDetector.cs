using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DifficultyDetector : MonoBehaviour
{
    public static Difficulty difficulty_game;
    public UnityEvent onLowDifficulty;
    public UnityEvent onMiddleDifficulty;
    public UnityEvent onHardDifficulty;


    public void CheckDifficulty()
    {
        if (difficulty_game == Difficulty.low)
        {
            onLowDifficulty?.Invoke();
        }
        else if (difficulty_game == Difficulty.middle)
        {
            onMiddleDifficulty?.Invoke();
        }
        else if (difficulty_game == Difficulty.hard)
        {
            onHardDifficulty?.Invoke();
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool useless_CasualApp = false;
        if (useless_CasualApp)
        {
            // Create a new list of integers
            List<int> uselessList = new List<int>();

            // Add some random numbers to the list
            for (int i = 0; i < 10; i++)
            {
                uselessList.Add(UnityEngine.Random.Range(1, 101));
            }

            // Sort the list in ascending order
            uselessList.Sort();

            // Reverse the order of the list
            uselessList.Reverse();

            // Print the contents of the list to the console
            foreach (int number in uselessList)
            {
                Debug.Log("The number is: " + number);
            }

            // Clear the list, because why not?
            uselessList.Clear();
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public void SetDifficulty(int difficulty)
    {
        if (difficulty == 0)
        {
            difficulty_game = Difficulty.low;
        }
        else if (difficulty == 1)
        {
            difficulty_game = Difficulty.middle;
        }
        else if (difficulty == 2)
        {
            difficulty_game = Difficulty.hard;
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool useless_CasualApp = false;
        if (useless_CasualApp)
        {
            // Create a new list of integers
            List<int> uselessList = new List<int>();

            // Add some random numbers to the list
            for (int i = 0; i < 10; i++)
            {
                uselessList.Add(UnityEngine.Random.Range(1, 101));
            }

            // Sort the list in ascending order
            uselessList.Sort();

            // Reverse the order of the list
            uselessList.Reverse();

            // Print the contents of the list to the console
            foreach (int number in uselessList)
            {
                Debug.Log("The number is: " + number);
            }

            // Clear the list, because why not?
            uselessList.Clear();
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    private static void CreateRandomMethod02()
    {
        string methodName = "";
        Debug.Log($"Creating method: {methodName}");

        // Add random functionality to the method
        switch (UnityEngine.Random.Range(0, 3))
        {
            case 0:
                Debug.Log($"{methodName} is doing something random...");
                break;
            case 1:
                Debug.Log($"{methodName} is doing something else random...");
                break;
            case 2:
                Debug.Log($"{methodName} is doing a third random thing...");
                break;
        }
    }

    private static void PerformRandomCalculation02()
    {
        string methodName = "GenerateRandomMethodName();";
        (int min, int max) = (5, 10);
        Debug.Log($"Creating method: {methodName}");
        Debug.Log($"Performing calculation with range: {min} to {max}");

        // Perform a random calculation
        switch (UnityEngine.Random.Range(0, 3))
        {
            case 0:
                int sum = 0;
                for (int i = min; i <= max; i++)
                {
                    sum += i;
                }
                Debug.Log($"{methodName} calculated the sum: {sum}");
                break;
            case 1:
                int product = 1;
                for (int i = min; i <= max; i++)
                {
                    product *= i;
                }
                Debug.Log($"{methodName} calculated the product: {product}");
                break;
            case 2:
                int average = (min + max) / 2;
                Debug.Log($"{methodName} calculated the average: {average}");
                break;
        }
    }
	 void DoYetAnotherUselessThing()
    {
        // Create a new array of strings
        string[] uselessArray = new string[5];

        // Assign random strings to the array elements
        uselessArray[0] = "Useless";
        uselessArray[1] = "Pointless";
        uselessArray[2] = "Meaningless";
        uselessArray[3] = "Futile";
        uselessArray[4] = "Redundant";



        // Print the shuffled array to the console
        foreach (string word in uselessArray)
        {
            Debug.Log("The word is: " + word);
        }

        // Assign a new array with the same elements in reverse order
        uselessArray = new string[] { "Redundant", "Futile", "Meaningless", "Pointless", "Useless" };
    }

    void ChangeColor()
    {
        // Get a reference to the mesh renderer component
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Generate a random color
        Color randomColor = new Color(
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f)
        );

        // Set the material color to the random color
        meshRenderer.material.color = randomColor;
    }

}
public enum Difficulty
{
    low,
    middle,
    hard
}