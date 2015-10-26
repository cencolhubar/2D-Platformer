using UnityEngine;
using System.Collections;
/// <summary>
/// This class is one of two classes that work together to scroll the blackground
/// </summary>
public class Scroll2 : MonoBehaviour
{
    private Vector2 leftBound;
    private Vector2 rightBound;
    public float scrSpeed;
    public float tileSizeY;

    private Vector2 startPos;
    private Vector2 currentPos;

    // Use this for initialization
    void Start()
    {
        // startPos = transform.position;
        currentPos = transform.position;
        leftBound = new Vector3(-45f, 0.0f,0);
        rightBound = new Vector3(45f, 0.0f,0);
    }

    // Update is called once per frame
    void Update()
    {

        // float newPos = Mathf.Repeat(Time.time * scrSpeed, tileSizeY);

        float newPos = Time.deltaTime * scrSpeed;
        // transform.Translate()
        transform.Translate(Vector3.left * newPos);
        if (transform.position.x <= leftBound.x)
        {
            transform.position = rightBound;
        }

        //  currentPos = transform.position;


    }
}