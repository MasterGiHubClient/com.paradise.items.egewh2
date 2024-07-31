using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Animation_Selection_CasualApp : MonoBehaviour
{
	private Tween animIcon_CasualApp;
	public void SelectionAnim_CasualApp(bool state_CasualApp)
	{
		if (state_CasualApp)
		{
			if (animIcon_CasualApp != null)
				animIcon_CasualApp.Kill();

			animIcon_CasualApp = transform.DOScale(Vector3.one * 0.9f, 0.3f).SetEase(Ease.InOutQuint)
					.SetLoops(-1, LoopType.Yoyo)
					.OnComplete(() => animIcon_CasualApp.Play()).SetUpdate(true);
		}
		else
		{
			if (animIcon_CasualApp != null)
				animIcon_CasualApp.Kill();

			transform.localScale = Vector3.one;
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
				uselessList.Add(Random.Range(1, 101));
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


	private void OnDisable()
	{
		if (animIcon_CasualApp != null)
			animIcon_CasualApp.Kill();

		transform.localScale = Vector3.one;
		
		
		   //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool useless_CasualApp = false;
        if (useless_CasualApp)
        {
            // Create a new list of integers
            List<int> uselessList = new List<int>();

            // Add some random numbers to the list
            for (int i = 0; i < 10; i++)
            {
                uselessList.Add(Random.Range(1, 101));
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
		float waitTime = Random.Range(0.5f, 2.0f);


		// Log a message to the console, again, just because we can
		Debug.Log("I just did something completely useless!");
	}
}
