using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{

    public float health = 150;

    private Animator anim;

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

        if (health < 0) 
        {
            anim.Play("deaath");
            Destroy(gameObject, 5);
        }
    }
}
