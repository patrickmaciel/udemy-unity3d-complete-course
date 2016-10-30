using UnityEngine;
using System.Collections;

public class PersistentMusicPlayer : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip[] musics;

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnLevelWasLoaded(int level)
	{
		AudioClip music = musics[level];

		if (music)
		{
			audioSource.clip = music;
			audioSource.loop = true;
			audioSource.Play();
		}
	}

	public void SetVolume(float volume)
	{
		audioSource.volume = volume;
	}
}
