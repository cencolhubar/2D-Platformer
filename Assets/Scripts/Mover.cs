using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    private Vector2 startPos;
    public float scrSpeed;
    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Time.deltaTime * scrSpeed;
        transform.Translate(Vector3.left * newPos);



    }
}
