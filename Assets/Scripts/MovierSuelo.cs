using UnityEngine;

public class MoverSuelo : MonoBehaviour
{
    public float velocidad = 5f;
    public float limiteIzquierda = -10f;
    public float nuevaPosicionX = 10f;

    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x <= limiteIzquierda)
        {
            transform.position = new Vector2(nuevaPosicionX, transform.position.y);
        }
    }
}
