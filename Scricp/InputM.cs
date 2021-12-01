using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class InputM : MonoBehaviour
{
    public string inputId;
    public string inputPass;
    public int inputBirth;
    public string inputName;
    public string inputNickN;
    public string inputprofile;
    public string inputSimplePass;
    public string inputphoneNumber;
    public bool inputgender;
   



    // Start is called before the first frame update
    

    public void Inputid(string id)
    {
        inputId = id;
        
    }
    public void InputPassword(string passworld)
    {
        inputPass =passworld;
    }
    public void InputBirthDay(string birthday)
    {
        inputBirth = Int32.Parse(birthday);
    }
    public void InputName(string name)
    {
        inputName = name;
    }
    public void InputNickName(string NickName)
    {
        inputNickN = NickName;
    }
    public void InputProFile(string profile)
    {
        inputprofile = profile;
    }
    public void InputSimplePassword(string simplepassword)
    {
        inputSimplePass = simplepassword;
    }
    public void InputPhoneNumber(string phoneNu)
    {
        inputphoneNumber = phoneNu;
    }
    public void InputPhoneNumber()
    {
        inputgender = (inputgender == true) ? false : true;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
