using UnityEngine;

public class SPAWNER : MonoBehaviour
{
    public GameObject obstaculoPrefab;
    public float tiempoMin = 1f;
    public float tiempoMax = 2f;

    public Transform[] puntosSpawn;

    void Start()
    {
        Invoke("Spawn", 2f);
    }

    void Spawn()
    {
        int index = Random.Range(0, puntosSpawn.Length);

        GameObject obj = Instantiate(obstaculoPrefab, puntosSpawn[index].position, Quaternion.identity);

       
        MoverObstaculo mov = obj.GetComponent<MoverObstaculo>();

        if (index == 0) mov.direccion = Vector2.down;
        if (index == 1) mov.direccion = Vector2.right;
        if (index == 2) mov.direccion = Vector2.left;

        float tiempoRandom = Random.Range(tiempoMin, tiempoMax);
        Invoke("Spawn", tiempoRandom);
    }
}
