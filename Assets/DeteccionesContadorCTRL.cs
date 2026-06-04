using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeteccionesContadorCTRL : MonoBehaviour
{
    public TextMeshProUGUI DeteccionesContador;
    public GameObject ObrasContenedorGO;
    public int hijosActivos = 0;
    public GameObject ScanAnimGO;

    private void Update()
    {
        if (ObrasContenedorGO == null) return;
        
        hijosActivos = 0;
        foreach (Transform child in ObrasContenedorGO.transform)
        {
            Canvas canvas = child.GetComponentInChildren<Canvas>();

            if (canvas != null && canvas.enabled)
            {
                hijosActivos++;
            }
        }

        if (hijosActivos == 0)
        {
            ScanAnimGO.SetActive(true);
        }
        else
        {
            ScanAnimGO.SetActive(false);
        }
    }
    private void LateUpdate()
    {
        string conteo = hijosActivos.ToString("D2");
        DeteccionesContador.text = "OBRAS DETECTADAS: " + conteo;
    }
}
