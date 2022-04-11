using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private InputField createInput, joinInput;

    public void CreateRoom()
    {
        var roomOptions = new RoomOptions
        {
            MaxPlayers = 4
        };
        PhotonNetwork.CreateRoom(createInput.text, roomOptions);
    }
 
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
