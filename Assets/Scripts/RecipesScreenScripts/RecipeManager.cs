using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RecipeManager : MonoBehaviour
{
    public static RecipeManager Instance {  get; private set; }

    [SerializeField] VisualTreeAsset recipeTemplate;    //Template für die ButtonsSerializeField
    [SerializeField] List<RecipeSO> recipesSOList;
    List<VisualElement> recipeButtonsList;

    const string RecipeUSS = "Recipe";
    const string recipeButton = "recipeButton";

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log($"Mehrere Instancen von RecipeManager vorhanden! {gameObject} wird gelöscht!");
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    public List<VisualElement>CreateRecipeButtons()
    {
        if (recipesSOList == null)
        {
            Debug.Log("Keine Rezepte vorhanden!!");
            return null;
        }

        foreach (RecipeSO recipe in recipesSOList)
        {
            Button recipeButton = new Button();
            recipeButton.text = recipe.name;
            recipeButton.RegisterCallback<MouseDownEvent>(OnRecipeButtonClicked);

            recipeButtonsList.Add(recipeButton);
        }

        return recipeButtonsList;
    }

    private void OnRecipeButtonClicked(MouseDownEvent e)
    {
        //ShowRecipe(RecipesSO)
    }

}
