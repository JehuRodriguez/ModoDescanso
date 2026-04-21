using UnityEngine;

public class MoverObstaculo : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
    }
}

