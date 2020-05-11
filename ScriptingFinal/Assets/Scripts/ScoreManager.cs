using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
    public PlayerController player; 
    public static int Level = 0;
    public static string Control;
    public static string Xcontrol;

    public static string ContHard;
    public static string XboxHard;

    public bool InHardMode;



    public Text LevelText;
    public Text ControlText;
    public Text XboxControl;

    //public Text ContHardText;
    //public Text XboxHardText;


    Vector2 levelLoc;
    private bool isDisplayed = true;

    private static void SetupNewGame()
    {

        Control = "\n\nMove Left/Right = Arrow keys \nJump = Up Arrow Key \nA = Red \nW = Green \nD = Blue \nA&W = Yellow \nA&D = Magenta \nW & D = Cyan \nH = hide / show ";

        Xcontrol = "\n\nMove Left/Right =  Left Analog Stick  \nJump = RB (Right Bumpber) \nX Button = Red \nY Button = Green \nB Button = Blue\nX&Y = Yellow \nX&B = Magenta \nY&B = Cyan \nSelect = hide/show";


    }

    // Use this for initialization
    void Start()
    {
        ScoreManager.SetupNewGame();
        LevelText.text = "Score: " + Level.ToString();
        ControlText.text = "\tKeyboard Controls: " + Control.ToString();
        XboxControl.text = "\tXbox Controls: " + Xcontrol.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        LevelText.text = "Score: " + Level.ToString();

     
        if ( Input.GetButtonDown("Hide"))
        {
            isDisplayed = !isDisplayed;



            if (isDisplayed == false)
            {
                ControlText.text = "";
                XboxControl.text = "";
            }

            
            
            if(isDisplayed == true)
            {

                    ControlText.text = "\tKeyboard Controls: " + Control.ToString();
                    XboxControl.text = "Xbox Controls: " + Xcontrol.ToString();

            }


        }





    }
}
