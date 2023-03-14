using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class RecipeButtonCreator : VisualElement
{

    const string styleSheetRecipes = "Recipes";
    const string recipeButtonClass = "recipeButton";


    public List<Button> CreateButtonList(List<RecipeSO> recipeSoList)
    {
        List<Button> recipeButtonList = new List<Button>();

        foreach (RecipeSO recipe in recipeSoList)
        {
            recipeButtonList.Add(CreateButton(recipe));
        }

        

        return recipeButtonList;
    }

    private Button CreateButton(RecipeSO recipe)
    {
        Button button = new Button();
        button.styleSheets.Add(Resources.Load<StyleSheet>(styleSheetRecipes));
        button.AddToClassList(recipeButtonClass);
        button.text = recipe.name;
        button.userData = recipe;
        button.clicked += OnRecipeButtonClicked;

        return button;
    }

    private void OnRecipeButtonClicked()
    {
        RecipeScreen recipeScreen = GameObject.FindObjectOfType<RecipeScreen>();
        UIDocument uiDocument = recipeScreen.gameObject.GetComponent<UIDocument>();
        uiDocument.enabled = true;


        
        recipeScreen.gameObject.SetActive(true);
    }

}
