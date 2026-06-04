using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerControlador : MonoBehaviour
{
    private void LateUpdate()
    {
        if (Eventos.MarcadorDetectado > 0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
