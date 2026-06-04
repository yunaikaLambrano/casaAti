using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonDetenerCTRL : MonoBehaviour
{
    public GameObject ActivoGO;
    public GameObject InactivoGO;

    private void Start()
    {
        BotonInactivo();
    }
    public void DetenerSonidos()
    {
        BotonInactivo();
    }

    public void BotonActivo()
    {
        ActivoGO.SetActive(true);
        InactivoGO.SetActive(false);
    }

    public void BotonInactivo()
    {
        ActivoGO.SetActive(false);
        InactivoGO.SetActive(true);
        Eventos.DetenerSonidos();
    }

    private void OnEnable()
    {
        Eventos.ActivarBotonStop += BotonActivo;
        Eventos.DesactivarBotonStop += BotonInactivo;
    }

    private void OnDisable()
    {
        Eventos.ActivarBotonStop -= BotonActivo;
        Eventos.DesactivarBotonStop -= BotonInactivo;
    }
}
