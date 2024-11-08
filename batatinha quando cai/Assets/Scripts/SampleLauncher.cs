using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleLauncher : MonoBehaviourPunCallbacks
{
    public PhotonView playerPrefab;

    public InputField playerNickName;
    public GameObject nickNameImput;
    // Start is called before the first frame update
    void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("Connected to master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnJoinedRoom()
    {
        print("Joined a room.");
        PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
    }

    public void StartTheGame()
    {
        PhotonNetwork.NickName = playerNickName.text;
        PhotonNetwork.ConnectUsingSettings();

        nickNameImput.SetActive(false);
    }
}
