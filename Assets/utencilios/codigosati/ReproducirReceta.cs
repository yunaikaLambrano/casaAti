using UnityEngine;

public class ReproducirReceta : MonoBehaviour
{
    public AudioSource audioReceta;

    private bool estaPausado = false;

    public void ReproducirPausar()
    {
        if (audioReceta.isPlaying)
        {
            audioReceta.Pause();
            estaPausado = true;
        }
        else
        {
            if (estaPausado)
            {
                audioReceta.UnPause();
            }
            else
            {
                audioReceta.Play();
            }
        }
    }
}