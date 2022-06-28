using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using cakeslice;

public class Collider_Zombie : MonoBehaviour
{
    public GameObject learningElement;
    public LernraumLogik logikFuerLernraum;
    public DialogZeilenWriter dialogZeile;
    private GameObject kamera;
    private Outline outLinerScript;
    private string dialogzeilenText = "´GRRR...`";
    private bool wurdeBearbeitet = false;



    void Start()
    {

    }

    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        dialogZeile.AndereDialogZeile(dialogzeilenText);
    }



    void OnTriggerExit(Collider other)
    {
        dialogZeile.AndereDialogZeile(null);
    }





}