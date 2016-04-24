using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour {

    Text textP1;
    Text textP2;
	Text BoS;
	Text BoF;
	Text Hoard;

    void Start() {
        textP1 = GameObject.Find("p1Score").GetComponent<Text>();
        textP2 = GameObject.Find("p2Score").GetComponent<Text>();
		BoS = GameObject.Find ("BoS").GetComponent<Text> ();
		BoF = GameObject.Find ("BoF").GetComponent<Text> ();
		Hoard = GameObject.Find ("Hoard").GetComponent<Text> ();
        textP1.text = "Score " + ScoreManager.scoreP1;
        textP2.text = "Score " + ScoreManager.scoreP2;

		if (Parry.parryp1 > Parry.parryp2) {
			BoS.text = "Balls of Steel " + Parry.parryp1;
		}
		if (Parry.parryp2 > Parry.parryp2) {
			BoS.text = "Balls of Steel " + Parry.parryp2;
		}

		if (ProjectileMaker.furyP1 > ProjectileMaker.furyP2) {
			BoF.text = "Balls of Fury " + ProjectileMaker.furyP1;
		}
		if (ProjectileMaker.furyP2 > ProjectileMaker.furyP1) {
			BoF.text = "Balls of Fury " + ProjectileMaker.furyP2;
		}
    }


}
