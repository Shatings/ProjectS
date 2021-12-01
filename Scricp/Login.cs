using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using LitJson;
using System.IO;

public class Login : MonoBehaviour
{
    public InputM input;
    public LoginInformation imfo = new LoginInformation();
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Logins()
    {
        WWWForm wwf = new WWWForm();
        wwf.AddField("id", input.inputId);
        wwf.AddField("password", input.inputPass);
        UnityWebRequest www = UnityWebRequest.Post("http://10.80.162.103:8000/user/login", wwf);
        Debug.Log(www);
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.downloadHandler.text);
            Debug.Log(www.error);
        }
        else
        {
            File.WriteAllBytes(Application.dataPath+"tocken.json", www.downloadHandler.data);
            string s = File.ReadAllText(Application.dataPath + "tocken.json");
            JsonData a = JsonMapper.ToObject(s);

            Account.instance.SetTocken(a["loginToken"].ToString());
            Debug.Log(Account.instance.GetTocken());
            imfo.LoginOK(input.inputId, input.inputPass);
            FindObjectOfType<SceanM>().SceanMove("StartScene");
            Debug.Log("Form upload complete!");
        }
    }
    public void click()
    {
        StartCoroutine(Logins());
    }
}



