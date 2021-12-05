using UnityEngine;
using Photon.Pun;

public class Connect : MonoBehaviourPunCallbacks
{
    public GameObject connectPanel;
    public GameObject lobbyPanel;

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected");
        connectPanel.SetActive(false);
        lobbyPanel.SetActive(true);
    }
}
