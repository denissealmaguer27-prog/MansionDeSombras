using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 5f;
    private Animator animator;
    private Rigidbody2D rb;
    private Vector2 movimiento;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Obtener entrada del teclado
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");

        // Verificar si hay movimiento
        bool estaCaminando = movimiento != Vector2.zero;
        animator.SetBool("isWalking", estaCaminando);
    }

    void FixedUpdate()
    {
        // Mover al personaje
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}
