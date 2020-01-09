using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    public GameObject efectoparticulas;
    public Puntos puntos;
    
    // Is trigger DESACTIVADO
    void OnCollisionEnter()
    {
        Instantiate(efectoparticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
        transform.SetParent(null);
        puntos.GanarPunto();
    }
    
}
