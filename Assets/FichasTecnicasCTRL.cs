using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[System.Serializable]
public class Marquilla
{
    public string Nombre;
    public string Apellido;
    public string Informacion;
    public string Tecnica;
}

public class FichasTecnicasCTRL : MonoBehaviour
{

    [Header("Campos de Texto - TMPro")]
    public TextMeshProUGUI NombreTMP;
    public TextMeshProUGUI ApellidoTMP;
    public TextMeshProUGUI NombreObraTMP;
    public TextMeshProUGUI TecnicaTMP;

    public GameObject FichasContenedor;
    public Image BarraProgresoGO;

    public List<Marquilla> Marquillas = new List<Marquilla>();

    private void LateUpdate()
    {
        print(Eventos.AudioProgreso + "----->>>");
        BarraProgresoGO.fillAmount = Eventos.AudioProgreso;
    }
    public void MostrarFicha()
    {
        FichasContenedor.SetActive(true);
    }

    public void OcultarFincha()
    {
        FichasContenedor.SetActive(false);
        Eventos.DetenerSonidos();
    }
    private void MostrarFichaTecnica(int queFichaTecnica)
    {
        int indice = queFichaTecnica;
        //print(indice+"-+-+-+-+");
        MostrarFicha();

        NombreTMP.text = Marquillas[indice].Nombre;
        ApellidoTMP.text = Marquillas[indice].Apellido;
        NombreObraTMP.text = Marquillas[indice].Informacion;
        TecnicaTMP.text = Marquillas[indice].Tecnica;
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
