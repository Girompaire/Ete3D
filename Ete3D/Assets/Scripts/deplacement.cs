using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        Vector3 move = new Vector3();
        if (Input.GetKey(KeyCode.UpArrow))
            move.y += 0.01f;

        if (Input.GetKey(KeyCode.DownArrow))
            move.y -= 0.01f;


        if (Input.GetKey(KeyCode.LeftArrow))
            move.x -= 0.01f;

        if (Input.GetKey(KeyCode.RightArrow))
            move.x += 0.01f;

        transform.position += move;

    }
}
