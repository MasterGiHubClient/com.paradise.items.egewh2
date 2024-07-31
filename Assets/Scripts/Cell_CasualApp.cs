using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Cell_CasualApp : MonoBehaviour
{
	//[FormerlySerializedAs("starts")]
	public VisualControl_States_CasualApp[] starts_CasualApp;
	//[FormerlySerializedAs("number_cell")]
	public int number_cell_CasualApp;
	//[FormerlySerializedAs("game_p")]
	public GameObject game_p_CasualApp;
	//[FormerlySerializedAs("icon_p")]

	public GameObject icon_p_CasualApp;
	//[FormerlySerializedAs("particles")]
	
	public GameObject particles_CasualApp;
	//[FormerlySerializedAs("image_of_cell")]
	public Image image_of_cell_CasualApp;

	public UnityEvent onStartGame_Show, onStartGame_Hide;

	[HideInInspector]public Sprite icon_for_cell_CasualApp;
	private LevelData_CasualApp levelData_CasualApp = new LevelData_CasualApp();

	//public static StateCells state = StateCells.menu;
	public static Action<LevelData_CasualApp> set_level_CasualApp = delegate { };
	public static Action<Sprite, int> on_set_icon_CasualApp = delegate { };
	public static Action<bool> show_icon_CasualApp = delegate { };
	public static Action<bool> Show_StartGame_CasualApp = delegate { };
	private static Cell_CasualApp currentCell_CasualApp = null;


	[HideInInspector] public bool is_showing_icon = false;

	private void OnEnable()
	{
	
		//Manager_Game.onSectionChange += OnSectionChange;
		set_level_CasualApp += SetLevelData_CasualApp;
		on_set_icon_CasualApp += SetUpIconForGame_CasualApp;
		show_icon_CasualApp += Show_Icon_CasualApp;
		Show_StartGame_CasualApp += ShowStartGame_CasualApp;

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
	private void OnDisable()
	{
		//Manager_Game.onSectionChange -= OnSectionChange;
		set_level_CasualApp -= SetLevelData_CasualApp;
		on_set_icon_CasualApp -= SetUpIconForGame_CasualApp;
		show_icon_CasualApp -= Show_Icon_CasualApp;
		Show_StartGame_CasualApp -= ShowStartGame_CasualApp;
		
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
	 void DoSomethingUseless01()
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
	void DoAnotherUselessThing01()
	{
		// Create a new GameObject and immediately destroy it
		GameObject uselessObject = new GameObject("Useless Object");
		Destroy(uselessObject);

		// Wait for a random amount of time, just because we can
		float waitTime = UnityEngine.Random.Range(0.5f, 2.0f);


		// Log a message to the console, again, just because we can
		Debug.Log("I just did something completely useless!");
	}

	private void Start()
	{
		UpdateLevelDataUI_CasualApp();
		
		
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

	private void ShowStartGame_CasualApp(bool state)
	{
		if (state)
		{
			onStartGame_Show?.Invoke();
		}
		else
		{
			onStartGame_Hide?.Invoke();

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
	public void ShowParticles_CasualApp(bool state)
	{
		if (state)
		{
			particles_CasualApp.SetActive(true);
		}
		else
		{
			particles_CasualApp.SetActive(false);

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

	public void SetUpIconForGame_CasualApp(Sprite icon, int index)
	{

		if (this.gameObject.transform.GetSiblingIndex() == index)
		{
			icon_for_cell_CasualApp = icon;
			image_of_cell_CasualApp.sprite = icon_for_cell_CasualApp;
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
	private void SetLevelData_CasualApp(LevelData_CasualApp levelData_)
	{
		if (levelData_.level == number_cell_CasualApp)
		{
			this.levelData_CasualApp = levelData_;
			UpdateLevelDataUI_CasualApp();
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

	public void UpdateLevelDataUI_CasualApp()
	{
		if (levelData_CasualApp.unlocked)
		{

			foreach (var item in starts_CasualApp)
			{
				item.isActive = false;
			}
			for (int i = 0; i < levelData_CasualApp.stars; i++)
			{
				starts_CasualApp[i].isActive = true;
			}

		}
		else
		{

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

	// private void OnSectionChange(StateCells state_)
	// {
	//     state = state_;

	//     switch (state_)
	//     {
	//         case StateCells.menu:
	//             levels_p.SetActive(true);



	//             game_p.SetActive(false);
	//             icon_p.SetActive(false);

	//             break;
	//         case StateCells.game:

	//             levels_p.SetActive(false);

	//             game_p.SetActive(true);
	//             icon_p.SetActive(false);
	//             is_showing_icon = false;
	//             break;

	//     }
	// }

	public void Show_Icon_CasualApp(bool state)
	{
		icon_p_CasualApp.SetActive(state);
		is_showing_icon = state;
		if (!state)
			ShowParticles_CasualApp(false);
			
			
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
	public void onClick()
	{
		// switch (state)
		// {
		// 	case StateCells.menu:
		// 		Manager_Game.instance.StartLevel(number_cell);
		// 		break;
		// 	case StateCells.game:
		// 		if (!is_showing_icon)
		// 			Manager_Game.instance?.CardClicked(this);
		// 		break;

		// }

		Manager_Game_CasualApp.instance?.CardClicked_CasualApp(this);
		
		
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

// public enum StateCells
// {
//     menu,
//     game
// }

[Serializable]
public class LevelData_CasualApp
{
	public bool unlocked = false;
	public int stars = 0;
	public int level = 1;
	
	
	private bool state__CasualApp = false;
	private int stars__CasualApp = 0;
	private float level__CasualApp = 1;
}
