using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;



public class AccountInquiryz : MonoBehaviour
{
    private Login logins;

    IEnumerator Accounts()
    {
        WWWForm wwf = new WWWForm();

       UnityWebRequest www =UnityWebRequest.Get("http://10.80.162.103:8000/account/");
        www.SetRequestHeader("Authorization",Account.instance.GetTocken());

        
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.downloadHandler.text);
            Debug.Log(www.error);
        }
        else
        {
            File.WriteAllBytes(Application.dataPath + "Account.json", www.downloadHandler.data);
            string a = File.ReadAllText(Application.dataPath + "Account.json");
            JsonData d = JsonMapper.ToObject(a);
            Debug.Log(a.ToString());
            Debug.Log(d["data"][0]["money"].ToString());
            Account.instance= new Account(d["data"][0]["money"].ToString(), d["data"][0]["bankName"].ToString(), d["data"][0]["accountName"].ToString(), d["data"][0]["accountNumber"].ToString());
            Debug.Log("돈:" + Account.instance.GetMoney() + "은행이름:" + Account.instance.GetBankName() + "사람이름:" + Account.instance.GetAccountName() + "계좌번호" + Account.instance.GetAccountNumber());


            Debug.Log("Form upload complete!");
        }
    }

    public void AccountClick()
    {
        StartCoroutine(Accounts());
    }

}
