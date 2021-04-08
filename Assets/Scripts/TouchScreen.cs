using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TouchScreen : MonoBehaviour
{
    TouchScreenKeyboard clavier;
    public TMP_Text texto;

    public void OpenKeyboard(){
        clavier=TouchScreenKeyboard.Open(texto.text,TouchScreenKeyboardType.Default,false,false,true,true);
    }



   
}
