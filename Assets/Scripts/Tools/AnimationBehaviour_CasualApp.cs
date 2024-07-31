using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.Serialization;
using System.Collections.Generic;

public class AnimationBehaviour_CasualApp : MonoBehaviour
{
    ////[FormerlySerializedAs("gameObjectToMove")]
    public GameObject gameObjectToMove_CasualApp;
    //[FormerlySerializedAs("targetPosition")]

    public Transform targetPosition_CasualApp;
    //[FormerlySerializedAs("moveSpeed")]

    public float moveSpeed_CasualApp = 1f;
    //[FormerlySerializedAs("easeType")]

    public Ease easeType_CasualApp = Ease.Linear;
    //[FormerlySerializedAs("moveOnXAxis")]

    public bool moveOnXAxis_CasualApp = true;
    //[FormerlySerializedAs("moveOnYAxis")]

    public bool moveOnYAxis_CasualApp = true;
    //[FormerlySerializedAs("gameObjectToMove2")]

    public GameObject gameObjectToMove2_CasualApp;
    //[FormerlySerializedAs("targetPosition2")]

    public Transform targetPosition2_CasualApp;
    //[FormerlySerializedAs("on_first_object_start")]

    public UnityEvent on_first_object_start_CasualApp;
    //[FormerlySerializedAs("on_first_object_finish")]

    public UnityEvent on_first_object_finish_CasualApp;
    //[FormerlySerializedAs("on_second_object_start")]

    public UnityEvent on_second_object_start_CasualApp;
    //[FormerlySerializedAs("on_second_object_finish")]

    public UnityEvent on_second_object_finish_CasualApp;


    public void MoveObjectToTarget_CasualApp()
    {
        if (gameObjectToMove_CasualApp != null && targetPosition_CasualApp != null)
        {
            on_first_object_start_CasualApp?.Invoke();

            Vector3 targetPos = new Vector3(moveOnXAxis_CasualApp ? targetPosition_CasualApp.position.x : gameObjectToMove_CasualApp.transform.position.x,
                moveOnYAxis_CasualApp ? targetPosition_CasualApp.position.y : gameObjectToMove_CasualApp.transform.position.y,
                gameObjectToMove_CasualApp.transform.position.z);

            gameObjectToMove_CasualApp.transform.DOMove(targetPos, moveSpeed_CasualApp).SetEase(easeType_CasualApp).OnComplete(() =>
            {
                on_first_object_finish_CasualApp?.Invoke();
            });
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


    public void MoveObjectToTarget2_CasualApp()
    {
        if (gameObjectToMove2_CasualApp != null && targetPosition2_CasualApp != null)
        {
            on_second_object_start_CasualApp?.Invoke();

            Vector3 targetPos2 = new Vector3(moveOnXAxis_CasualApp ? targetPosition2_CasualApp.position.x : gameObjectToMove2_CasualApp.transform.position.x,
                moveOnYAxis_CasualApp ? targetPosition2_CasualApp.position.y : gameObjectToMove2_CasualApp.transform.position.y,
                gameObjectToMove2_CasualApp.transform.position.z);

            gameObjectToMove2_CasualApp.transform.DOMove(targetPos2, moveSpeed_CasualApp).SetEase(easeType_CasualApp).OnComplete(() =>
            {
                on_second_object_finish_CasualApp?.Invoke();
            });
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
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );

        // Set the material color to the random color
        meshRenderer.material.color = randomColor;
    }
}
