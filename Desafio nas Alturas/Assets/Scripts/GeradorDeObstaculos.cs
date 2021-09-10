using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerarFacil;

    [SerializeField]
    private float tempoParaGerarDificil;

    [SerializeField]
    private GameObject manualDeInstrucoes;

    private float cronometro;

    private ControleDeDificuldade ControleDeDificuldade;

    private void Awake()
    {
        cronometro = tempoParaGerarFacil;
    }

    private void Start()
    {
        ControleDeDificuldade = FindObjectOfType<ControleDeDificuldade>();
    }

    private void Update()
    {
        cronometro -= Time.deltaTime;

        if (cronometro < 0)
        {
            Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);

            cronometro = Mathf.Lerp(tempoParaGerarFacil,
                tempoParaGerarDificil,
                ControleDeDificuldade.Dificuldade);
        }
    }
}
