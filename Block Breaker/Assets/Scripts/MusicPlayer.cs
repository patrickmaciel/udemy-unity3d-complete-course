using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;

    void Awake()
    {
        Debug.Log("MusicPlayer Awake - " + GetInstanceID());

        if (instance != null)
        {
            Debug.Log("Instancia atual != null - " + instance.GetInstanceID());
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            Debug.Log("Instancia atual null - " + instance.GetInstanceID());
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

	// Use this for initialization
	void Start () {
        Debug.Log("MusicPlayer Start - " + GetInstanceID());
	}

	// Update is called once per frame
	void Update () {

	}
}
