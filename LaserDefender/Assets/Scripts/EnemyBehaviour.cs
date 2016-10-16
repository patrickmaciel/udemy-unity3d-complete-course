using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
	public float health = 150f;
	public AudioClip boom;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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

		if (health <= 0)
		{
			missile.Hit();
			AudioSource.PlayClipAtPoint(boom, gameObject.transform.position, 100f);
			Destroy(gameObject);
		}
	}
}
