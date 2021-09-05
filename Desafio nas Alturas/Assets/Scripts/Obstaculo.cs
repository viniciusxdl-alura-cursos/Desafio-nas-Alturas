using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.5f;

    private void Update()
    {
        transform.Translate(Vector3.left * velocidade);
    }
}
