using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BackToMainMenue : MonoBehaviour
{
    VisualElement root;
    VisualElement mainMenuButton;

    private void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        mainMenuButton = root.Q("MainMenuButton");
        mainMenuButton.RegisterCallback<MouseDownEvent>((MouseDownEvent e) =>
        {
            SceneManager.LoadScene(0);
        });

    }


}
