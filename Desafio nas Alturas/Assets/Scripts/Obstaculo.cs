using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.left * 0.5f);
    }
}
