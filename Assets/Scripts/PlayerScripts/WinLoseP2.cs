using UnityEngine;
using System.Collections;

public class WinLoseP2 : MonoBehaviour {
    Animator animator;
    int p2Score;
    bool results;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        p2Score = ScoreManager.scoreP2;
        results = true;
    }

    // Update is called once per frame
    void Update()
    {
        print(p2Score);
        print(results);
        animator.SetBool("Results", results);
        if (ScoreManager.scoreP2 == 5)
        {
            animator.SetInteger("p2Score", p2Score);
        }
        if (ScoreManager.scoreP2 < 5)
        {
            animator.SetInteger("p2Score", p2Score);
        }
    }
}
