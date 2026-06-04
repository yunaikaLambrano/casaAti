using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySounds : MonoBehaviour
{
    public AudioSource Sonido1;
    public Image ImagenProgreso;
    public GameObject PlayIconGO;
    public GameObject StopIconGO;
    public float progreso = 0;

    [Header("Indice del Audio")]
    public int AudioIndice;

    //
    private void Awake()
    {
        PlayIconGO.SetActive(true);
        StopIconGO.SetActive(false);
        //_MostrarOcultarAudioCanvas(false);
    }

    private void LateUpdate()
    {
        if (Sonido1.time > 0)
        {
            float tiempoActual = Sonido1.time;
            float duracion = Sonido1.clip.length;
            progreso = tiempoActual / duracion;
            ImagenProgreso.fillAmount = progreso;
            Eventos.AudioProgreso = progreso;
        }else if (progreso == 1)
        {
            DetenerSonido1();
            Eventos.AudioProgreso = 0;
        }else if(progreso == 0)
        {
            ImagenProgreso.fillAmount = 0;
        }
    }

    private void OnEnable()
    {
        Eventos.DetenerSonidos += DetenerSonido1;
        //Eventos.MostrarOcultarAudioCanvas += _MostrarOcultarAudioCanvas;
    }

    private void OnDisable()
    {
        Eventos.DetenerSonidos -= DetenerSonido1;
        //Eventos.MostrarOcultarAudioCanvas -= _MostrarOcultarAudioCanvas;
    }

    public void _MostrarOcultarAudioCanvas(bool estado)
    {
        gameObject.SetActive(estado);
    }

    public void _MostrarAudioCanvas()
    {
        gameObject.SetActive(true);
    }

    public void DetenerSonido1()
    {
        Sonido1.Stop();
        PlayIconGO.SetActive(true);
        StopIconGO.SetActive(false);
        ImagenProgreso.fillAmount = 0;
        //--
        //Eventos.ActivarBotonStop();
        Eventos.ActivarVuforia();
    }

    public void RerpSonido1()
    {
        if (Sonido1.isPlaying)
        {
            Sonido1.Stop();
            PlayIconGO.SetActive(true);
            StopIconGO.SetActive(false);
            // si se detienen los sonidos
            //Eventos.DesactivarBotonStop();
        }
        else
        {
            Eventos.DetenerSonidos();
            Sonido1.Play();
            PlayIconGO.SetActive(false);
            StopIconGO.SetActive(true);
            // si se reproduce un sonido
            //Eventos.ActivarBotonStop(); // activa el boton de stop (inicial)
            //Eventos.DetenerAnimacionScan(); // detiene la animacion del scanner

            //print(AudioIndice + "-----");
            Eventos.MostrarFichaTecnica(AudioIndice);
            Eventos.DetenerVuforia();
        }
    }
}
