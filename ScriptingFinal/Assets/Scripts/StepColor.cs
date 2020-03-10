using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepColor : MonoBehaviour
{
    public PlayerController player;
    MeshRenderer rend;
    public  Color colorStep;
    public  BoxCollider2D col;

    public Color[] colorSet = new Color[] { Color.red, Color.blue, Color.green };


    // Start is called before the first frame update
    void Start()
    {
        ColorChange();
    }




    // Update is called once per frame
    void Update()
    {

        col.enabled = colorStep == player.colorIs;

    }


    public void ColorChange()
    {
        rend = GetComponent<MeshRenderer>();

        colorStep = rend.material.color = colorSet[Random.Range(0, colorSet.Length)];
    }



}
