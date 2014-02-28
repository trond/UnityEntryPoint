using UnityEngine;
using System.Collections;

public class MainCaller : MonoBehaviour {

	//Make sure there's only one instance of this running.
	static MainCaller instance;

	protected void Awake()
	{
		if (instance != null)
		{
			//NOTE: In a build, this will be called for every scene change.
			//      In the editor, the scene postprocessor will only run for
			//      for the currently loaded level (and reloading it will
			//      lose the preprocessing, it seems), so it will never get
			//      here.
			Debug.Log("MainCaller already exists"); 

			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);

		instance = this;
	}

	protected void Start()
	{
		Program.Main();
	}

	protected void OnLevelWasLoaded(int level)
	{
		//Not checking for this instance, will make this get called in a build for
		//every MainCaller that is destroyed in Awake.
		if (instance == this)
		{
			Program.OnLevelWasLoaded(level);
		}
	}

	protected void OnDestroy()
	{
		if (instance == this)
		{
			instance = null;
		}
	}
}
