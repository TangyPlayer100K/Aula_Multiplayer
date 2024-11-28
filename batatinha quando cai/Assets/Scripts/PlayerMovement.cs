using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviourPunCallbacks
{
    public float hp = 100;

    public float speed = 30f;
    public float rspeed = 60f;

    public Camera spectatorCamera;
    public Camera playerCamera;
    public Camera mainCamera;
    public bool dead;

    void Start()
    {
        hp = 100;
        spectatorCamera = GameObject.Find("SpectatorCamera").GetComponent<Camera>();
        mainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
        dead = false;
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKey(KeyCode.A) && dead == false)
            {
                transform.Translate(-speed * Time.deltaTime, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.D) && dead == false)
            {
                transform.Translate(speed * Time.deltaTime, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.W) && dead == false)
            {
                transform.Translate(0f, 0f, speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S) && dead == false)
            {
                transform.Translate(0f, 0f, -speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && dead == false)
            {
                transform.Rotate(0f, -2f, 0f);
                //transform.Translate(0f, -rspeed * Time.deltaTime, 0f);
            }
            if (Input.GetKey(KeyCode.RightArrow) && dead == false)
            {
                transform.Rotate(0f, 2f, 0f);
                //transform.Translate(0f, rspeed * Time.deltaTime, 0f);
            }
            if (hp > 100)
            {
                hp = 100;
            }
            if (hp <= 0)
            {
                dead = true;
                playerCamera.gameObject.SetActive(false);
                mainCamera.gameObject.SetActive(false);
                spectatorCamera.gameObject.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dano"))
        {
            hp -= 10;
        }
        if (other.gameObject.CompareTag("Heal"))
        {
            hp += 10;
        }
    }
}
