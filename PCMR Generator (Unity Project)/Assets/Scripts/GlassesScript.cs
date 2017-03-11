using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesScript : MonoBehaviour {

    public HeadChanger GameController;

    public void SelectGlasses(int whichOne)
    {
        GameController.glassesID = whichOne;
        GameController.ChangeHead();
    }
}
