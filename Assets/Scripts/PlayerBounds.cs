using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    float minX, maxX;
    float halfWidth;

    void Start()
    {
        Camera cam = Camera.main;

        
        halfWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2f;

        float zDistance = transform.position.z - cam.transform.position.z;

        Vector3 left = cam.ViewportToWorldPoint(new Vector3(0, 0.5f, zDistance));
        Vector3 right = cam.ViewportToWorldPoint(new Vector3(1, 0.5f, zDistance));

        minX = left.x + halfWidth;
        maxX = right.x - halfWidth;
    }

    void Update()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, minX, maxX);

        transform.position = pos;
    }




}
