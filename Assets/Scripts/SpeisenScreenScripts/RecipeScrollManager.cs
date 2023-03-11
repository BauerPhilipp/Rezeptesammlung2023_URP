using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RecipeScrollManager : MonoBehaviour
{

    VisualElement root;
    ScrollView recipeScrollView;
    [SerializeField] VisualTreeAsset recipeTemplate;

    private void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        recipeScrollView = root.Q<ScrollView>("RecipeScrollView");
        recipeScrollView.Add(recipeTemplate.Instantiate());
        recipeScrollView.Add(recipeTemplate.Instantiate());
    }


}
