using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{

    [SerializeField]
    private GameObject win;

    private Pickup pickUps;

    private int pickedUp;
    private int toPickUp;


    void start()
    {
        pickUps = this.gameObject.GetComponent<Pickup>();
    }
    // Update is called once per frame
    void Update()
    {
        pickedUp = this.gameObject.GetComponent<Pickup>().pickedUpsGrabbed;
        toPickUp = this.gameObject.GetComponent<Pickup>().toPick;

        if (toPickUp == pickedUp)
        {
            StartCoroutine(Win());
        }
    }

    IEnumerator Win()
    {
        win.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(0);
    }
}
