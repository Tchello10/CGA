using UnityEngine;
using UnityEngine.Audio;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento do personagem
    public float jumpForce = 10f; // Força do impulso vertical

    private Rigidbody2D rb;
    private bool isGrounded;

    [SerializeField] private AudioSource jumpSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D anexado ao personagem
    }

    void Update()
    {
        // Entrada do usuário para movimentação horizontal (setas do teclado ou A, D)
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Movimento horizontal
        rb.velocity = new Vector2(moveHorizontal * moveSpeed, rb.velocity.y);

        // Verificar se o personagem está no chão
        isGrounded = Mathf.Abs(rb.velocity.y) < 0.001f;

        // Adiciona impulso vertical quando a tecla de salto é pressionada (espaço)
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumpSound.Play();
        }
    }
}
