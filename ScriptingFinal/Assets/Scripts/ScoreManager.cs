using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int Level = 0;
    public static string Control;
    public static string Xcontrol;



    public Text LevelText;
    public Text ControlText;
    public Text XboxControl;


    Vector2 levelLoc;
    private bool isDisplayed = true;

    private static void SetupNewGame()
    {

        Control = "\nMove Left/Right = Arrow keys \nJump = Up Arrow Key \n\nA = Red \nW = Green \nD = Blue \nH = hide/show \n";

        Xcontrol = "\nMove Left/Right =  Left Analog Stick  \nJump = RB (Right Bumpber) \n\nX Button = Red \nY Button = Green \nB Button = Blue\nSelect = hide/show";

    }

    // Use this for initialization
    void Start()
    {
        ScoreManager.SetupNewGame();
        LevelText.text = "Score: " + ScoreManager.Level.ToString();
        ControlText.text = "\tKeyboard Controls: " + ScoreManager.Control.ToString();
        XboxControl.text = "\tXbox Controls: " + ScoreManager.Xcontrol.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        LevelText.text = "Score: " + ScoreManager.Level.ToString();

        if ( Input.GetButtonDown("Hide"))
        {
            isDisplayed = !isDisplayed;

            if (isDisplayed == false)
            {
                ControlText.text = "";
                XboxControl.text = "";
            }
            else
            {
                ControlText.text = "\tKeyboard Controls: " + ScoreManager.Control.ToString();
                XboxControl.text = "\tXbox Controls: " + ScoreManager.Xcontrol.ToString();
            }
        }





    }
}
