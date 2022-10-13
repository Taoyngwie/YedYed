using System;
public abstract class Person
{
    private string name;
    private string address;
    private string citizenID;

    public Person(string name, string address, string citizenID)
    {
        this.name = name;
        this.address = address;
        this.citizenID = citizenID;
    }

    public string GetName()
    {
        return this.name;
    }

    public string GetAddress()
    {
        return this.address;
    }

    public string GetCitizenID()
    {
        return this.citizenID;
    }
}