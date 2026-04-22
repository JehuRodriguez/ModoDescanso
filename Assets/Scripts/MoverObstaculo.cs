using UnityEngine;

public class MoverObstaculo : MonoBehaviour
{
    public Vector2 direccion;
    public float velocidad = 5f;

    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}

