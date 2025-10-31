using UnityEngine;

public class ClosetClickConGancho : MonoBehaviour
{
    public Sprite closetCerrado;
    public Sprite closetAbierto;
    public GameObject gancho;

    private SpriteRenderer sr;
    private bool abierto = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = closetCerrado;

        if (gancho != null)
            gancho.SetActive(false); // Ocultar el gancho al inicio
    }

    void OnMouseDown()
    {
        abierto = !abierto;

        sr.sprite = abierto ? closetAbierto : closetCerrado;

        if (gancho != null)
            gancho.SetActive(abierto); // Mostrar solo si está abierto
    }
}
