using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private Text valorRecorde;

    public void AtualizarInterfaceGrafica()
    {
        int recorde = PlayerPrefs.GetInt("recorde");

        valorRecorde.text = recorde.ToString();
    }
}
