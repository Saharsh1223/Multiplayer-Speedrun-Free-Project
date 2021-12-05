using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class Lobby : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;
    [Space]
    public byte maxPlayers;

    private void Start()
    {
        PhotonNetwork.JoinLobby();
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public void CreateRoom()
    {
        if(createInput.text.Length > 0)
        {
            RoomOptions roomOptions = new RoomOptions();
            roomOptions.MaxPlayers = maxPlayers;

            PhotonNetwork.CreateRoom(createInput.text, roomOptions);
        }
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("DemoScene_01");
    }
}
