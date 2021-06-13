using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class FPS_Display : MonoBehaviour
{
	float deltaTime = 0.0f;

	//[SerializeField]
	//float timeStampRange = 2f;
	//float timeStampCount = 1;

	//[SerializeField]
	//string sceneName;

	//string textFileText = "";
	//float collectedFramerate = 0;
	//float collectedFramerateCount = 0;

	//float fps;

	//float coolDeltaTime = 0;

	void Update()
	{
		deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

/*		float avarageFrameRate = collectedFramerate / collectedFramerateCount;
		textFileText += sceneName + ", " + System.DateTime.Now + ", " + fps + "\n";

		using (StreamWriter writer = new StreamWriter(Application.dataPath + "/EvilDataTracker/" + sceneName + "_evilData.txt"))
		{
			writer.WriteLine(textFileText);
		}*/

		//coolDeltaTime += Time.unscaledDeltaTime;
		//Debug.Log(coolDeltaTime);

/*        if (coolDeltaTime >= timeStampRange)
		{
			//Debug.Log("CollectedFrameRate: " + collectedFramerate + "| CollectedFrameRateCount: " + collectedFramerateCount);
			float avarageFrameRate = collectedFramerate / collectedFramerateCount;
			textFileText += sceneName + ", " + timeStampCount * timeStampRange + ", " + avarageFrameRate + "\n";
			coolDeltaTime = 0;
			collectedFramerate = 0;
			collectedFramerateCount = 0;
			timeStampCount = timeStampCount + 1;

			using (StreamWriter writer = new StreamWriter(Application.dataPath + "/EvilDataTracker/" + sceneName + "_evilData.txt"))
			{
				writer.WriteLine(textFileText);
			}
			//Debug.Log("Gotem");
		}*/
	}

	void OnGUI()
	{
		int w = Screen.width, h = Screen.height;

		GUIStyle style = new GUIStyle();

		Rect rect = new Rect(0, 0, w, h * 2 / 100);
		style.alignment = TextAnchor.UpperLeft;
		style.fontSize = h * 5 / 100;
		style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);

		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
/*
		collectedFramerate = collectedFramerate + fps;
		
		collectedFramerateCount++;*/
		//Debug.Log(collectedFramerate / collectedFramerateCount);

		string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
		GUI.Label(rect, text, style);
	}
}
