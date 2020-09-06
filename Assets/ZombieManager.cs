using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{

    public float health = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeHealth(float damage)
    {
        Debug.Log("Me has dado con un danyo de: " + damage);
        health = health - damage;
        if (health < 0) 
        {
            Debug.Log("Vida por debajo de cero");
        }
    }
}
