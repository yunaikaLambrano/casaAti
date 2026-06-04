using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcadorDetectadoControlador : MonoBehaviour
{
    public void AumentarMarcadorDetectado()
    {
        Eventos.MarcadorDetectado++;
    }

    public void DisminuirMarcadorDetectado()
    {
        Eventos.MarcadorDetectado--;
    }

}
