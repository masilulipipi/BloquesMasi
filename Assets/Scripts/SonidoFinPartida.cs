using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoFinPartida : MonoBehaviour {

    public AudioSource audiosource;
    public AudioClip Completado;
    public AudioClip gameOver;

	public void GameOver()
    {
        ReproduceSonido(gameOver);
    }

    public void NivelCompletado()
    {
        ReproduceSonido(Completado);
    }

    void ReproduceSonido(AudioClip sonido)
    {
        audiosource.clip = sonido;
        audiosource.loop = false;
        audiosource.Play();
    }
}
