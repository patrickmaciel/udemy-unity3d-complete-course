using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
	const string MASTER_VOLUME_KEY = "master_volume";
	const string LEVEL_KEY = "level";
	const string DIFFICULT_KEY = "difficult";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void SetMasterVolume(float volume)
	{
		if (volume > 0f)
		{
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		}
		else
		{
			print("Volume <= 0f");
		}
	}

	public static float GetMasterVolume()
	{
		if (PlayerPrefs.HasKey(MASTER_VOLUME_KEY))
		{
			return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
		}
		else
		{
			return 0f;
		}
	}

	public static void SetLevel(float level)
	{
		if (level > 0f)
		{
			PlayerPrefs.SetFloat(LEVEL_KEY, level);
		}
		else
		{
			print("level <= 0f");
		}
	}

	public static float GetLevel()
	{
		if (PlayerPrefs.HasKey(LEVEL_KEY))
		{
			return PlayerPrefs.GetFloat(LEVEL_KEY);
		}
		else
		{
			return 0f;
		}
	}

	public static void SetDifficult(float difficult)
	{
		if (difficult > 0f)
		{
			PlayerPrefs.SetFloat(DIFFICULT_KEY, difficult);
		}
		else
		{
			print("difficult <= 0f");
		}
	}

	public static float GetDifficult()
	{
		if (PlayerPrefs.HasKey(DIFFICULT_KEY))
		{
			return PlayerPrefs.GetFloat(DIFFICULT_KEY);
		}
		else
		{
			return 0f;
		}
	}
}
