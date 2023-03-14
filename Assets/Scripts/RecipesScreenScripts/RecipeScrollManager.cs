using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RecipeScrollManager : MonoBehaviour
{
    VisualElement root;
    ScrollView recipeScrollView;
    RecipeScreen recipeScreen;

    [SerializeField] List<RecipeSO> recipesList;

    private void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        recipeScrollView = root.Q<ScrollView>("RecipeScrollView");
        recipeScreen = GameObject.FindObjectOfType<RecipeScreen>();
        CreateRecipeButtons();
    }

    private void CreateRecipeButtons() 
    { 
        foreach (RecipeSO recipe in recipesList) 
        {
            new RecipeButton(recipeScrollView, recipe, recipeScreen);
        }
    }


}
