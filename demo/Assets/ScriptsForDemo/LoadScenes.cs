using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScenes : BaseLoader {

	public string sceneAssetBundle = "scene.unity3d";
	public string sceneName = "testScene";

	public bool loadLevelAdditive = true;

	// Use this for initialization
	IEnumerator Start () {
		yield return StartCoroutine(Initialize());
	}

	void OnGUI()
	{
		if(GUI.Button(new Rect(100,50,100,50),"Load Scene"))
		{
			// Load level.
			StartCoroutine(LoadLevel ("scene.unity3d", "testScene", loadLevelAdditive) );
			// Unload assetBundles.
			// AssetBundleManager.UnloadAssetBundle("scene.unity3d");
		}

		if(GUI.Button(new Rect(300,50,100,50),"Load Main"))
		{
			SceneManager.LoadScene("SceneLoader");
			// Load level.
			// StartCoroutine(LoadLevel ("scene.unity3d", "testScene", loadLevelAdditive) );
			// Unload assetBundles.
			// AssetBundleManager.UnloadAssetBundle("scene.unity3d");
		}

		if(GUI.Button(new Rect(100,180,100,50),"UnLoad Scene"))
		{
			// Unload assetBundles.
			AssetBundleManager.UnloadAssetBundle("scene.unity3d");
		}
	}
}
