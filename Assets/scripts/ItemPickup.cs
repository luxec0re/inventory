using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public Item Item;

   
    void Update()
    {
        
    }

    public void PickUpItem()
    {

        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }


}
