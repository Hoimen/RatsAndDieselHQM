using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Alteruna; // Ensure this is the correct namespace

public class MultiplayerManager : MonoBehaviour
{
    public static MultiplayerManager Instance { get; private set; }

    private Dictionary<int, string> playerUsernames = new Dictionary<int, string>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerUsername(int playerId, string username)
    {
        if (playerUsernames.ContainsKey(playerId))
        {
            playerUsernames[playerId] = username;
        }
        else
        {
            playerUsernames.Add(playerId, username);
        }
    }

    public string GetPlayerUsername(int playerId)
    {
        if (playerUsernames.TryGetValue(playerId, out string username))
        {
            return username;
        }
        return null;
    }
}
