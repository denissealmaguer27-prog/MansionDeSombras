using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject playButton;
    public GameObject cinematicaPanel;

    public string gameSceneName = "juego"; // ← nombre exacto de tu escena de juego

    private bool cinematicaActiva = false;

    void Start()
    {
        playButton.SetActive(true);
        cinematicaPanel.SetActive(false);
    }

    public void OnPlayButtonClick()
    {
        playButton.SetActive(false);
        cinematicaPanel.SetActive(true);
        cinematicaActiva = true;
    }

    void Update()
{
    if (cinematicaActiva)
    {
        Debug.Log("Esperando clic para cargar la escena...");
    }

    if (cinematicaActiva && Input.GetMouseButtonDown(0))
    {
        Debug.Log("Clic detectado. Cargando escena...");
        SceneManager.LoadScene(gameSceneName);
    }
}

}
