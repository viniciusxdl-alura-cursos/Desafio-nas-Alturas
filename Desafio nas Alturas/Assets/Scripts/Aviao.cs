using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;

    [SerializeField]
    private float forca = 6;

    private Diretor diretor;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
        diretor = FindObjectOfType<Diretor>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Impulsionar();
        }
    }

    private void Impulsionar()
    {
        fisica.velocity = Vector2.zero;

        fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        fisica.simulated = false;

        diretor.FinalizarJogo();
    }
}
