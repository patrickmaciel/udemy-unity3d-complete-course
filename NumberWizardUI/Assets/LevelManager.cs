using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
    }

    public void QuitRequest()
    {
        Debug.Log("See you soon!");
    }
}
