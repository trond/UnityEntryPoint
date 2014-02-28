using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScreenLogger : MonoBehaviour {

	Queue<string> entries = new Queue<string>();
	Vector2 scroll = Vector2.zero;

	protected void Awake()
	{
		DontDestroyOnLoad(gameObject);

		Application.RegisterLogCallback(OnLog);
	}

	protected void OnDestroy()
	{
		Application.RegisterLogCallback(null);
	}

	void OnLog(string logString, string stackTrace, LogType type)
	{
		entries.Enqueue(System.DateTime.Now + " " + type + ": " + logString);

		if (entries.Count > 50)
		{
			entries.Dequeue();
		}

		scroll.y = float.MaxValue;
	}

	protected void OnGUI()
	{
		GUILayout.BeginArea(new Rect(Screen.width / 2, 20, Screen.width / 2, Screen.height - 40));

		scroll = GUILayout.BeginScrollView(scroll);

		foreach (string entry in entries)
		{
			GUILayout.Label(entry);
		}

		GUILayout.EndScrollView();

		GUILayout.EndArea();
	}
}
