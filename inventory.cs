using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public GameObject inventoryObject;
    private bool inventoryOpen = false;
    
    void Start()
    {
        inventoryObject.gameObject.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)) {
            if(!inventoryOpen){
                Debug.Log("Opened up inventory.");
                inventoryOpen = true;
                inventoryObject.gameObject.SetActive(inventoryOpen);
                FindObjectOfType<gameManager>().gamePaused();
                
            } else if(inventoryOpen){
                Debug.Log("Closed inventory.");
                inventoryOpen = false;
                inventoryObject.gameObject.SetActive(inventoryOpen);
                FindObjectOfType<gameManager>().gameRunning();
            }
        }
    }
}
