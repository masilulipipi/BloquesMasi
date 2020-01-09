using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

    public static int vidas = 1000;

    public Text Textovidas;

    public Bola bola;
    public MovBarra barra;

    public GameObject GameOver;
    public SiguienteNivel siguienteNivel;

    public SonidoFinPartida sonidosfinpartida;

   // public GameObject efectoparticulas;

    // Use this for initialization
    void Start ()
    {
        ActualizarMarcadorVidas();
	}
	
    void ActualizarMarcadorVidas()
    {
        Textovidas.text = "Vidas: " + Vidas.vidas;
    }
	
    public void PerderVida()
    {
        if (vidas <= 0)
        {
            return;
        }

        Vidas.vidas--;
        ActualizarMarcadorVidas();
        //sonidosfinpartida.GameOver();
        //MovBarra.Instantiate(efectoparticulas, transform.position, Quaternion.identity);


        if (vidas <= 0)
        {
            // Mostramos game Over
            sonidosfinpartida.GameOver();
            GameOver.SetActive(true);
            bola.Detenermovimiento();
            barra.enabled = false;

            siguienteNivel.nivelACargar = "Portada";
            siguienteNivel.ActivarCarga();
        }
        else
        {
            barra.Reset();
            bola.Reset();
        }
    }
}
