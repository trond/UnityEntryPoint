using UnityEngine;
using System.Collections;

public static class Program 
{
	public static void Main()
	{
		new GameObject("ScreenLogger", typeof(ScreenLogger));
		new GameObject("SceneSwitcher", typeof(SceneSwitcher));

		SetupCamera();

		Debug.Log("Main complete");
	}

	public static void OnLevelWasLoaded(int level)
	{
		Debug.Log("Level loaded: " + level);

		SetupCamera();
	}

	static void SetupCamera()
	{
		GameObject go = new GameObject("Camera");

		Camera cam = go.AddComponent<Camera>();
		cam.backgroundColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
	}
}
