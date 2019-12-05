using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTime : MonoBehaviour
{

    public float timeLeft = 30.0f;
    public bool started = false;
    public bool atZero = false;
    public Text startText; // used for showing countdown

    void Start(){
        startText.text = (timeLeft).ToString("0");
    }
    void Update()
    {
        if(started){
            if(!atZero)
            {
                timeLeft -= Time.deltaTime;
                startText.text = (timeLeft).ToString("0");
            }

            if (timeLeft < 0)
            {
                //Do something useful or Load a new game scene depending on your use-case
                atZero = true;

                
            }
        }
    }
}