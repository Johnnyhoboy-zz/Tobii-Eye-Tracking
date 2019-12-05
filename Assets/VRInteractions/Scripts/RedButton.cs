using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


public class RedButton : MonoBehaviour {

	public bool triggered = false;
    private bool inTrigger = false;
	private GameTime gametime;
	private Animation animation;
	
	private void Start(){
		gametime = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<GameTime>();
		animation = GetComponent<Animation>();
	}

	private void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                triggered = !triggered;
				animation.Play("ButtonDownUp");
				gametime.started = !gametime.started;
                //AudioSource sparkle = GetComponent<AudioSource>();
                //sparkle.Play();
            }
        }
    }

	void OnTriggerEnter(Collider _collider)
	{	
		inTrigger = true;
	}

	private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }


}
