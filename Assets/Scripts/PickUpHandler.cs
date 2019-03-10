using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHandler : MonoBehaviour {
    public UnityEngine.UI.RawImage memeDisplay;
    public Texture[] memes = { };

    public float count = 10;
    int currentMeme = 0;
    public float memeTime = 10;
    float ImageHold;
    Vector3 imageOnPos = new Vector3 (459, 214,0 );
    Vector3 imageOffPos = new Vector3(999,999,999);
    // Use this for initialization
    void Start () {
      //  imageOnPos = memeDisplay.transform.position;
        memeDisplay.transform.position = imageOffPos;
        ImageHold = memeTime;
    }
	
	// Update is called once per frame
	void Update () {

        if (count >= 0)
        {
            // Display Memes


            memeDisplay.transform.position = imageOnPos;
            //  print("imagePos: " + imageOnPos + ", " + memeDisplay.transform.position);
            memeDisplay.texture = memes[currentMeme];
            count = count - Time.deltaTime;
        }
        if (count < 0 && count > -2)
        {
            // Reset Meme display;
            ImageHold = memeTime;
            memeDisplay.transform.position = imageOffPos;
            print("Image off");
            count = -10;
           
           
        }

    }

   public void PickUpProcessor(int PickUpID) {
        ChangeImage(PickUpID);
    }

    void ChangeImage(int currentImage)
    {

        count = memeTime;
        
      
           
        
        
    }
}
