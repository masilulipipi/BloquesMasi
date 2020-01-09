using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sonidoperdio : MonoBehaviour
{

    public AudioSource fallo;
    

    

    void OnTriggerEnter()
    {
        fallo.Play();
    }

}