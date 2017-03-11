using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeardScript : MonoBehaviour {

    public HeadChanger GameController;

    public void SelectBeard(int whichOne)
    {
        GameController.beardID = whichOne;
        GameController.ChangeHead();
    }
}
