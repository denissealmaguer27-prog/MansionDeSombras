using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    public GameObject cinematicaPanel;
    private bool mostrandoCinematica = false;

    public string nombreEscenaJuego = "Juego"; // Cambia al nombre real de tu escena

    public void MostrarCinematica()
    {
        cinematicaPanel.SetActive(true);
        mostrandoCinematica = true;
    }

    void Update()
    {
        if (mostrandoCinematica && (Input.GetMouseButtonDown(0) || Input.anyKeyDown))
        {
            SceneManager.LoadScene(nombreEscenaJuego);
        }
    }
}
