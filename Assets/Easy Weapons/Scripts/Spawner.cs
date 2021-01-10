/// <summary>
/// Spawner.cs
/// Author: MutantGopher
/// This is a sample spawning script used to spawn the red cubes in the demo scene.
/// </summary>

using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	public GameObject prefabToSpawn;				// The prefab that should be spawned
	public float spawnFrequency = 6.0f;				// The time (in seconds) between spawns
	public bool spawnOnStart = false;				// Whether or not one instance of the prefab should be spawned on Start()
	public GameObject[] spawnPositions;				// Random spawn points for the prefab
	public int maxSpawned = 4;                      // Maximum number of objects to spawn
	public GameObject weaponSpawner;                // The enemies spawner gameobject

	private float spawnTimer = 0.0f;
	private int enemiesSpawned = 0;
	private WeaponSpawner spawner;

	// Use this for initialization
	void Start()
	{
		if (spawnOnStart)
		{
			Spawn();
		}

	    spawner = weaponSpawner.GetComponent<WeaponSpawner>();
	}
	
	// Update is called once per frame
	void Update()
	{
		// Update the spawning timer
		spawnTimer += Time.deltaTime;

		// Spawn a prefab if the timer has reached spawnFrequency
		if (spawnTimer >= spawnFrequency)
		{
			// First reset the spawn timer to 0
			spawnTimer = 0.0f;
			// Check how many enemies are already spawned
			if (GameObject.FindGameObjectsWithTag("Enemy").Length < maxSpawned)
			{
				Spawn();
			}
		}

	}

	void Spawn()
	{
		// Get one random position from the vector of GameObjects
		Vector3 newPosition = spawnPositions[Random.Range(0, spawnPositions.Length)].transform.position;
		// First check to see if the prefab hasn't been set
		if (prefabToSpawn != null)
		{
			// Instantiate the prefab
			Instantiate(prefabToSpawn, newPosition, Quaternion.identity);
			enemiesSpawned++;
		}

		if (enemiesSpawned > 5)
        {
			spawner.activateNextWeapon();
			enemiesSpawned = 0;
		}
	}

	public int getEnemiesSpawnedCount()
    {
			return enemiesSpawned++;
	}
}

