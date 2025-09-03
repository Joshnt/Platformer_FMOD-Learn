using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class TokenCounter : MonoBehaviour
{
    public static TokenCounter Instance { get; private set; }
    private int tokensCollected = 0;
    public int TokensCollected
    {
        get { return tokensCollected; }
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        RuntimeManager.StudioSystem.setParameterByName("Anzahl Tokens", 0);
    }

    public void TokenCollected()
    {
        tokensCollected += 1;
        RuntimeManager.StudioSystem.setParameterByName("Anzahl Tokens", tokensCollected);
    }
}
