using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class Player : NetworkBehaviour
{
    public static Player localPlayer;
    // Start is called before the first frame update
    private void Start()
    {
        if (isLocalPlayer)
        {
            localPlayer = this;
        }
    }
    public void HostGame()
    { 
        
    }
}
