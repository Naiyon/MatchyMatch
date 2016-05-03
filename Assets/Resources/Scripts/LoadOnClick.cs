using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Holoville.HOTween;

public class LoadOnClick : MonoBehaviour {

	public GameObject shopUI;



	public void OpenShop()
	{
		HOTween.To (shopUI.transform, 0.8f, "position", new Vector3 (30,44,0));
	}
	public void CloseShop()
	{
		HOTween.To (shopUI.transform.transform, 0.5f, "position", new Vector3 (24, 44, 0));
	}
	public void LoadScene(string level)
	{
		SceneManager.LoadScene (level);

	}
		
}
