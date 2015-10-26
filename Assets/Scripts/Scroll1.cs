using UnityEngine;
using System.Collections;
/// <summary>
/// This class is one of two classes that work together to scroll the blackground
/// </summary>
public class Scroll1 : MonoBehaviour
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
        leftBound = new Vector2(-50f, 0.0f);
            rightBound  = new Vector2(50f, 0.0f);
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