using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Account:MonoBehaviour
{
    [SerializeField]
    private  long money;
    [SerializeField]
    private  string bankname;
    [SerializeField]
    private  string accountName;
    [SerializeField]
    private  long accountNumber;
    public static Account instance;
    [SerializeField]
    private string tocken;

    public void SetTocken(string _tocken)
    {
        tocken = _tocken;
    }
    public string GetTocken()
    {
        return tocken;
    }
    private void Awake()
    {
        if(instance == null)
        {
            
            instance = this;
        }
    }
    public Account(string _money, string _bankname, string _accountName, string _accountNumber)
    {
        money = Int64.Parse(_money);
        bankname = _bankname;
        accountName = _accountName;
        accountNumber = Int64.Parse(_accountNumber);
    }
    public long GetMoney()
    {
        return money;
    }
    public string GetBankName()
    {
        return bankname;
    }
    public string GetAccountName()
    {
        return accountName;
    }
    public long GetAccountNumber()
    {
        return accountNumber;
    }
}
