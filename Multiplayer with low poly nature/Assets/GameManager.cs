using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Vector3 spawnPoint;

    private void Start()
    {
        spawnPoint = new Vector3(Random.Range(-5, 5), Random.Range(3, 10), Random.Range(-5, 5));
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint, playerPrefab.transform.rotation);
    }
}