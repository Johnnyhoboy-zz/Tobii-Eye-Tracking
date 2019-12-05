// Example script on Gaze Aware object:
// Make object turn color when looked at, dynamically!

using Tobii.Gaming;
using UnityEngine;
using System;
using System.Collections;
using System.Threading;
 
[RequireComponent(typeof(GazeAware))]
public class IncrementGazeNumDynamic : MonoBehaviour
{
    private GazeAware _gazeAware;
	public int gazeNum;
    public double gazeNumFloat;

    public Color32 altColor;
    public Renderer rend;
    private GameTime gametime;
 
    void Start()
    {
        _gazeAware = GetComponent<GazeAware>();
        rend = GetComponent<Renderer>();
        gazeNum = 0;
        gazeNumFloat = 0;
        gametime = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<GameTime>();
        //rend.material.color = altColor;
    }
 
    void Update()
    {
        if (_gazeAware.HasGazeFocus && gametime.started && !gametime.atZero)
        {
			//transform.Rotate(Vector3.forward);
            gazeNum++;
            gazeNumFloat++;

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
            else 
            {
                altColor = rend.material.color;
            }


        } //HasGazeFocus
        else if (!_gazeAware.HasGazeFocus && gametime.started && !gametime.atZero && gazeNum > 0)
        {
            //if ((int)gametime.timeLeft % 2 == 1)
            gazeNumFloat = gazeNumFloat - 0.25d;
            gazeNum = (int)(Math.Round(gazeNumFloat));

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
        }


        rend.material.color = altColor;

    } //update()

}