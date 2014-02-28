using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEditor.Callbacks;

public static class ScenePostprocessor {

	[PostProcessScene]
	public static void OnPostprocessScene()
	{
		if (GameObject.FindObjectOfType<MainCaller>() == null)
		{
			GameObject go = new GameObject("MainCaller");

			go.AddComponent<MainCaller>();
		}
	}
}
