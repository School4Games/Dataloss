using UnityEngine;
using System.Collections;

public class SpawnBackground : MonoBehaviour {
	
	public float spawnTime;		// The amount of time between each spawn.
	public float spawnDelay;		// The amount of time before spawning starts.
	public GameObject[] tales;		// Array of enemy prefabs.
	
	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	void Spawn ()
	{
		// Instantiate a random enemy.
		int enemyIndex = Random.Range(0, tales.Length);
		Instantiate(tales[enemyIndex], transform.position, transform.rotation);
	}
}