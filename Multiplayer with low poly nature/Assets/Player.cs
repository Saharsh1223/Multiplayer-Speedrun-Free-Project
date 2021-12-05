using UnityEngine;
using Photon.Pun;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.Cameras;

public class Player : MonoBehaviour
{
    public PhotonView photonView;
    [Space]
    public ThirdPersonCharacter thirdPersonCharacter;
    public ThirdPersonUserControl thirdPersonUserControl;
    [Space]
    public FreeLookCam freeLookCam;

    private void Start()
    {
        if (photonView.IsMine)
        {
            freeLookCam = FindObjectOfType<FreeLookCam>();
        }

        Invoke("AfterStart", 0.03f);
    }

    void AfterStart()
    {
        freeLookCam.SetTarget(gameObject.transform);

        if (!photonView.IsMine)
        {
            gameObject.tag = "OtherPlayer";
        }
    }

    private void Update()
    {
        if (!photonView.IsMine)
        {
            thirdPersonCharacter.enabled = false;
            thirdPersonUserControl.enabled = false;
        }
    }
}
