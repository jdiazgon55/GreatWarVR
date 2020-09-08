using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{

    public float health = 150;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("shouldIdle", true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeHealth(float damage)
    {
        // Damage has a negative value
        health += damage;
        Debug.Log("Damage: " + damage);
        Debug.Log("health: " + health);
        if (health < 0) 
        {
            Debug.Log("Vida por debajo de cero");
            anim.Play("deaath");
        }
    }
}
