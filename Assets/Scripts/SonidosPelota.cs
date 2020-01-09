using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosPelota : MonoBehaviour {


    public AudioSource rebote;
    public AudioSource punto;
    //public AudioSource perdio;

     void OnCollisionEnter(Collision otro) 
    {
        if (otro.gameObject.CompareTag("Bloque"))
        {
            punto.Play();
        }
        else
        {
            rebote.Play();
        }

       // if (perdio.gameObject.CompareTag("TAGPISO"))
       // {
        //    perdio.Play();
      //  }
    }
}
