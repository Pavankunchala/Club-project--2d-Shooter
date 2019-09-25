﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

    public static EnemyHealth instance;

    public float fullHealth;

    public float currentHealth;

    private AudioSource eneAS;
    [SerializeField]
    private AudioClip enemClip;

    [SerializeField]
    private GameObject exploEffect;

    [SerializeField]
    private Slider enemyHealthSlider;

    public bool isHit = false;


    




    // Use this for initialization
    void Start () {
        eneAS = GetComponent<AudioSource>();
        currentHealth = fullHealth;
        enemyHealthSlider.maxValue = fullHealth;
        enemyHealthSlider.value = currentHealth;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddDamage(float damage)
    {
       

        enemyHealthSlider.gameObject.SetActive(true);
        currentHealth -= damage;
       
        
        enemyHealthSlider.value = currentHealth;
        eneAS.PlayOneShot(enemClip);

        if(currentHealth<= 0)
        {
            
            Destroy(gameObject);
            Instantiate(exploEffect, transform.position, Quaternion.identity);
        }
    }

    


}
