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

    [SerializeField]
    private int lifeTime = 0;

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

        lifeTime--;

        if(lifeTime <= 0)
        {
            GameObject.Destroy(this.transform.parent.gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "targetArea")
        {
            particleEffect.Instance.onHitEffect(this.transform.position);
            score.addPoint();
            GameObject.Destroy(this.transform.parent.gameObject);

        }
        else
        {
            if (other.gameObject.tag == "Obstacle")
                //particleEffect.Instance.onHitEffect(this.transform.position);
                GameObject.Destroy(this.transform.parent.gameObject);
        }
    }

}
