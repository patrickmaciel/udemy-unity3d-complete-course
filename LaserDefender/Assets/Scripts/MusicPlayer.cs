using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;
    public AudioClip startClip;
    public AudioClip gameClip;
    public AudioClip endClip;
    private static AudioSource music;

    void Awake()
    {
        Debug.Log("MusicPlayer Awake - " + GetInstanceID());
    }

	// Use this for initialization
	void Start () {
        Debug.Log("MusicPlayer Start - " + GetInstanceID());

        if (instance != null && instance != this)
        {
            Debug.Log("Instancia atual != null - " + instance.GetInstanceID());
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            Debug.Log("Instancia atual null - " + instance.GetInstanceID());
            GameObject.DontDestroyOnLoad(gameObject);
            music = GetComponent<AudioSource>();
            OnLevelWasLoaded(0);
        }        
	}

	// Update is called once per frame
	void Update () {

	}

    void OnLevelWasLoaded(int level)
    {
        if (music != null && music.clip != null)
        {
            music.Stop();
        }

        if (level == 0)
        {
            music.clip = startClip;
        }
        else if (level == 1)
        {
            music.clip = gameClip;
        }
        else if (level == 2)
        {
            music.clip = endClip;
        }

        music.loop = true;
        music.Play();
    }
}
