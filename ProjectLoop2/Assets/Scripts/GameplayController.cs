using UnityEngine;
using System.Collections;

public class GameplayController : MonoBehaviour {

    int screenWith;

    void Awake()
    {

    }

    // Use this for initialization
    void Start () {
        screenWith = Screen.width;
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);

            if (myTouch.position.x > screenWith / 2)
            {
                Debug.Log("Right");
            }
            else
            {
                Debug.Log("Left");
            }
        }
        
	}
}
