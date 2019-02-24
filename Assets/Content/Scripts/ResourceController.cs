﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour {

    public Text moneyText, energyText; // Creates a public text gameObject
    public int factoryNumb, factoryEnergy, houseNumb, houseMoney;
    float time;

	// Use this for initialization
	void Start ()
    {
        // Set as Default
        moneyText.text = "100";
        energyText.text = "5";
    }
	
	// Update is called once per frame
	void Update ()
    {
        factoryNumb = GameObject.FindGameObjectsWithTag("Factory").Length;
        time += Time.deltaTime;
        factoryEnergy = int.Parse(energyText.text);
        houseMoney = int.Parse(moneyText.text);
        
        houseNumb = GameObject.FindGameObjectsWithTag("House").Length;
        
        if(time > 1)
        {
            factoryEnergy += factoryNumb * 1;
            energyText.text = factoryEnergy.ToString();

            houseMoney += houseNumb * 2;
            moneyText.text = houseMoney.ToString();

            time = 0;
        }
    }
}
