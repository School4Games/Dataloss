using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public AudioClip bithit;
	public AudioClip virushit;
	public AudioClip firewallhit;
	public AudioClip viruskill;
	public AudioClip death;
	public AudioClip multiup;

	public bool invincible;
	public float health = 2;
	public float maxHealth =2f;
	public float hptimer;
	public float timer;
	public float dmg;
	public float dmgc;

	public GameObject EndScreen;
	public GameObject[] fbits;
	private GameObject score100;
	private GameObject score500;
	private GameObject bitsswipe;
	private GameObject megabytetaillongmid;
	private GameObject megabytetailmid;
	private GameObject megabytetailmidright;
	private GameObject megabytetailleft;
	private GameObject megabytetailright;
	
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
		megabytetailright = GameObject.Find ("megabytetailright");

	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = 0;
			invincible = false;
		}
			hptimer -= Time.deltaTime;
			if (hptimer <= 0) {
				hptimer = 0;
				health =2;
			}
		if (health <= 0) 
		{
			Destroy(this.gameObject);
			Time.timeScale = 0;
			EndScreen.SetActive (true);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Enemy" && !invincible)
		{
			audio.PlayOneShot(virushit, 10.0f);
			health -= dmg;
			Destroy (col.gameObject);
			HighScore.multi =1;
			hptimer =4;
			HighScore.bitcount =0;
			foreach (GameObject bit in fbits)
			{
				bit.SetActive (false);
			}
		}

		else if (col.tag == "Enemy" && invincible) 
		{
			audio.PlayOneShot(viruskill, 10.0f);
			score500.particleSystem.Emit(1);
			enemyDeath.gameObject.particleSystem.Emit(10);
			Destroy (col.gameObject);
			HighScore.score += 500;
		}
		if (health > maxHealth) {
			health = maxHealth;
		}
		if (col.tag == "Collectible1") 
		{
			score100.particleSystem.Emit(1);
			bitsswipe.particleSystem.Emit(1);
			HighScore.score += 100;
			Destroy(col.gameObject);
			HighScore.bitcount ++;
			if (HighScore.bitcount != 8) 
			{
				audio.PlayOneShot(bithit, 1.0f);
				fbits[HighScore.bitcount -1].SetActive (true);
			}
			else 
			{
				audio.PlayOneShot(multiup, 5.0f);
				foreach (GameObject bit in fbits)
				{
					bit.SetActive (false);
				}
			}
		}
		if (col.tag == "Powerup1") 
			{
			audio.PlayOneShot(firewallhit, 10.0f);
			Destroy(col.gameObject);
			invincible = true;
			timer = 5;
			animation.Play ("Superbyte");
			megabytetaillongmid.particleSystem.Emit(15);
			megabytetailmid.particleSystem.Emit(15);
			megabytetailmidright.particleSystem.Emit(15);
			megabytetailleft.particleSystem.Emit(15);
			megabytetailright.particleSystem.Emit(15);
			}
		if (col.tag == "EnemyCablebreak")
			{
				audio.PlayOneShot(death, 5.0f);
			    hptimer = 0.1f;
				health -= dmgc;
				Destroy (col.gameObject);
			}
		}
}
