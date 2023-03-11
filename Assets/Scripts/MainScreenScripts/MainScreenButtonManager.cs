using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainScreenButtonManager : MonoBehaviour
{

    VisualElement root;
    VisualElement exitButton;
    VisualElement framerateButton;
    VisualElement speisenButton;
    VisualElement mainMenuButton;
    Label framerateLabel;
    int changeFramerate = 0;

    private void Start()
    {
        InitButtons();
        Application.targetFrameRate = 30;
        DisplayFrameRate();
    }

    private void InitButtons()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        exitButton = root.Q("ExitButton");
        exitButton.RegisterCallback<MouseDownEvent>(OnExitClicked);

        framerateButton = root.Q("FramerateButton");
        framerateLabel = root.Q<Label>("FramerateLabel");
        framerateButton.RegisterCallback<MouseDownEvent>(OnFramerateClicked);

        speisenButton = root.Q("SpeisenButton");
        speisenButton.RegisterCallback<MouseDownEvent>(OnSpeisenButtonClicked);

    }

    private void OnExitClicked(MouseDownEvent e)
    {
        Application.Quit();
        Debug.Log("Exit App");
    }

    private void OnFramerateClicked(MouseDownEvent e)
    {

        switch (changeFramerate)
        {
            case 0: 
                Application.targetFrameRate = 40;
                break;
            case 1:
                Application.targetFrameRate = 60;
                break;
            case 2:
                Application.targetFrameRate = 144;
                break;  
            case 3:
                Application.targetFrameRate = 2000;
                break;
        }

        changeFramerate++;
        if(changeFramerate == 4) { changeFramerate = 0; }

        DisplayFrameRate();
    }

    private void DisplayFrameRate()
    {
        framerateLabel.text = $"Framerate\n{Application.targetFrameRate}fps";
        if(Application.targetFrameRate == 2000) { framerateLabel.text = $"Framerate\n\"Unlimited\"\nfps"; }
    }

    private void OnSpeisenButtonClicked(MouseDownEvent e)
    {
        SceneManager.LoadScene(1);
    }

}
