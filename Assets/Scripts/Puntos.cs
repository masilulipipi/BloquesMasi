using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

    public static int puntos = 0;
    public Text textopuntos;

    public GameObject NivelCompletado;
    public GameObject JuegoCompletado;

    public MovBarra movbarra;

    public SiguienteNivel siguienteNivel;

    public Bola bola;

    public Transform contenedorBloques;

    public SonidoFinPartida SONIDOfinpartida;

    // Use this for initialization
    void Start () {

        ActualizaMarcadorPuntos();
		
	}

    void ActualizaMarcadorPuntos()
    {
        textopuntos.text = "Puntos: " + Puntos.puntos;
    }

    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizaMarcadorPuntos();

        if (contenedorBloques.childCount <= 0)
        {
            bola.Detenermovimiento();
            movbarra.enabled = false;


            if (siguienteNivel.EsUltimoNivel())
            {
                JuegoCompletado.SetActive(true);
            }
            else
            {
                NivelCompletado.SetActive(true);
            }
            siguienteNivel.ActivarCarga();

            SONIDOfinpartida.NivelCompletado();

        }
        
    }  
}
