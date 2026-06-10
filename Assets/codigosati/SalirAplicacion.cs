using UnityEngine;

public class SalirAplicacion : MonoBehaviour
{
    public void Salir()
    {
        Debug.Log("Saliendo de la aplicación...");
        Application.Quit();
    }
}