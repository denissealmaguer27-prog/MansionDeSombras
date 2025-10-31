using UnityEngine;

public class VentanaClick : MonoBehaviour
{
    public Sprite ventanaAbierta; // Arrastra el sprite desde el inspector
    private SpriteRenderer sr;

    private bool abierta = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        if (!abierta)
        {
            sr.sprite = ventanaAbierta;
            abierta = true;
        }
    }
}
