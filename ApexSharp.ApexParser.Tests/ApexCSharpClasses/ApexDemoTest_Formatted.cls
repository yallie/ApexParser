﻿@IsTest
public class DemoTest
{
    //:NoApex [OneTimeSetUp]
    //:NoApex public void NoApexSetup()
    //:NoApex {
    //:NoApex     new ApexSharp().Connect("C:\\DevSharp\\connect.json");
    //:NoApex }
    //:NoApex 
    @TestSetup
    public static void Setup()
    {
        Contact contactNew = new Contact();
        contactNew.LastName = 'Jay';
        contactNew.Email = 'jay@jay.com';
        insert contactNew;
    }

    @IsTest
    public static void UpdatePhoneTestValidEmail()
    {
        Demo.UpdatePhone('jay@jay.com', '555-1212');
        List<Contact> contacts = [SELECT Id, Email, Phone FROM Contact WHERE Email = 'jay@jay.com'];
        System.AssertEquals(contacts[0].Phone, '555-1212');
    }

    @IsTest
    public static void UpdatePhoneTestNotValidEmail()
    {
        Demo.UpdatePhone('nojay@jay.com', '555-1212');
        List<Contact> contacts = [SELECT Id, Email, Phone FROM Contact WHERE Email = 'nojay@jay.com'];
        System.AssertEquals(contacts.Size(), 0);
    }
}
