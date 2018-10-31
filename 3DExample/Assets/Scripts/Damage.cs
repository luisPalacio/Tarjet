using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Damage : MonoBehaviour {
    public Scrollbar HealthBar;
    public float Health = 100;
    private bool isPlayerInside = false;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (isPlayerInside)
        {
            Dama(0.05f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;
        }
    }
        public void Dama(float value)
        {
            Health -= value;
            HealthBar.size = Health / 100f;
        }

    
}
