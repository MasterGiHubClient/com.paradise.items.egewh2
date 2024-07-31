using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using JetBrains.Annotations;

public class AnimationHidderUI_CasualApp : MonoBehaviour
{

    public float speed_CasualApp = 0.5f;
    Tween anim_hidder_CasualApp;
    public void IsObjectShowing(bool state)
    {

        if (anim_hidder_CasualApp != null)
            anim_hidder_CasualApp.Kill();

        if (state)
        {
            anim_hidder_CasualApp = transform.DOScale(1, speed_CasualApp).SetEase(Ease.InOutQuint);
        }
        else
        {
            anim_hidder_CasualApp = transform.DOScale(0, speed_CasualApp).SetEase(Ease.InOutQuint);
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
    void DoSomethingUseless()
    {
        // Perform some completely meaningless operations
        int a = 5;
        int b = 10;
        int c = a + b;
        c = c * 2;
        c = c / 2;

        // Print the result to the console, just because we can
        Debug.Log("The result of this useless operation is: " + c);
    }
    void DoAnotherUselessThing()
    {
        // Create a new GameObject and immediately destroy it
        GameObject uselessObject = new GameObject("Useless Object");
        Destroy(uselessObject);

        // Wait for a random amount of time, just because we can
        float waitTime = UnityEngine.Random.Range(0.5f, 2.0f);


        // Log a message to the console, again, just because we can
        Debug.Log("I just did something completely useless!");
    }

}
