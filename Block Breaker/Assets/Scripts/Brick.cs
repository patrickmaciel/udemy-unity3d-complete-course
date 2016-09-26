using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public int maxHits;
    public int timesHit;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();

        timesHit = 0;
        maxHits = 1; // Random Range 1-3
        gameObject.GetComponent<SpriteRenderer>().color = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f));
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;

        if (timesHit >= maxHits)
        {
            SimulateWin();
            Destroy(gameObject);
        }

    }

    // TODO: Remove this method once we actually win!
    void SimulateWin()
    {
        Debug.Log("bricks length = " + GameObject.FindObjectsOfType<Brick>().Length);

        if (GameObject.FindObjectsOfType<Brick>().Length == 1)
        {
            // levelManager.LoadLevel("Win");
            levelManager.LoadNextLevel();
        }
    }
}
