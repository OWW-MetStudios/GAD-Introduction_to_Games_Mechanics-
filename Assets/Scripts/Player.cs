 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Variables 
    public GameObject playerTransform;
    public float playerRotateSpeed  = 2.0f;
    public GameObject projectile;
    public Transform projectileSpawnPoint;

    void Update()
    {
        // Check if player has pressed either of the Vertical or Horizontal keys,
        // if they're pressed store the value in a float

        float v = playerRotateSpeed * Input.GetAxis(("Vertical"));
        float h = playerRotateSpeed * Input.GetAxis("Horizontal");
        
        // Transform the player rotation based on the two input values 
        playerTransform.transform.Rotate(v, h, 0);

        // Check for input of space bar
        if (Input.GetKeyDown("space"))
        {
            Instantiate(projectile, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
        }
    }

}
