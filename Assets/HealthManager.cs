using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public float health = 150;
    public int animatorSpeed = 2;

    private Animator anim;
    private AudioSource hitSound;
    private bool shouldPlaySound = false;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("shouldIdle", true);
        
        hitSound = GetComponent<AudioSource> ();
        if (hitSound != null) {
            shouldPlaySound = true;
        }
    }

    public void ChangeHealth(float damage)
    {
        // Damage has a negative value
        health += damage;
        
        if (shouldPlaySound) {
            hitSound.Play();
        }

        if (health < 0) 
        {
            shouldPlaySound = false;
            anim.speed = animatorSpeed;
            anim.Play("death");
            Destroy(gameObject, 5);
        }
    }
}
