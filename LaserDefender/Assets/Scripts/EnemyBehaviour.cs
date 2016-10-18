using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
	public float health = 150f;
	public AudioClip boom;
	public AudioClip hitSound;
	public GameObject projectilePrefab;
	public float projectileSpeed = 5f;
	public float firePerSeconds = 0.5f;
	public float possibility;
	public int scoreValue = 150;
	public ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
		scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
		possibility = Time.deltaTime * firePerSeconds;
		if (Random.value < possibility)
		{
			Fire();
		}
	}

	void Fire()
	{
		GameObject projectile = Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y - 1f, 0), Quaternion.identity) as GameObject;
		projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -projectileSpeed);
	}

	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		Projectile missile = other.GetComponent<Projectile>();
		health -= missile.GetDamage();
		AudioSource.PlayClipAtPoint(hitSound, transform.position, 1000f);
		missile.Hit();
		if (health <= 0)
		{
			AudioSource.PlayClipAtPoint(boom, gameObject.transform.position, 100f);
			Destroy(gameObject);
			scoreKeeper.Score(scoreValue);
		}
	}
}
