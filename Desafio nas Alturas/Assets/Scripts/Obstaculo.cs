using Assets.Scripts;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhadaFloat velocidade;

    [SerializeField]
    private float variacaoDaPosicaoY;

    private Vector3 posicaoDoAviao;

    private Pontuacao pontuacao;

    private bool pontuei;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Start()
    {
        posicaoDoAviao = FindObjectOfType<Aviao>().transform.position;
        pontuacao = FindObjectOfType<Pontuacao>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * velocidade.valor * Time.deltaTime);

        if (!pontuei && transform.position.x < posicaoDoAviao.x)
        {
            pontuei = true;

            pontuacao.AdicionarPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Destruir();
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }
}
