using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadChanger : MonoBehaviour{
    public Sprite head11;
    public Sprite head12;
    public Sprite head13;
    public Sprite head14;
    public Sprite head21;
    public Sprite head22;
    public Sprite head23;
    public Sprite head24;
    public Sprite head31;
    public Sprite head32;
    public Sprite head33;
    public Sprite head34;
    public Sprite head41;
    public Sprite head42;
    public Sprite head43;
    public Sprite head44;
    public Sprite head51;
    public Sprite head52;
    public Sprite head53;
    public Sprite head54;
    public Sprite[] glassesSprite;
    private Sprite[,] headSprite;
    public GameObject head;
    public GameObject glasses;
    public int hairID;
    public int beardID;
    public int glassesID;

    void Start () {
        headSprite = new Sprite[7,7];
        hairID = 4;
        beardID = 1;
        glassesID = 1;
        headSprite[1,1] = head11;
        headSprite[1,2] = head12;
        headSprite[1,3] = head13;
        headSprite[1,4] = head14;
        headSprite[2,1] = head21;
        headSprite[2,2] = head22;
        headSprite[2,3] = head23;
        headSprite[2,4] = head24;
        headSprite[3,1] = head31;
        headSprite[3,2] = head32;
        headSprite[3,3] = head33;
        headSprite[3,4] = head34;
        headSprite[4,1] = head41;
        headSprite[4,2] = head42;
        headSprite[4,3] = head43;
        headSprite[4,4] = head44;
        headSprite[5,1] = head51;
        headSprite[5,2] = head52;
        headSprite[5,3] = head53;
        headSprite[5,4] = head54;
        ChangeHead();
    }
	
    public void ChangeHead()
    {
        head.GetComponent<Image>().sprite = headSprite[beardID,hairID];
        glasses.GetComponent<Image>().sprite = glassesSprite[glassesID-1];
    }
}
