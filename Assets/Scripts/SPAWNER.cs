using UnityEngine;

public class SPAWNER : MonoBehaviour
{
    public GameObject obstaculoPrefab;
    public float tiempoMin = 1.5f;
    public float tiempoMax = 3f;

    void Start()
    {
        Invoke("Spawn", 2f);
    }

    void Spawn()
    {
        Instantiate(obstaculoPrefab, transform.position, Quaternion.identity);

        float tiempoRandom = Random.Range(tiempoMin, tiempoMax);
        Invoke("Spawn", tiempoRandom);
    }
}
