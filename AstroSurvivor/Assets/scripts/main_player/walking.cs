using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour

{
    public Rigidbody2D rbPlayer;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("oops");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rbPlayer.AddForce(new Vector2(5f, 0f));
        }
    }

 }