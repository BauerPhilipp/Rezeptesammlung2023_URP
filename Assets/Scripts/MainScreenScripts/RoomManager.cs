using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{

    [SerializeField] LayerMask roomLayer;

    public void Start()
    {
        
    }

    private void Update()
    {
        KitchenClicked();
    }

    private void KitchenClicked()
    {
        if(!Input.GetMouseButtonDown(0)) { return; }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //wenn die Küche angelickt wurde
        if(Physics.Raycast(ray, out RaycastHit hit, roomLayer))
        {
            Debug.Log("Küche wurde angeklickt!");
        }

    }

}
