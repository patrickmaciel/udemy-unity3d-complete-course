using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        Vector3 paddlePosition = gameObject.transform.position;
        gameObject.transform.position = new Vector3(
            // mousePosInBlocks,
            Mathf.Clamp(mousePosInBlocks, 0f, 15f),
            paddlePosition.y,
            paddlePosition.z
        );
	
	}
}
