using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class Inside : MonoBehaviour {
    private bool isPlayerIn = false;
    public GameObject car;
    public GameObject persona;
    CarController myScript;
    CarUserControl myScript2;
    public Camera Camera_Pers;
    public Camera Camera_Carro;


    // Use this for initialization
    void Start () {

        myScript = gameObject.GetComponent<CarController>();
        myScript2 = gameObject.GetComponent<CarUserControl>();
        persona.SetActive(true);
        car.SetActive(true);
        Camera_Carro.enabled = false;


    }
     //drag the gameobject which have that script you want to disable, in the inspector.
 
     
private void Update()
    {


        if (Input.GetKeyDown(KeyCode.O) && isPlayerIn)
        {
            Open();

        }
        if (Input.GetKeyDown(KeyCode.E) && isPlayerIn)
        {
            Exit();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

           
            isPlayerIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerIn = false;
        }
    }
    public void Open()
    {
        Camera_Pers.enabled = false;
        myScript.enabled = !myScript.enabled;
        myScript2.enabled = !myScript2.enabled;
        persona.SetActive(false);
        car.SetActive(true);
        Camera_Carro.enabled = true;

    }
    public void Exit()
    {
        Camera_Pers.enabled = true;
        persona.SetActive(true);
        car.SetActive(true);
        myScript.enabled = !myScript.enabled;
        myScript2.enabled = !myScript2.enabled;
        Camera_Carro.enabled = false;

    }
}
