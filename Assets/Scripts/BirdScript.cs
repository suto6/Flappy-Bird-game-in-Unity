using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public LOgicScript Logic;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LOgicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && isAlive == true)
        {
            myRigidBody.velocity = Vector2.up * 10;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameOver();
        isAlive = false;
    }
}
