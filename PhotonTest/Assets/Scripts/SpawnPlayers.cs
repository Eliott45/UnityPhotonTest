using Photon.Pun;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnPlayers : MonoBehaviour
{
    public GameObject player;
    public float minX, minY, maxX, maxY;

    private void Start()
    {
        var randomPosition = new Vector2(Random.Range(minX, minY), Random.Range(maxX, maxY));
        PhotonNetwork.Instantiate(player.name, randomPosition, Quaternion.identity);
    }
}
