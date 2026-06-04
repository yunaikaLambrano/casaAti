using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanAnimacionCTRL : MonoBehaviour
{
    public Animator _anim;
    private void IniciarAnimacion()
    {
        _anim.SetBool("Stop",false);
    }

    private void DetenerAnimacion()
    {
        _anim.SetBool("Stop", true);
    }

    private void OnEnable()
    {
        Eventos.DetenerSonidos += IniciarAnimacion;
        Eventos.DetenerAnimacionScan += DetenerAnimacion;
    }


    private void OnDisable()
    {
        Eventos.DetenerSonidos -= IniciarAnimacion;
        Eventos.DetenerAnimacionScan -= DetenerAnimacion;
    }
}
