using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RecipeButton : VisualElement
{
    private RecipeSO recipeSO;
    private ScrollView scrollView;
    private RecipeScreen recipeScreen;

    const string styleSheetRecipes = "Recipes";
    const string recipeButtonClass = "recipeButton";

    public RecipeButton(ScrollView scrollView, RecipeSO recipeSO, RecipeScreen recipeScreen) 
    {
        this.scrollView = scrollView;
        this.recipeSO = recipeSO;
        this.recipeScreen = recipeScreen;

        Button recipeButton = new Button();
        recipeButton.text = recipeSO.name;
        recipeButton.styleSheets.Add(Resources.Load<StyleSheet>(styleSheetRecipes));
        recipeButton.AddToClassList(recipeButtonClass);
        recipeButton.clicked += RecipeButtonPressed;

        scrollView.Add(recipeButton);

    }

    private void RecipeButtonPressed()
    {
        recipeScreen.GetComponent<UIDocument>().enabled = true;
        VisualElement root = recipeScreen.GetComponent<UIDocument>().rootVisualElement;
        VisualElement thumbNail = root.Q("ThumbNail");
        thumbNail.style.backgroundImage = new StyleBackground(recipeSO.image);
        recipeScreen.GetComponent<UIDocument>().rootVisualElement.Q("BackButton").RegisterCallback<MouseDownEvent>(OnBackbuttonClicked);
    }

    void OnBackbuttonClicked(MouseDownEvent e)
    {
        recipeScreen.GetComponent<UIDocument>().enabled = false;
    }
}
