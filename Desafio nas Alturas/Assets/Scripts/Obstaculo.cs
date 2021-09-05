using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.5f;

    [SerializeField]
    private float variacaoDaPosicaoY;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
