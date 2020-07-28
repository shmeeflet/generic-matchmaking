using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System.Diagnostics;

public class AutoHostClient : MonoBehaviour
{
    [SerializeField] NetworkManager networkManager;
    void Start()
    {
        if (!Application.isBatchMode)
        {
            UnityEngine.Debug.Log("===client connected===");
            networkManager.StartClient();
        }
        else
        {
            UnityEngine.Debug.Log("===server starting===");
        }
    }
    public void JoinLocal()
    {
        networkManager.networkAddress = "localhost";
        networkManager.StartClient();
    }
}
