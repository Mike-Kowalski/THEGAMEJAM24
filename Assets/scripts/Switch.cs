using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{


	// Start is called before the first frame update
	private bool isAppearing = false; //switch on/off the image (if true is showing, if false is hidden)
	[SerializeField]
	public Texture2D[] Images;
	public Texture2D scaryPicture; //Texture of the image to show

	public float imageStayTime = 5f; //Time the image should stay on screen

	private float time; //Time passing in seconds
	public float timeLimit = 1f; //The time limit the picture have to appear

	// Start is called before the first frame update
	void Start()
	{


		StartCoroutine("FaceAppear");
		
	}

	void Update()
	{


		StartCoroutine("FaceAppear");
	
	}



	IEnumerator FaceAppear()
	{
		time += Time.deltaTime * 1;

		while (time > timeLimit)
		{
			isAppearing = true;
			yield return new WaitForSeconds(imageStayTime);
			isAppearing = false;
			time = 0;

		}
		yield return null;
	}

	void OnGUI()
	{
		if (isAppearing)
		{



			int Picture = Random.Range(0, Images.Length);
			scaryPicture = Images[Picture];


			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), scaryPicture);
		}
	}




	/*
    public Menu menu;
    public List<Image> imagesToSwap; // contains all the sprites to loop through
  
    IEnumerator SwapSprites()
    {
        int num =Random.Range(0, 20);
       
        int imageIndex = 0;
        while (true)
        {
            gameObject.GetComponent<SpriteRenderer>().image= imagesToSwap[imageIndex];
            // ^ replace the sprite
            imageIndex++;
            if (imageIndex == imagesToSwap.Count) imageIndex = 0;
            // ^ loop back to first sprite
            yield return new WaitForSeconds(num); // adjust this time as desired
        }
    }

    public void Update()
    {
        if(menu.enabled)
        {
            SwapSprites();
        }
        else
        {

        }
         
    }*/


}
