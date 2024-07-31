using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using System;
using Coffee.UIExtensions;
using UnityEngine.Events;
using UnityEngine.Serialization;
using System.Collections.Generic;

public class VisualControl_States_CasualApp : MonoBehaviour
{
    // [FormerlySerializedAs("uiSatatesToControl")]
    public VisualStatesUI[] uiSatatesToControl_CasualApp;
    [SerializeField]
    public UnityEvent onChangeState, onOn, onOff;

    [SerializeField]
    public bool _isActive = false;
    public bool isActive
    {
        set
        {
            _isActive = value;
            UpdateStateUI_CasualApp();
            onChangeState?.Invoke();
            if (value)
            {
                onOn?.Invoke();
            }
            else
            {
                onOff?.Invoke();
            }
        }
        get { return _isActive; }
    }


    private Tween animColor_Text;
    private Tween animColor_Image;

    private void UpdateStateUI_CasualApp()
    {

        if (animColor_Text != null)
            animColor_Text.Kill();

        if (animColor_Image != null)
            animColor_Image.Kill();


        foreach (var uiAccess in uiSatatesToControl_CasualApp)
        {
            if (_isActive)
            {
                if (uiAccess._text != null)
                    animColor_Text = DOTween.To(() => uiAccess._text.color, x => uiAccess._text.color = x, uiAccess.color_Enable, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_ChangeColor != null)
                    animColor_Image = DOTween.To(() => uiAccess._image_ChangeColor.effectColor, x => uiAccess._image_ChangeColor.effectColor = x, uiAccess.color_Enable, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image != null)
                    uiAccess._image.sprite = uiAccess.sprite_Enable;

            }
            else
            {
                if (uiAccess._text != null)
                    animColor_Text = DOTween.To(() => uiAccess._text.color, x => uiAccess._text.color = x, uiAccess.color_Disable, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image_ChangeColor != null)
                    animColor_Image = DOTween.To(() => uiAccess._image_ChangeColor.effectColor, x => uiAccess._image_ChangeColor.effectColor = x, uiAccess.color_Disable, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

                if (uiAccess._image != null)
                    uiAccess._image.sprite = uiAccess.sprite_Disable;
            }
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

    public void SetState(bool state)
    {
        _isActive = state;
        UpdateStateUI_CasualApp();

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

    [ContextMenu("Toggle")]
    private void ToggleState()
    {
        isActive = !isActive;


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

[Serializable]
public class VisualStatesUI
{
    public TMP_Text _text;
    public Color color_Enable, color_Disable;
    public UIEffect _image_ChangeColor;
    public Image _image;
    public Sprite sprite_Enable, sprite_Disable;
}
