using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBarra : MonoBehaviour {
    

    public float Velocidad = 0.4f;
    Vector3 posicioninicial;

    public ElementoInteractivo botonIzquierda;
    public ElementoInteractivo botonDerecha;

    // Use this for initialization
    void Start () {
        posicioninicial = transform.position;
	}

    public void Reset()
    {
        transform.position = posicioninicial;
    }

    // Update is called once per frame
    void Update () {
                
       float direccion = botonIzquierda.pulsado ? -1 : (botonDerecha.pulsado ? 1: Input.GetAxisRaw("Horizontal"));

      // float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
       float posX = transform.position.x + (direccion * Velocidad * Time.deltaTime);

        transform.position = new Vector3(Mathf.Clamp(posX,-8,8), transform.position.y, transform.position.z);

        


    }
}
