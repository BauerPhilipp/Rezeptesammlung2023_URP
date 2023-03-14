using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RecipeScrollManager : MonoBehaviour
{
    RecipeButtonCreator recipeButtonCreator;

    VisualElement root;
    ScrollView recipeScrollView;

    List<Button> recipeButtonList;
    [SerializeField] List<RecipeSO> recipesSOList;




    private void Start()
    {
        recipeButtonCreator = new RecipeButtonCreator();

        root = GetComponent<UIDocument>().rootVisualElement;
        recipeScrollView = root.Q<ScrollView>("RecipeScrollView");
        CreateRecipeButtons();
    }


    private void CreateRecipeButtons()
    {
        recipeButtonList = recipeButtonCreator.CreateButtonList(recipesSOList);
        foreach (Button button in recipeButtonList) 
        {
            recipeScrollView.Add(button);
        }
    }



}
