using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playingType : MonoBehaviour
{

    int type;
    // Start is called before the first frame update
    void Start()
    {
        type = PlayerPrefs.GetInt("playing_type");
    }

    private Vector3 pos1 = new Vector3(-8, 0, 10);
    private Vector3 pos2 = new Vector3(8, 0, 10);
    public float speed = 1.0f;

    void Update()
    {
        if(type == 1)
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}

