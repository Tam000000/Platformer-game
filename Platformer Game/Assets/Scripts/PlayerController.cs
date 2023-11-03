using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        if (Input.GetKey("w"))
        {
            newPosition.y += speed;
        }

        if (Input.GetKey("s"))
        {
            newPosition.y -= speed;
        }

        if (Input.GetKey("a"))
        {
            newPosition.x -= speed;
        }

        if (Input.GetKey("d"))
        {
            newPosition.x += speed;
        }

        transform.position = newPosition;
    }
}
