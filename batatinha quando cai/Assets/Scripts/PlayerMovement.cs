using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviourPunCallbacks
{

    public float speed = 30f;
    public float rspeed = 60f;

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-speed * Time.deltaTime, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed * Time.deltaTime, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0f, 0f, speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0f, 0f, -speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0f, -2f, 0f);
                //transform.Translate(0f, -rspeed * Time.deltaTime, 0f);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0f, 2f, 0f);
                //transform.Translate(0f, rspeed * Time.deltaTime, 0f);
            }
        }
    }
}
