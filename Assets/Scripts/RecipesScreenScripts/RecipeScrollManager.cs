using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RecipeScrollManager : MonoBehaviour
{
    RecipeButtonCreator recipeButtonCreator;

    VisualElement root;
    ScrollView recipeScrollView;
    List<Button> RecipeButtonList;

    [SerializeField] List<RecipeSO> recipesSOList;




    private void Start()
    {


        root = GetComponent<UIDocument>().rootVisualElement;
        recipeScrollView = root.Q<ScrollView>("RecipeScrollView");
        recipeButtonCreator = new RecipeButtonCreator(recipesSOList);
    }


    private void CreateRecipeButtons()
    {

    }



}
