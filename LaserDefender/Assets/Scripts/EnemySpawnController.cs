﻿using UnityEngine;
using System.Collections;

public class EnemySpawnController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float width = 10f;
    public float height = 8f;
	public float spawnDelay = 1f;

    private float speed = 5f;
    private float xmin, xmax;
    private bool movingRight;

	// Use this for initialization
	void Start ()
	{
		float distance = transform.position.z - Camera.main.transform.position.z;
	    Vector3 leftBoundry = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
	    Vector3 rightBoundry = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
	    xmin = leftBoundry.x;
	    xmax = rightBoundry.x;

	    SpawnEnemyOneByOne();
	}

	void SpawnEnemies()
	{
	    foreach (Transform child in transform)
	    {
            GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = child;
        }
	}

	void SpawnEnemyOneByOne()
	{
		var freePosition = NextFreePosition();
		if (freePosition)
		{
			GameObject enemy = Instantiate(enemyPrefab, freePosition.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = freePosition;
		}

		if (NextFreePosition())
		{
			Invoke("SpawnEnemyOneByOne", spawnDelay);
		}
	}
	
	// Update is called once per frame
	void Update () {
	    if (movingRight)
	    {
	        transform.position += Vector3.right * speed * Time.deltaTime;
	    }
	    else
	    {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

	    float rightEdgeOfFormation = transform.position.x + (0.5f * width);
	    float leftEdgeOfFormation = transform.position.x - (0.5f * width);
	    if (leftEdgeOfFormation < xmin) {
			movingRight = true;
		} else if (rightEdgeOfFormation > xmax) {
            movingRight = false;
        }

		if (AreAllEnemiesDead())
		{
			SpawnEnemyOneByOne();
		}
	}

	bool AreAllEnemiesDead()
	{
		foreach (Transform childCount in transform)
		{
			if (childCount.childCount > 0)
			{
				return false;
			}
		}

		return true;
	}

	Transform NextFreePosition()
	{
		foreach (Transform childPosition in transform)
		{
			if (childPosition.childCount == 0)
			{
				return childPosition;
			}
		}

		return null;
	}	

    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
    }
}
