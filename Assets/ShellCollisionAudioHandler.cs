using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellCollisionAudioHandler : MonoBehaviour
{
    AudioSource shellSound;
    bool notYetPlayed = true;
    public string layerName = "Default";

    void Start()
    {
        shellSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (notYetPlayed && isCollisionWithLayer(collision)) 
        {
            shellSound.Play();
            notYetPlayed = false;
        }
    }

    bool isCollisionWithLayer(Collision collision) {
        if (collision.gameObject.layer == LayerMask.NameToLayer(layerName))
        {
            return true;
        }
        return false;
    }
}
