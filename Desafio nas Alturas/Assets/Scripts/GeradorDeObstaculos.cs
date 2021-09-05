using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;

    [SerializeField]
    private GameObject manualDeInstrucoes;

    private float cronometro;

    private void Awake()
    {
        cronometro = tempoParaGerar;
    }

    private void Update()
    {
        cronometro -= Time.deltaTime;

        if (cronometro < 0)
        {
            Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);

            cronometro = tempoParaGerar;
        }
    }
}
