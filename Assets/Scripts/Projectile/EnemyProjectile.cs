using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyProjectile : MonoBehaviour
{

    public float projectileSpeed = 4f;
    private Rigidbody2D myRB;

    public Vector3 direction;

    private SpriteRenderer bulletSprite;


    

    private PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        bulletSprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

         direction = player.transform.localPosition - transform.localPosition;

        if(direction.x > 0)
        {
            bulletSprite.flipX = true;
            myRB.AddForce(new Vector2(1, 0) * projectileSpeed, ForceMode2D.Impulse);

        }
        else if(direction.x< 0)
        {
            bulletSprite.flipX = false;
            myRB.AddForce(new Vector2(-1, 0) * projectileSpeed, ForceMode2D.Impulse);
          
        }
    }

    public void RemoveForce()
    {
        myRB.velocity = new Vector2(0, 0);
    }
}
