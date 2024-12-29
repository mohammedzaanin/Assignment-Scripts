using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
public class CustomObject
{
    int _ID;
    public int ID
    {
        get
        {
            return _ID;
        }
        set
        {
            _ID = value;
        }
    }
    string _Name;
    public string Name
    {
        get
        {
            return _Name;
        }
        set
        {
            _Name = value;
        }
    }
    public CustomObject(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}";
    }
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;

        CustomObject compare_object = (CustomObject)obj;
        return ID == compare_object.ID && Name == compare_object.Name;
    }
    public static bool operator == (CustomObject obj1, CustomObject obj2)
    {
        if (obj1 is null || obj2 is null)
        {
            return false;
        }
        if(Equals(obj1,obj2))
        {
            return true;
        }
        

        return obj1.ID == obj2.ID && obj1.Name == obj2.Name;
    }
    public static bool operator !=(CustomObject obj1, CustomObject obj2)
    {
        return !(obj1 == obj2);
    }
}
}