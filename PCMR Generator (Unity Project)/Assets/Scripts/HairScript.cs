using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairScript : MonoBehaviour {

    public HeadChanger GameController;

	public void SelectHair(int whichOne){
        GameController.hairID = whichOne;
        GameController.ChangeHead();
	}
}
