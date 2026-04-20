using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string nombreEscena;

    public void CargarEscena()
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void SalirJuego()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego");
    }
}
