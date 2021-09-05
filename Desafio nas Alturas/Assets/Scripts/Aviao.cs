using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;

    [SerializeField]
    private float forca;

    private Diretor diretor;

    private Vector3 posicaoInicial;

    private void Awake()
    {
        posicaoInicial = transform.position;

        fisica = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        diretor = FindObjectOfType<Diretor>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Impulsionar();
        }
    }

    public void Reiniciar()
    {
        transform.position = posicaoInicial;

        fisica.simulated = true;
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
