using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimationJumpUI_CasualApp : MonoBehaviour
{
    public float jumpHeight_CasualApp = 0.5f;
    public float jumpDuration_CasualApp = 0.5f;
    public float jumpScale_CasualApp = 0.1f;
    private Tween anim_move_CasualApp;
    private Tween anim_scale_CasualApp;

    public void AnimationRunning(bool state)
    {
        Debug.Log($"data :{state}");

        if (state)
        {
            anim_move_CasualApp = transform.DOLocalMoveY(transform.localPosition.y + Mathf.Sin(Time.time * 2) * jumpHeight_CasualApp, jumpDuration_CasualApp).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutQuint);
            anim_scale_CasualApp = transform.DOScale(Vector3.one + new Vector3(0, Mathf.Sin(Time.time * 2) * jumpScale_CasualApp, 0), jumpDuration_CasualApp).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutQuint);

        }
        else
        {

            if (anim_move_CasualApp != null)
                anim_move_CasualApp.Kill();

            if (anim_scale_CasualApp != null)
                anim_scale_CasualApp.Kill();
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
