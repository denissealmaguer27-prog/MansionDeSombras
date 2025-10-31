using UnityEngine;

public class CamaClickConLlave : MonoBehaviour
{
    public Sprite camaModificada;
    public Sprite camaNormal;
    public GameObject llave;

    private SpriteRenderer sr;
    private bool modificada = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = camaNormal;

        if (llave != null)
            llave.SetActive(false); // La llave comienza oculta
    }

    void OnMouseDown()
    {
        if (!modificada)
        {
            sr.sprite = camaModificada;
            modificada = true;

            if (llave != null)
                llave.SetActive(true); // La llave aparece al destapar la cama
        }
        else
        {
            sr.sprite = camaNormal;
            modificada = false;

            if (llave != null)
                llave.SetActive(false); // Si quieres que se oculte otra vez
        }
    }
}
