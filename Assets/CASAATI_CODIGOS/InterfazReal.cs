using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfazReal : MonoBehaviour
{
    public void IrInicio()
    {
        print("inicio");
        SceneManager.LoadScene("inicio");
    }

    public void IrEscena1()
    {
        print("escaner");
        SceneManager.LoadScene("escaner");
    }

    public void IrEscena2()
    {
        print("info_pilon");
        SceneManager.LoadScene("info_pilon");
    }
    public void IrEscena3()
    {
        print("grupo_laborArtesanal");
        SceneManager.LoadScene("grupo_laborArtesanal");
    }
    public void IrEscena4()
    {
        print("gruposTodos ");
        SceneManager.LoadScene("gruposTodos");
    }
    public void IrEscena5()
    {
        print("Room001 ");
        SceneManager.LoadScene("Room001");
    }


}
