using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VuforiaControl : MonoBehaviour
{
    public void DetenerVuforia()
    {
        VuforiaBehaviour.Instance.enabled = false;
    }

    public void ActivarVuforia()
    {
        VuforiaBehaviour.Instance.enabled = true;
    }

    private void OnEnable()
    {
        Eventos.ActivarVuforia += ActivarVuforia;
        Eventos.DetenerVuforia += DetenerVuforia;
    }

    private void OnDisable()
    {
        Eventos.ActivarVuforia -= ActivarVuforia;
        Eventos.DetenerVuforia -= DetenerVuforia;
    }
}
