using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FichasTecnicasCTRL : MonoBehaviour
{
    [Header("Contenedor General")]
    public GameObject FichasContenedor;

    [Header("Barra de Progreso del Audio")]
    public Image BarraProgresoGO;

    [Header("Marquillas en Imagen")]
    public List<GameObject> MarquillasImagenes = new List<GameObject>();

    private void LateUpdate()
    {
        if (BarraProgresoGO != null)
        {
            BarraProgresoGO.fillAmount = Eventos.AudioProgreso;
        }
    }

    public void MostrarFicha()
    {
        FichasContenedor.SetActive(true);
    }

    public void OcultarFincha()
    {
        FichasContenedor.SetActive(false);

        foreach (GameObject imagen in MarquillasImagenes)
        {
            if (imagen != null)
            {
                imagen.SetActive(false);
            }
        }

        Eventos.DetenerSonidos();
    }

    private void MostrarFichaTecnica(int queFichaTecnica)
    {
        MostrarFicha();

        foreach (GameObject imagen in MarquillasImagenes)
        {
            if (imagen != null)
            {
                imagen.SetActive(false);
            }
        }

        if (queFichaTecnica >= 0 && queFichaTecnica < MarquillasImagenes.Count)
        {
            MarquillasImagenes[queFichaTecnica].SetActive(true);
        }
        else
        {
            Debug.LogWarning("Índice de marquilla fuera de rango: " + queFichaTecnica);
        }
    }

    private void OnEnable()
    {
        Eventos.MostrarFichaTecnica += MostrarFichaTecnica;
    }

    private void OnDisable()
    {
        Eventos.MostrarFichaTecnica -= MostrarFichaTecnica;
    }
}