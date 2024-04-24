using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{


	// Start is called before the first frame update
	public bool isAppearing = false; //switch on/off the image (if true is showing, if false is hidden)
	[SerializeField]
	public Texture2D[] Images;
	public Texture2D scaryPicture; //Texture of the image to show

	public float imageStayTime = 5f; //Time the image should stay on screen

	private float time; //Time passing in seconds
	public float timeLimit = 1f; //The time limit the picture have to appear

	// Start is called before the first frame update
	public void Start()
	{


		StartCoroutine("FaceAppear");
		
	}

	public void Update()
	{


		StartCoroutine("FaceAppear");
	
	}



	IEnumerator FaceAppear()
	{
		time += Time.deltaTime * 1;

		if(time > timeLimit)
		{
			isAppearing = true;
			yield return new WaitForSeconds(imageStayTime);
			isAppearing = false;
			time = 0;

		}
		yield return null;
		
	}

	public void OnGUI()
	{
		if (isAppearing)
		{



			int Picture = Random.Range(0, Images.Length);
			scaryPicture = Images[Picture];
			

			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), scaryPicture);
			
		}
	}






}
