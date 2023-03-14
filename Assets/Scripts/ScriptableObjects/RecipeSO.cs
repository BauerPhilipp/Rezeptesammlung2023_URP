using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "Create recipe template", fileName ="Recipe template")]
public class RecipeSO : ScriptableObject
{
    [SerializeField] Sprite image;
    public string rezeptName;
    [SerializeField] List<Spice> spices;


    public void Start()
    {
    }

    public List<Spice>  GetSpiceList()
    {
        return spices;
    }


}
