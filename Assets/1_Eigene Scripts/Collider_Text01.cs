using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using cakeslice;

public class Collider_Text01 : MonoBehaviour
{
    public GameObject learningElement;
    public LernraumLogik logikFuerLernraum;
    public DialogZeilenWriter dialogZeile;
    private GameObject kamera;
    private Outline outLinerScript;
    private string dialogzeilenText = "´Zum Glück bist du hier, die Hochschule benötigt dringend deine Hilfe! Bereinige alle virusbefallenen Geräte!`";
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