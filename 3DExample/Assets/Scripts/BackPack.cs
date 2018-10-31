using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPack : MonoBehaviour {
    public GameObject PanelPrincipal;
    public GameObject PanelMochila;
    public bool flag = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.I) )
        {
            Open();
        }
       
        

    }
    public void Open()
    {
        if ( flag)
        {
            PanelPrincipal.SetActive(false);
            PanelMochila.SetActive(false);
            flag = false;
        }
        else
        {
            
            PanelPrincipal.SetActive(true);
            PanelMochila.SetActive(true);
            flag = true;
        }

    }

}
