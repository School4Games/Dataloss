using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public float spawnTime;		// zeit zwischen den spawns 
	public float spawnDelay;		// zeit bevor der spwan beginnt
	public GameObject[] enemies;
	public float timer;
	public float minspawntime;


	
	void Start ()
	{
		timer = spawnDelay;
	}
	
	void Spawn ()
	{
		spawnTime *= Random.Range(0.75f, 1.1f);
		if (spawnTime < minspawntime) 
		{
			spawnTime = minspawntime;
		}
		Debug.Log("SpawnUp");

		int enemyIndex = Random.Range(0, enemies.Length);
		Instantiate(enemies[enemyIndex], transform.position, transform.rotation);
	}


	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = spawnTime;
			Spawn();
		}
	}

}
