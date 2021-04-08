using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Web : MonoBehaviour
{
    public IEnumerator Login(string username, string password){
        WWWForm form=new WWWForm();
        form.AddField("loginUser",username);
        form.AddField("loginPass",password);

        using(UnityWebRequest www=UnityWebRequest.Post("http://localhost/proyecto/login.php",form)){
            yield return www.SendWebRequest();
            if(www.isNetworkError|| www.isHttpError){
                Debug.Log(www.error);
            }else{
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    public IEnumerator RegisterUser(string nombre, string apellido,string username, string password, int edad ){
        WWWForm form=new WWWForm();
        form.AddField("nombre",nombre);
        form.AddField("apellido",apellido);
        form.AddField("nombreID",username);
        form.AddField("contrasena",password);
        form.AddField("edad",edad);
        using(UnityWebRequest www=UnityWebRequest.Post("http://localhost/proyecto/registrar.php",form)){
            yield return www.SendWebRequest();
            if(www.isNetworkError||www.isHttpError){
                Debug.Log(www.error);
            }else{
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
        
    


    
}
