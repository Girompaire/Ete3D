using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    private int speed;
    GameObject targetArea;
    GameObject ScorePoints;
    Score score;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
        targetArea = GameObject.FindGameObjectWithTag("targetArea");
        score = GameObject.FindGameObjectWithTag("scorePoints").GetComponent<Score>();
        this.gameObject.AddComponent<Rigidbody>();
        this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
    }

    // Update is called once per frame
    void Update()
    {
        // Move our position a step closer to the target.
        this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
     }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "targetArea")
        {
            score.addPoint();
            GameObject.Destroy(this.gameObject);
        }
    }

}
