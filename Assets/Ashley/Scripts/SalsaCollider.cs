using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SalsaCollider : MonoBehaviour
{
    public GameObject salsa1;
    public GameObject salsa2;
    public GameObject salsa3;
    public GameObject thisSalsa;

  

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //turnOff();
            thisSalsa.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        salsa1.SetActive(false);
        salsa2.SetActive(false);
        salsa3.SetActive(false);
    }

    
       






}