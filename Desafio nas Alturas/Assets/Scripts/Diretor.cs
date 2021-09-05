using UnityEngine;

public class Diretor : MonoBehaviour
{
    private Aviao aviao;

    private Pontuacao pontuacao;

    private InterfaceGameOver interfaceGameOver;

    private void Start()
    {
        aviao = FindObjectOfType<Aviao>();
        pontuacao = FindObjectOfType<Pontuacao>();
        interfaceGameOver = FindObjectOfType<InterfaceGameOver>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;

        pontuacao.SalvarRecorde();
        interfaceGameOver.MostrarInterface();
    }

    public void ReiniciarJogo()
    {
        interfaceGameOver.EsconderInterface();

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
