using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public float speed = 30;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        
    }

    float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketWith)
    {
        // ascii art:
        //
        // 1 -0.5 0 0.5 1 <- x value
        // ============== <- raket
        //
        return (ballPos.x - racketPos.x) / racketWith;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            // Calculate hit factor
            //float x = HitFactor(this.transform.position, col.transform.position, col.collider.bounds.size.x);
            float x = HitFactor(transform.position, coll.transform.position, ((BoxCollider2D)coll.collider).size.x);

            // Calculate direction, set length to 1
            Vector2 dir = new Vector2(x, 1).normalized;

            // Set Veclocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

}
