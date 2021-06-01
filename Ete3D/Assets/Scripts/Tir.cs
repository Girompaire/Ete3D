using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour
{
    [SerializeField]
    private GameObject arc;
    
    [SerializeField]
    private GameObject projectile;

    [SerializeField]
    public bool canShoot;

    [SerializeField]
    private int speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (canShoot)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectile, arc.transform.position, Quaternion.identity);

            }
        }

    }

}
