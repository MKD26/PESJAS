using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using cakeslice;

public class Collider_Text07 : MonoBehaviour
{
    public GameObject learningElement;
    public LernraumLogik logikFuerLernraum;
    public DialogZeilenWriter dialogZeile;
    private GameObject kamera;
    private Outline outLinerScript;
    private string dialogzeilenText = "´Beeil dich! Versuche die befallenen Geräte schnellstmöglich bereinigen! Deine Zeit siehst du in der oberen linken Ecke.`";
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