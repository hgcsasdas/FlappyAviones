
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float Speed = 5f;
    private float leftEdge;
    // Start is called before the first frame update
    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject); 
        }
    }
}
