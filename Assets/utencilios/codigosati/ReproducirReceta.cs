using UnityEngine;

public class ReproducirReceta : MonoBehaviour
{
    public AudioSource audioReceta;

    public void ReproducirPausar()
    {
        if (audioReceta.isPlaying)
        {
            audioReceta.Pause();
        }
        else
        {
            audioReceta.UnPause();
        }
    }
}
