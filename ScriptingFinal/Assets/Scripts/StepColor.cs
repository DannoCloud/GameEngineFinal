using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepColor : MonoBehaviour
{
    public PlayerController player;
    MeshRenderer rend;
    public Color colorStep;
    public BoxCollider2D col;

    public Color[] colorSet = new Color[] { Color.red, Color.blue, Color.green };


    // Start is called before the first frame update
    void Start()
    {
        ColorChange();
    }




    // Update is called once per frame
    void Update()
    {
        col.enabled = colorStep != player.colorIs ? false : true;
    }


    public void ColorChange()
    {
        rend = GetComponent<MeshRenderer>();

        colorStep = rend.material.color = colorSet[Random.Range(0, colorSet.Length)];
    }




    //private void OnCollisionEnter2D(Collision2D collision)     // Destorys the step the player touches ... Make another script and use this for another level?
    //{
    //    Destroy(gameObject, 3);
    //}

}
