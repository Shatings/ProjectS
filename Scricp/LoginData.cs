using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;



public class LoginData 
{
    public string id;
    public string password;
    public int birthday;
    public string name;
    public string nickName;
    
    public string simplePassword;
    public string phoneNumber;
    public bool gender;
    public MultipartFormDataSection profile;
    public LoginData(string Id, string PassWord, int BirthDay, string Name, string NickName, string SimplePassword,string PhoneNuber,bool Gender)
    {
        id = Id;
        password = PassWord;
        birthday = BirthDay;
        name = Name;
        nickName = NickName;
        
        simplePassword = SimplePassword;
        phoneNumber = PhoneNuber;
        gender = Gender;

    }
}
public class LoginInformation
{
    private static string id;
    private static string password;
    

    public void LoginOK(string _id,string _password)
    {
        id = _id;
        password = _password;
    }
    
}

