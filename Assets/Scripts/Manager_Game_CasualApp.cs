using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using JetBrains.Annotations;

public class Manager_Game_CasualApp : MonoBehaviour
{
    [SerializeField] private UnityEvent onGameStart, onGameFinish, onNextClick, onWrongCard, onRightCardsFirst;
    [SerializeField] private LevelsData_CasualApp levels_data;
    [SerializeField] private TMP_Text score_text;

    private Level_CasualApp current_level_data_CasualApp;
    private int points_score_CasualApp = 500;
    //private int current_level;

    //public static Action<StateCells> onSectionChange = delegate { };
    public static Manager_Game_CasualApp instance;



    [HideInInspector] private bool game_running_CasualApp = false;
    private AllLevelsData_CasualApp all_levels_data_CasualApp = new AllLevelsData_CasualApp();

    private void Awake()
    {
        instance = this;

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

    public Level_CasualApp GetLevel_CasualApp(int level)
    {
        Level_CasualApp level_d_CasualApp = null;
        foreach (var item in levels_data.levels_CasualApp)
        {
            if (item.level_CasualApp == level)
                level_d_CasualApp = item;
        }

        if (level_d_CasualApp != null)
        {

            Shuffle_CasualApp(level_d_CasualApp.spritesLevel_CasualApp);
            Shuffle_CasualApp(level_d_CasualApp.spritesLevel_CasualApp);
            return level_d_CasualApp;
        }

        return null;

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
    public void Shuffle_CasualApp(Sprite[] array)
    {
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = UnityEngine.Random.Range(0, n + 1);
            Sprite value = array[k];
            array[k] = array[n];
            array[n] = value;
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

    public void StartLevel(int level)
    {

        switch (level)
        {
            case 1:
                DifficultyDetector.difficulty_game = Difficulty.low;
                break;
            case 2:
                DifficultyDetector.difficulty_game = Difficulty.middle;
                break;
            case 3:
                DifficultyDetector.difficulty_game = Difficulty.hard;
                break;

        }

        onGameStart?.Invoke();

        current_level_data_CasualApp = GetLevel_CasualApp(level);


        RememberBrain.instance.Sprite_remember = current_level_data_CasualApp.spritesLevel_CasualApp[UnityEngine.Random.Range(0, current_level_data_CasualApp.spritesLevel_CasualApp.Length)];
        //current_level = level;

        if (current_level_data_CasualApp == null)
            return;

        for (int i = 0; i < current_level_data_CasualApp.spritesLevel_CasualApp.Length; i++)
        {
            Cell_CasualApp.on_set_icon_CasualApp?.Invoke(current_level_data_CasualApp.spritesLevel_CasualApp[i], i);
        }
        //onSectionChange?.Invoke(StateCells.game);
        Cell_CasualApp.show_icon_CasualApp?.Invoke(true);

        Cell_CasualApp.Show_StartGame_CasualApp?.Invoke(true);

        if (delay_Show != null)
            StopCoroutine(delay_Show);

        mistake_made_CasualApp = false;
        points_score_CasualApp = 500;
        score_text.text = $"Score: {points_score_CasualApp}";

        delay_Show = StartCoroutine(DelayStartGame_CasualApp());

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

    public void PlayCurrentDifficulty()
    {
        switch (DifficultyDetector.difficulty_game)
        {
            case Difficulty.low:
                StartLevel(1);
                break;
            case Difficulty.middle:
                StartLevel(2);
                break;
            case Difficulty.hard:
                StartLevel(3);
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
    Coroutine delay_Show;
    IEnumerator DelayStartGame_CasualApp()
    {
        yield return new WaitForSeconds(2);

        game_running_CasualApp = true;
        Cell_CasualApp.Show_StartGame_CasualApp?.Invoke(false);

        Cell_CasualApp.show_icon_CasualApp?.Invoke(false);


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


    private Cell_CasualApp first_card_CasualApp, second_card_CasualApp;
    private bool is_firstCard_CasualApp = false;
    private bool lock_interaction_CasualApp = false;
    bool mistake_made_CasualApp = false;

    public async void CardClicked_CasualApp(Cell_CasualApp cell_CasualApp)
    {

        if (lock_interaction_CasualApp || !game_running_CasualApp) return;
        lock_interaction_CasualApp = true;


        if (cell_CasualApp.is_showing_icon) return;
        cell_CasualApp.Show_Icon_CasualApp(true);

        if (!is_firstCard_CasualApp)
        {

            if (cell_CasualApp.icon_for_cell_CasualApp.name != RememberBrain.instance.Sprite_remember.name)
            {
                onWrongCard?.Invoke();
                lock_interaction_CasualApp = false;
                mistake_made_CasualApp = true;
                points_score_CasualApp -= 100;

                score_text.text = $"Score: {points_score_CasualApp}";
                is_firstCard_CasualApp = false;

                if (points_score_CasualApp <= 0)
                {
                    ResetGame();
                }
                return;
            }

            cell_CasualApp.ShowParticles_CasualApp(true);
            is_firstCard_CasualApp = true;
            first_card_CasualApp = cell_CasualApp;
            lock_interaction_CasualApp = false;
        }
        else
        {
            if (cell_CasualApp.icon_for_cell_CasualApp.name == RememberBrain.instance.Sprite_remember.name)
            {
                onRightCardsFirst?.Invoke();
                cell_CasualApp.ShowParticles_CasualApp(true);

                if (!mistake_made_CasualApp)
                {
                    points_score_CasualApp += 250;
                    score_text.text = $"Score: {points_score_CasualApp}";
                }
                await Task.Delay(TimeSpan.FromSeconds(1));
                //if player won
                onGameFinish?.Invoke();
                RememberBrain.instance.Sprite_remember = null;
                is_firstCard_CasualApp = false;
                game_running_CasualApp = false;
                lock_interaction_CasualApp = false;
                return;
            }
            else
            {
                onWrongCard?.Invoke();
                mistake_made_CasualApp = true;
                points_score_CasualApp -= 100;

                score_text.text = $"Score: {points_score_CasualApp}";

                if (points_score_CasualApp <= 0)
                {
                    ResetGame();
                }
            }
            second_card_CasualApp = cell_CasualApp;
            CheckCards_CasualApp();
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

    private async void CheckCards_CasualApp()
    {


        if (first_card_CasualApp.icon_for_cell_CasualApp.ToString() == second_card_CasualApp.icon_for_cell_CasualApp.ToString())
        {
            is_firstCard_CasualApp = false;
        }
        else
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            first_card_CasualApp.Show_Icon_CasualApp(false);
            second_card_CasualApp.Show_Icon_CasualApp(false);
            is_firstCard_CasualApp = false;
        }

        lock_interaction_CasualApp = false;

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

        // CheckIfGameFinishes();
    }



    public void ResetGame()
    {
        Cell_CasualApp.show_icon_CasualApp?.Invoke(false);
        onNextClick?.Invoke();

        if (delay_Show != null)
            StopCoroutine(delay_Show);

        Cell_CasualApp.Show_StartGame_CasualApp?.Invoke(false);
        RememberBrain.instance.Sprite_remember = null;

        game_running_CasualApp = false;
        is_firstCard_CasualApp = false;
        points_score_CasualApp = 500;
        mistake_made_CasualApp = false;
        score_text.text = $"Score: {points_score_CasualApp}";

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
    // private void LevelFinish()
    // {
    //     foreach (var level in all_levels_data.levels)
    //     {
    //         if (level.level == current_level)
    //         {
    //             if (time_count < 20)
    //             {
    //                 //3
    //                 level.stars = 3;
    //             }
    //             if (time_count >= 20 && time_count < 40)
    //             {
    //                 //2
    //                 level.stars = 2;

    //             }
    //             if (time_count >= 40)
    //             {
    //                 //1
    //                 level.stars = 1;
    //             }
    //         }
    //     }
    //     CheckLevelUnlocked();
    //     FetchDataLevels();

    // }
    public void NextClick()
    {
        onNextClick?.Invoke();
        // LevelFinish();
        //onSectionChange?.Invoke(StateCells.menu);

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

    private void OnDestroy()
    {
        SaveDataLevels_CasualApp();

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

    private void SaveDataLevels_CasualApp()
    {
        var allData = new JSONObject("[]");



        var JsonObj_Data = new JSONObject(JsonUtility.ToJson(all_levels_data_CasualApp));
        allData.AddField("Levels", JsonObj_Data);

        PlayerPrefs.SetString("LevelsData", allData.ToString());

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

    private void FetchDataLevels_CasualApp()
    {
        foreach (var item in all_levels_data_CasualApp.levels_CasualApp)
        {
            Cell_CasualApp.set_level_CasualApp?.Invoke(item);
        }
        // onSectionChange?.Invoke(StateCells.menu);

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


    private static void CreateRandomMethod_CasualApp()
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

    private static void PerformRandomCalculation()
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

[Serializable]
public class AllLevelsData_CasualApp
{
    public List<LevelData_CasualApp> levels_CasualApp = new List<LevelData_CasualApp>();

    private bool state__CasualApp = false;
    private int stars__CasualApp = 0;
    private float level__CasualApp = 1;
}


