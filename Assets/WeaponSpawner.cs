using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{

    public GameObject[] weaponsToSpawn;             // All weapons that will be spawned (in order of appearance)
    private int currentlyActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < weaponsToSpawn.Length; i++)
        {
            weaponsToSpawn[i].SetActive(false);
        }
    }

    // Update is called once per frame
    public void activateNextWeapon()
    {
        Destroy(weaponsToSpawn[currentlyActive]);
        currentlyActive++;
        weaponsToSpawn[currentlyActive].SetActive(true);
    }
}
