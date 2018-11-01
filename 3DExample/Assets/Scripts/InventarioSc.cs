using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventarioSc : MonoBehaviour
{


    public GameObject PanelPrincipal;
    public GameObject PanelMochila;
    public bool flag = false;
    public Button ButtonF;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ButtonF.onClick.AddListener(Open);




    }
    public void Open()
    {
        if (flag)
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
