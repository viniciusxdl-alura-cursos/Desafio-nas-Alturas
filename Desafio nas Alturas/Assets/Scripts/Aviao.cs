using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Impulsionar();
        }
    }

    private void Impulsionar()
    {
        fisica.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
