using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableChest : MonoBehaviour
{
    public Color color;
    public GameObject inPanel;
    public GameObject inventoryPanel;
    public GameObject invPanel;
	public GameObject SpacePanel;
    private bool isPlayerIn = false;


    private void Start()
    {
        inPanel.SetActive(false);
    }

    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.O) && isPlayerIn)
        {
            Open();
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			
            inPanel.SetActive(true);
            isPlayerIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			SpacePanel.SetActive(false);
            inPanel.SetActive(false);
            invPanel.SetActive(false);
            inventoryPanel.SetActive(false);
            isPlayerIn = false;
        }
    }
    public void Open ()
    {
		SpacePanel.SetActive(true);
        inventoryPanel.SetActive(true);
        invPanel.SetActive(true);

    }
    
}
