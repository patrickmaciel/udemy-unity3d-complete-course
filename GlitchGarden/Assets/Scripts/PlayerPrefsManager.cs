using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
	const string MASTER_VOLUME_KEY = "master_volume";
	const string LEVEL_KEY = "level_unlocked_";
	const string DIFFICULT_KEY = "difficulty";

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

	public static void UnlockLevel(float level)
	{
		if (level > Application.levelCount - 1)
		{
			PlayerPrefs.SetFloat(LEVEL_KEY + level, 1); // 1 is unlocked
		}
		else
		{
			print("Unknown level");
		}
	}

	public static bool isUnlockedLevel(float level)
	{
		if (PlayerPrefs.HasKey(LEVEL_KEY) && (level > Application.levelCount - 1))
		{
			return true;
		}

		return false;
	}

	public static void SetDifficult(float difficult)
	{
		if (difficult >= 1f && difficult <= 3f)
		{
			PlayerPrefs.SetFloat(DIFFICULT_KEY, difficult);
		}
		else
		{
			print("Unknown difficult ");
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
