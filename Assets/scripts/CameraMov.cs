using System.Collections;
using UnityEngine;

public class CameraMov : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {

        if(player == null)

        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
