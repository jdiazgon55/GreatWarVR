﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public float health = 150;
    public int animatorSpeed = 2;

    private Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("shouldIdle", true);
    }

    void ChangeHealth(float damage)
    {
        // Damage has a negative value
        health += damage;

        if (health < 0) 
        {
            anim.speed = animatorSpeed;
            anim.Play("death");
            Destroy(gameObject, 5);
        }
    }
}
