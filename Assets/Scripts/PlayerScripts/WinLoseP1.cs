using UnityEngine;
using System.Collections;

public class WinLoseP1 : MonoBehaviour {

    Animator animator;
    int score;
    bool results;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        score = ScoreManager.scoreP1;
        results = true;
    }
	
	// Update is called once per frame
	void Update () {
        print(score);
        print(results);
        animator.SetBool("Results", results);
        if (ScoreManager.scoreP1 == 5)
        {
            animator.SetInteger("Score", score);
        }
        if (ScoreManager.scoreP1 < 5)
        {
            animator.SetInteger("Score", score);
        }
    }
}
