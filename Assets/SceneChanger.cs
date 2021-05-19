using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void ChangeScenetoMenu()
	{
		SceneManager.LoadScene("Menu");
	}
	public void ChangeScenetoPlayGame()
	{
		SceneManager.LoadScene("SampleScene");
	}
	public void ChangeScenetoHelpScene()
	{
		SceneManager.LoadScene("HelpScene");
	}
	public void ChangeScenetoQuitScene()
	{
		SceneManager.LoadScene("QuitScene");
	}
	public void Exit()
	{
		Application.Quit();
	}
}
