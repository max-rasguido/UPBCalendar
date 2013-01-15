package com.upb.calendar;

public class Events {

	public String Event;
    public String Date;
    public String Hour;
    public String Type;
    public boolean IsHeader;
    
    public Events(String ev,String da, String ho, String type)
    {
        Event = ev;
        Date = da;
        Hour = ho;
        Type = type;
        IsHeader = false;
    }
    public Events(String da, String ho,String type)
    {
        Date = da;
        Hour = ho;
        Type = type;
        IsHeader = false;
    }
    public Events(String he, boolean IH,String type)
    {
        Event = he;
        IsHeader = IH;
        Type = type;
    }
    public String GetStringEvent()
    {
        return Date + "|" + Hour;
    }

	
}
