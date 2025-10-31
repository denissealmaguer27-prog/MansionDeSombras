using UnityEngine;

public class RecogerLlave : MonoBehaviour
{
    public bool tieneLlave = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Llave"))
        {
            Destroy(other.gameObject);
            tieneLlave = true;
            Debug.Log("¡Llave recogida!");
        }
    }
}
