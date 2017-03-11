using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScript : MonoBehaviour {

    public void RandomizeEverything(){
        HeadChanger changerScript = this.GetComponent<HeadChanger>();
        changerScript.hairID = (int)Random.Range(1.0f, 4.99f);
        changerScript.beardID = (int)Random.Range(1.0f, 5.99f);
        changerScript.glassesID = (int)Random.Range(1.0f, 5.99f);
        changerScript.ChangeHead();
    }

}