using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


public class ResetButton : MonoBehaviour {

	public bool triggered = false;
	private GameTime gametime;
	private IncrementGazeNum cube1;
	private IncrementGazeNum cube2;
	private IncrementGazeNum cube3;
	
	private void Start(){
		gametime = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<GameTime>();
		cube1 = GameObject.FindGameObjectsWithTag("Cube1")[0].GetComponent<IncrementGazeNum>();
		cube2 = GameObject.FindGameObjectsWithTag("Cube2")[0].GetComponent<IncrementGazeNum>();
		cube3 = GameObject.FindGameObjectsWithTag("Cube3")[0].GetComponent<IncrementGazeNum>();
	}

	public void ResetTimer()
    {
        triggered = false;
        gametime.started = false;

		if(gametime.atZero){
			gametime.atZero = false;
		}

		gametime.timeLeft = 30.0f;
		gametime.startText.text = (gametime.timeLeft).ToString("0");

		cube1.gazeNum = 0;
		cube2.gazeNum = 0;
		cube3.gazeNum = 0;


    }


}
