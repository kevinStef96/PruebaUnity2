using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Register : MonoBehaviour
{
    
    public TMP_InputField nombreInput;
    public TMP_InputField apellidoInput;
    public TMP_InputField usuarioInput;
    public TMP_InputField contraseñaInput;
    public TMP_InputField recontraseñaInput;
    public TMP_InputField edadInput;
    public TMP_Text mensaje;
    

    public void SubmitRegister(){
        if(nombreInput.text==""||apellidoInput.text==""||usuarioInput.text==""||contraseñaInput.text==""||recontraseñaInput.text==""||edadInput.text==""){
            mensaje.text="Por favor llenar los campos";
        }else if(recontraseñaInput.text==contraseñaInput.text){
            StartCoroutine(Main.instance.web.RegisterUser(nombreInput.text,apellidoInput.text,usuarioInput.text,contraseñaInput.text,edad()));
            Debug.Log("Se registro correctamente");
            clear();
        }
    }

    public int edad(){
        return int.Parse(edadInput.text);
    }

    public void clear(){
        nombreInput.Select();
        nombreInput.text="";
        apellidoInput.text="";
        usuarioInput.text="";
        contraseñaInput.text="";
        recontraseñaInput.text="";
        edadInput.text="";

    }


    
    
    
    
}
