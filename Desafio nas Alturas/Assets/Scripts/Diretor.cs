using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;

    private Aviao aviao;

    private Pontuacao pontuacao;

    private void Start()
    {
        aviao = FindObjectOfType<Aviao>();
        pontuacao = FindObjectOfType<Pontuacao>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;

        imagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        imagemGameOver.SetActive(false);

        Time.timeScale = 1;

        aviao.Reiniciar();
        pontuacao.Reiniciar();

        DestruirObstaculos();
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = FindObjectsOfType<Obstaculo>();

        foreach (var obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
