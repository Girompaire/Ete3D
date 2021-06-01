using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private int compteur;
    // Start is called before the first frame update
    void Start()
    {
        compteur = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Text>().text = compteur.ToString();
    }

    public void addPoint()
    {
        compteur++;
    }
}
