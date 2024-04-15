using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public static bool inventoryIsOpen = false;
    public GameObject inventoryUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventoryIsOpen)
            {
                Open();
            }
            else
            {
                Closed();
            }
        }
    }

    public void Open()
    {
        inventoryUI.SetActive(false);

        Time.timeScale = 1f;
        inventoryIsOpen = false;
    }
    public void Closed()
    {
        inventoryUI.SetActive(true);
        Time.timeScale = 0f;
        inventoryIsOpen = true;
    }
}
