using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Función para cargar la escena de juego
    public void Play()
    {
        SceneManager.LoadScene("Juego");
    }

    // Salir del juego (opcional)
    public void QuitGame()
    {
        Debug.Log("Juego cerrado.");
        Application.Quit();
    }
}