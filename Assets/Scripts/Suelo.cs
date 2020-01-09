using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public Vidas vida;

    public void OnTriggerEnter()
    {
        vida.PerderVida();
    }

}