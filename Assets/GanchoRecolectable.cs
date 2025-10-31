using UnityEngine;

public class GanchoRecolectable : MonoBehaviour
{
    void OnMouseDown()
    {
        // Aquí podrías agregar lógica de inventario si deseas
        Destroy(gameObject); // Desaparece el gancho
    }
}
