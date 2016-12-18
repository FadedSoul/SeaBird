using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pickup : MonoBehaviour {

    public Text pickUpTekst;

    private int pickedUp = 0;

    private int totalPickUps;

    public GameObject[] pickUps;

    public int pickedUpsGrabbed
    {
        get
        {
            return pickedUp;
        }
    }

    public int toPick
    {
        get
        {
            return totalPickUps;
        }
    }

    void Start() {
        pickUps = GameObject.FindGameObjectsWithTag("PickUp");

        totalPickUps = pickUps.Length;

        pickUpTekst.text = pickedUp + "/" + totalPickUps + " Helped";
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "PickUp")
        {
            pickedUp = pickedUp + 1;
            Destroy(coll.gameObject);
            TekstUpdate();
        }
    }

    void TekstUpdate() {
        pickUpTekst.text = pickedUp + "/" + totalPickUps + " Helped";
    }
}
