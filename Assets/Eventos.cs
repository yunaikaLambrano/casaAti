using System;

public static class Eventos
{
    public static Action DetenerSonidos;
    public static Action <bool>MostrarOcultarAudioCanvas;

    public static int MarcadorDetectado;
    public static Action ActivarBotonStop;
    public static Action DesactivarBotonStop;

    public static Action DetenerAnimacionScan;

    public static Action <int>MostrarFichaTecnica; // int recibe el indice de la marquilla a mostrar

    public static float AudioProgreso;

    public static Action ActivarVuforia;
    public static Action DetenerVuforia;
}
