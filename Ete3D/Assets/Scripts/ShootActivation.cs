using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootActivation : MonoBehaviour
{
    [SerializeField]
    public Tir script;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            script.canShoot = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            script.canShoot = false;
        }
    }
}
