using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public bool invincible;
	public float health = 2f;
	public float maxHealth =2f;
	public float timer;
	private float regenration =1f;


	private GameObject score100;
	private GameObject score500;
	private GameObject bitsswipe;
	private GameObject megabytetaillongmid;
	private GameObject megabytetailmid;
	private GameObject megabytetailmidright;
	private GameObject megabytetailleft;
	private GameObject megabytetaillright;

	private GameObject enemyDeath;
	// Use this for initialization
	void Start () {

		health = maxHealth;
		score100 = GameObject.Find ("Score100");
		score500 = GameObject.Find ("Score500");
		enemyDeath = GameObject.Find ("EnemyDeath");
		bitsswipe = GameObject.Find ("bitsswipe");
		megabytetaillongmid = GameObject.Find ("megabytetaillongmid");
		megabytetailmid = GameObject.Find ("megabytetailmid");
		megabytetailmidright = GameObject.Find ("megabytetailmidright");
		megabytetailleft = GameObject.Find ("megabytetailleft");
		megabytetaillright = GameObject.Find ("megabytetaillright");

	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = 0;
			invincible = false;
		}
		if (health <= 0.0f) 
		{
			Destroy(this.gameObject);
			Time.timeScale = 0;
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Enemy" && !invincible)
		{
			health  --;
			Destroy (col.gameObject);

		}

		else if (col.tag == "Enemy" && invincible) 
		{
			score500.particleSystem.Emit(1);
			enemyDeath.gameObject.particleSystem.Emit(10);
			Destroy (col.gameObject);
			HighScore.score += 500;
		}
		if (health < maxHealth) 
			{
				health += regenration * Time.deltaTime;
			}
		if (health > maxHealth) 
			{
				health = maxHealth;
			}
		if (col.tag == "Collectible1") 
		{
			score100.particleSystem.Emit(1);
			bitsswipe.particleSystem.Emit(1);
			HighScore.score += 100;
			Destroy(col.gameObject);
		}
		if (col.tag == "Powerup1") 
			{
			Destroy(col.gameObject);
			invincible = true;
			timer = 5;
			animation.Play ("Superbyte");
			megabytetaillongmid.particleSystem.Emit(15);
			megabytetailmid.particleSystem.Emit(15);
			megabytetailmidright.particleSystem.Emit(15);
			megabytetailleft.particleSystem.Emit(15);
			megabytetaillright.particleSystem.Emit(15);
			}
		if (col.tag == "EnemyCablebreak")
			{
				health = -2;
				Destroy (col.gameObject);
			}
	}
}
