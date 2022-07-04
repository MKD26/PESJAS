using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using cakeslice;

public class Collider_Text_Konferenz1 : MonoBehaviour
{
    public GameObject learningElement;
    public LernraumLogik logikFuerLernraum;
    public DialogZeilenWriter dialogZeile;
    private GameObject kamera;
    private Outline outLinerScript;
    private string dialogzeilenText = "´Diese verflixten Hacker!... Wir müssen dringend etwas unternehmen, die Prüfungsphase steht vor der Tür.`";
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