using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


public class TimeButton : MonoBehaviour {

	public bool triggered = false;
	private GameTime gametime;
	
	private void Start(){
		gametime = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<GameTime>();
	}

	public void StartTimer()
    {
        triggered = !triggered;
        gametime.started = !gametime.started;

    }


}
