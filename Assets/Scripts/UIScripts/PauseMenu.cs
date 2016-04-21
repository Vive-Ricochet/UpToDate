using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {


	bool pause = false;
    private InputManager input;
    private int player_num;


    void Start()
    {
        input = GameObject.Find("InputManager").GetComponent<InputManager>();
        player_num = GetComponent<PlayerMovement>().player_num;
    }
	// Update is called once per frame
	void Update () {
        if (input.buttonDown(player_num, "Back"))
			pause = togglePause ();
	}

	void OnGUI(){
		if (pause) {
			GUILayout.Label ("Game is Paused");
			if (GUILayout.Button ("Click Start to unpause"))
				pause = togglePause ();
		}
	}

	bool togglePause(){
		if (Time.timeScale == 0f) {
			Time.timeScale = 1.0f;
			return(false);
		} else {
			Time.timeScale = 0f;
			return(true);
		}
	}
}
