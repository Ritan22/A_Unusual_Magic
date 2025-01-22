using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Biliardo : MonoBehaviour
{
    public TextMeshProUGUI text;
    [SerializeField] private GameObject bauleAperto;
    [SerializeField] private GameObject bauleChiuso;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject cameraEffetto;
    public GameObject self;
    [SerializeField] private GameObject _666;



    // Update is called once per frame
    void Update()
    {   
        if (text.text.Contains("666")){
            //print("bravo");
            bauleChiuso.SetActive(false);
            bauleAperto.SetActive(true);
            player.SetActive(true);
            cameraEffetto.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            _666.SetActive(true);
            Destroy(self);
        /*if(text.text.Length < 4){
            
        }*/
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            player.SetActive(true);
            cameraEffetto.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            self.SetActive(false);
        }

    }
}
