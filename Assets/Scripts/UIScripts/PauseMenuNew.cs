using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenuNew : MonoBehaviour {


    public bool isPaused;
    public GameObject PauseMenu;
    private InputManager input;
 //   private int player_num;

    void Start(){
        input = GameObject.Find("InputManager").GetComponent<InputManager>();
  //      player_num = GetComponent<PlayerMovement>().player_num;
    }

    // Update is called once per frame
    void Update(){
        if (isPaused){
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else{
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        if  (input.buttonDown(1, "Back")){
            isPaused = !isPaused;
        }
        if (input.buttonDown(2, "Back")) {
            isPaused = !isPaused;
        }
        if (input.buttonDown(3, "Back")) {
            isPaused = !isPaused;
        }
        if (input.buttonDown(4, "Back")) {
            isPaused = !isPaused;
        }
    }

    public void Resume(){
        isPaused = false;
    }


    public void RestartMatch(){
        ScoreManager.scoreP1 = 0;
        ScoreManager.scoreP2 = 0;
        SceneManager.LoadScene(1);
    }

    public void Quit(){
        ScoreManager.scoreP1 = 0;
        ScoreManager.scoreP2 = 0;
        SceneManager.LoadScene(0);
    }
}
