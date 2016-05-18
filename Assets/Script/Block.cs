using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

    GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
        player.GetComponent<Player>().UpdateScore(1);
    }
}
