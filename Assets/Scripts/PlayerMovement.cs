using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D playerRB;
    [SerializeField] private float maxVelocidad;
    [SerializeField] private float poderSalto;

    private bool jump;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

        
    }

    private void FixedUpdate()
    {
        float mover = Input.GetAxis("Horizontal");
        playerRB.velocity = new Vector2(mover * maxVelocidad, playerRB.velocity.y);

        if (jump)
        {
            playerRB.AddForce(Vector2.up * poderSalto, ForceMode2D.Impulse);
            jump = false;
        }
    }
}
