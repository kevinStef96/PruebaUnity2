using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TMP_Text messageTxt;





    public void SubmitLogin(){
        if(usernameInput.text==""||passwordInput.text==""){
                 messageTxt.text="Ingrese nuevamente los datos";
                 Invoke("disableText",2f);  
        }else{
            StartCoroutine(Main.instance.web.Login(usernameInput.text,passwordInput.text));
            SceneManager.LoadScene("MenuPrincipal");
        }
    }
    public void disableText(){
        messageTxt.enabled=false;
    }
    
    
   
}
