using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {
	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;
	private PersistentMusicPlayer musicPlayer;

	// Use this for initialization
	void Start () {
		musicPlayer = FindObjectOfType<PersistentMusicPlayer>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume(); 
		difficultySlider.value = PlayerPrefsManager.GetDifficult(); 
	}
	
	// Update is called once per frame
	void Update () {
		musicPlayer.SetVolume(volumeSlider.value);
	}

	public void SaveAndExit()
	{
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		PlayerPrefsManager.SetDifficult(difficultySlider.value);
		levelManager.LoadLevel("01a Start");
	}

	public void SetDefaults()
	{
		volumeSlider.value = 0.5f; 
		difficultySlider.value = 1f;		
	}
}
