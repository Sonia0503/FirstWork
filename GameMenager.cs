﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenager : MonoBehaviour {

  private static GameMenager instance;

    [SerializeField]
    private GameObject coinPrefab;

    [SerializeField]
    private Text coinText;

    private int collectedCoins;

    public static GameMenager Instance
    {
        get
        {   if (instance == null)
            { instance = FindObjectOfType<GameMenager>(); }
            return instance;
        }

    }

    public GameObject CoinPrefab
    {
        get
        {
            return coinPrefab;
        }

        
    }

    public int CollectedCoins
    {
        get
        {
            return collectedCoins;
        }

        set
        {
            coinText.text = value.ToString();
            collectedCoins = value;
        }
    }





    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
