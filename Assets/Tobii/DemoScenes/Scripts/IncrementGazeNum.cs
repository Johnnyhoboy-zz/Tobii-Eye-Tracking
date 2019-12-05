// Example script on Gaze Aware object:
// Make object turn color when looked at!

using Tobii.Gaming;
using UnityEngine;
using System;
using System.Collections;
 
[RequireComponent(typeof(GazeAware))]
public class IncrementGazeNum : MonoBehaviour
{
    private GazeAware _gazeAware;
	public int gazeNum;

    public Color32 altColor;
    private Renderer rend;
    private GameTime gametime;
 
    void Start()
    {
        _gazeAware = GetComponent<GazeAware>();
        rend = GetComponent<Renderer>();
        gazeNum = 0;
        gametime = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<GameTime>();
        //rend.material.color = altColor;
    }
 
    void Update()
    {
        if (_gazeAware.HasGazeFocus && gametime.started && !gametime.atZero)
        {
			//transform.Rotate(Vector3.forward);
            gazeNum++;

            if (gazeNum <= 205) 
            {
                //Green
                altColor = new Color32(Convert.ToByte(gazeNum), Convert.ToByte(255), Convert.ToByte(gazeNum), Convert.ToByte(255));
                //rend.material.color = altColor;
            }
            else if (gazeNum > 205 && gazeNum <= 405)
            {
                //Green-yellow, getting rid of super white

                int differenceR = 230 - ((gazeNum - 205)/2);
                int differenceB = 205 - (gazeNum - 205);
                altColor = new Color32(Convert.ToByte(differenceR), Convert.ToByte(255), Convert.ToByte(differenceB), Convert.ToByte(255));
                //rend.material.color = altColor;

            }
            else if (gazeNum > 405 && gazeNum <= 605)
            {
                //Yellow
                int differenceB = 205 - (gazeNum - 405);
                altColor = new Color32(Convert.ToByte(255), Convert.ToByte(255), Convert.ToByte(differenceB), Convert.ToByte(255));
                //rend.material.color = altColor;
            }
            else if (gazeNum > 605 && gazeNum <= 805)
            {
                //Orange
                int differenceG = 230 - ((gazeNum - 605)/2);
                int differenceB = 205 - (gazeNum - 605);
                altColor = new Color32(Convert.ToByte(255), Convert.ToByte(differenceG), Convert.ToByte(differenceB), Convert.ToByte(255));
                //rend.material.color = altColor;   
            }
            else if (gazeNum > 805 && gazeNum <= 1005)
            {
                //Red
                int difference = 205 - (gazeNum - 805);
                altColor = new Color32(Convert.ToByte(255), Convert.ToByte(difference), Convert.ToByte(difference), Convert.ToByte(255));
                //rend.material.color = altColor;
            } 


        } //HasGazeFocus

        //Change color when timer hits zero
        if(gametime.atZero){
            rend.material.color = altColor;
        }

    } //update()

}