using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int playerScore = 0;
    public float speed = 30;
    public Text text;
    public Text textWin;
    public Button button;
    public GameObject ball;
    int ConditionWin;

    void Start()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Block");
        ConditionWin = gos.Length;
    }

    void Update()
    {

    }

    public void UpdateScore(int score)
    {
        this.playerScore += score;
        text.text = "Score: " + playerScore;

        if(playerScore == ConditionWin)
        {
            ball.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

            StartCoroutine(wait(1f));
            textWin.gameObject.SetActive(true);

            button.gameObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");

        this.GetComponent<Rigidbody2D>().velocity =  new Vector2(Horizontal, 0) * speed ;
    }

    IEnumerator wait(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
