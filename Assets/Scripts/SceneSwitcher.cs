using UnityEngine;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {

	[SerializeField]
	string[] scenes = { "emptyscene0", "emptyscene1" };

	protected void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	protected void OnGUI()
	{
		for (int i = 0; i < scenes.Length; ++i)
		{
			if (GUILayout.Button(scenes[i], GUILayout.Width(200)))
			{
				Application.LoadLevel(scenes[i]);
			}
		}
	}
}
