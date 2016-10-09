using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{

    public AudioClip crack;
    public Sprite[] hitSprites = new Sprite[2];
    public static int breakableCount = 0;

    private bool isBreakable;
    private int maxHits;
    private int timesHit;
    private LevelManager levelManager;
    
	// Use this for initialization
	void Start ()
	{
	    isBreakable = this.tag == "Breakable";
        levelManager = GameObject.FindObjectOfType<LevelManager>();

        timesHit = 0;
        maxHits = Random.Range(1, 4); // Random Range 1-3
        gameObject.GetComponent<SpriteRenderer>().color = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f));

        breakableCount += isBreakable ? 1 : 0;
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(crack, transform.position, 100f);
        if (isBreakable)
        {
            HandleHits();
        }
    }

    void HandleHits()
    {
        // DEATHO (pegar audio do youtube)
        timesHit++;

        if (timesHit >= maxHits)
        {
            breakableCount--;
            // SimulateWin();
            levelManager.BricksDestroyed();
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    void LoadSprites()
    {
        if (hitSprites[timesHit - 1] != null)
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[timesHit - 1];
        }
        else
        {
            Debug.LogError("Sprite inexistente para o Brick.");
        }
    }

    // TODO: Remove this method once we actually win!
    void SimulateWin()
    {
        Debug.Log("bricks length = " + GameObject.FindObjectsOfType<Brick>().Length);

        // if (GameObject.FindObjectsOfType<Brick>().Length == 1)
        if (breakableCount <= 0)
        {
            // levelManager.LoadLevel("Win");
            levelManager.LoadNextLevel();
        }
    }
}
