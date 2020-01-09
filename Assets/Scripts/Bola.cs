using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    public float VelocidadInicial = 600f;
    public Rigidbody rig;
    bool enjuego;
    Vector3 posicioninicial;

    public ElementoInteractivo pantalla;

    public Transform MovBarra;


    // Use this for initialization
    void Start ()
    {
        transform.position = posicioninicial;
    }

    public void Reset()
    {
        transform.position = posicioninicial;
        transform.SetParent(MovBarra);
        enjuego = false;
        Detenermovimiento();
    }

    public void Detenermovimiento()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero; 
    }


    // Update is called once per frame
    void Update ()
    {
        if (!enjuego && (Input.GetButtonDown("Fire1") || pantalla.pulsado))
        {
            enjuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(VelocidadInicial, VelocidadInicial, 0));
        }	
	}
}
