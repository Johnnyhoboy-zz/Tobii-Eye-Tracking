using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


public class ResetButtonDynamic : MonoBehaviour {

	public bool triggered = false;
	private GameTime gametime;
	private IncrementGazeNumDynamic cube1;
	private IncrementGazeNumDynamic cube2;
	private IncrementGazeNumDynamic cube3;
	
	private void Start(){
		gametime = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<GameTime>();
		cube1 = GameObject.FindGameObjectsWithTag("Cube1")[0].GetComponent<IncrementGazeNumDynamic>();
		cube2 = GameObject.FindGameObjectsWithTag("Cube2")[0].GetComponent<IncrementGazeNumDynamic>();
		cube3 = GameObject.FindGameObjectsWithTag("Cube3")[0].GetComponent<IncrementGazeNumDynamic>();
	}

	public void ResetTimer()
    {
        triggered = false;
        gametime.started = false;

		if(gametime.atZero){
			gametime.atZero = false;
		}

		gametime.timeLeft = 60.0f;
		gametime.startText.text = (gametime.timeLeft).ToString("0");

		cube1.gazeNum = 0;
		cube2.gazeNum = 0;
		cube3.gazeNum = 0;

		cube1.gazeNumFloat = 0;
		cube2.gazeNumFloat = 0;
		cube3.gazeNumFloat = 0;

    }


}
