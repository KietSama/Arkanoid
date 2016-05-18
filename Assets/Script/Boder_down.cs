using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Boder_down : MonoBehaviour {

    public Animator anim;
    public Text text;
    public Button button;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        DestroyObject(coll.gameObject);

        StartCoroutine(wait(0.5f));
        text.gameObject.SetActive(true);
        anim.SetTrigger("Text");

        StartCoroutine(wait(1f));
        button.gameObject.SetActive(true);
    }

    IEnumerator wait(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
