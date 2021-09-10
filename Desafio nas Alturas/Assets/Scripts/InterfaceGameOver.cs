using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;

    [SerializeField]
    private Text valorRecorde;

    [SerializeField]
    private Image posicaoMedalha;

    [SerializeField]
    private Sprite medalhaOuro;

    [SerializeField]
    private Sprite medalhaPrata;

    [SerializeField]
    private Sprite medalhaBronze;

    private Pontuacao pontuacao;

    private float recorde;

    private void Start()
    {
        pontuacao = FindObjectOfType<Pontuacao>();
    }

    public void MostrarInterface()
    {
        AtualizarInterfaceGrafica();

        imagemGameOver.SetActive(true);
    }

    public void EsconderInterface()
    {
        imagemGameOver.SetActive(false);
    }

    private void AtualizarInterfaceGrafica()
    {
        recorde = PlayerPrefs.GetInt("recorde");

        valorRecorde.text = recorde.ToString();

        VerificarCorMedalha();
    }

    private void VerificarCorMedalha()
    {
        if (pontuacao.Pontos > recorde - 2)
        {
            posicaoMedalha.sprite = medalhaOuro;
        }
        else if (pontuacao.Pontos > recorde / 2)
        {
            posicaoMedalha.sprite = medalhaPrata;
        }
        else
        {
            posicaoMedalha.sprite = medalhaBronze;
        }
    }
}
