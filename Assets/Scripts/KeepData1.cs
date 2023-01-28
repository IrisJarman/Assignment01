using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData1 : MonoBehaviour
{
    // STATIC so they are preserved between classes
    public static string PlayerName;
    public static float PlayingSpeed;

    public InputField PlayerNameInput;
    public Slider speedSlider;
    //lives are hard coded

    public Text showPlayerName; // don't forget to drop the hierarchy objects in the script slots in the inspector
    public Text playingSpeedText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }
    public void UpdateName() //executed in each letter change
    {
        PlayerName = PlayerNameInput.text; // assign new input text to string
        Debug.Log(PlayerName); //prints updated name to log on each letter change
        showPlayerName.text = PlayerName; // show string in the textbox just to see that it works in the Intro scene. 
    }
    public void ShowName() //method for the show name button on intro
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }
    public void SetSpeed() //method for the slider on intro screen
    {
        PlayingSpeed = speedSlider.value;
        playingSpeedText.text = PlayingSpeed.ToString();
    }
    public void ShowSpeed() // method for clicking on playing speed button on game screen 
    {
        playingSpeedText.text = PlayingSpeed.ToString();
        speedSlider.value = PlayingSpeed; // you use the speed value here

    }
    public void ChangeSpeed() //method for slider on game screen, so you see that you can still change the value after transfer between screens
    {
        PlayingSpeed = speedSlider.value; // change to the new value from game screen slider
        playingSpeedText.text = speedSlider.value.ToString(); //show updated value
    }

}
