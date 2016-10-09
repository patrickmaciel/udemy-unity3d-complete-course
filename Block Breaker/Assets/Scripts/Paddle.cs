using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
    public bool autoPlay = false;
    private Ball ball;

    // Use this for initialization
    void Start ()
    {
        ball = Object.FindObjectOfType<Ball>();
    }
    
    // Update is called once per frame
    void Update () {
        if (!autoPlay)
        {
            MoveWithMouse();
        }
        else
        {
            AutoPlay();   
        }     
    }

    void AutoPlay()
    {
        float ballPosInBlocks = ball.transform.position.x;
        Vector3 paddlePosition = gameObject.transform.position;
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(ballPosInBlocks, 0f, 15f),
            paddlePosition.y,
            paddlePosition.z
        );
    }

    void MoveWithMouse()
    {
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
