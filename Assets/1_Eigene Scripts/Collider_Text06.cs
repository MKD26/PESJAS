using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using cakeslice;

public class Collider_Text06 : MonoBehaviour
{
    public GameObject learningElement;
    public LernraumLogik logikFuerLernraum;
    public DialogZeilenWriter dialogZeile;
    private GameObject kamera;
    private Outline outLinerScript;
    private string dialogzeilenText = "´Solltest du mal nicht weiterwissen, kannst du dir bei einigen Bücherregalen nützliche Tipps holen. Schließlich kannst auch du nicht alles wissen!`";
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