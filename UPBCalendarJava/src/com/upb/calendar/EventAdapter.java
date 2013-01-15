package com.upb.calendar;

import java.util.ArrayList;
import java.util.List;

import android.content.Context;
import android.view.Gravity;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TableRow;
import android.widget.TextView;

public class EventAdapter extends BaseAdapter{

	public boolean IsAlarmEmpty = false;

    public List<Events> PAA2012 = new ArrayList<Events>();
    public List<Events> PAA2013 = new ArrayList<Events>();
    public List<Events> ELASH2012 = new ArrayList<Events>();
    public List<Events> ELASH2013 = new ArrayList<Events>();
    public List<Events> PREU2012 = new ArrayList<Events>();
    public List<Events> PREU2013 = new ArrayList<Events>();
    public List<Events> EXAM2012 = new ArrayList<Events>();
    public List<Events> EXAM2013 = new ArrayList<Events>();
    public List<Events> THELIST = new ArrayList<Events>();

    public EventAdapter()
    {
    	Initialize();
    }


private void Initialize()
{
    PAA2012.add(new Events("7 de Noviembre","09:00","PAA"));
    PAA2012.add(new Events("7 de Noviembre", "15:00", "PAA"));
    PAA2012.add(new Events("28 de Noviembre", "09:00", "PAA"));
    PAA2012.add(new Events("28 de Noviembre", "15:00", "PAA"));
    PAA2012.add(new Events("12 de Diciembre", "15:00", "PAA"));
    ELASH2012.add(new Events("7 de Noviembre", "9:00", "ELASH"));
    PREU2012.add(new Events("Matematicas(Grupo 1)", "19 de Noviembre al 17 de Diciembre", "7:45 a 12:00", "PREU"));
    PREU2012.add(new Events("Matematicas(Grupo 2)", "19 de Noviembre al 17 de Diciembre", "7:45 a 12:00", "PREU"));
    PREU2012.add(new Events("Matematicas(Grupo 3)", "19 de Noviembre al 17 de Diciembre", "14:30 a 18:45", "PREU"));
    PREU2012.add(new Events("Quimica", "19 de Noviembre al 17 de Diciembre", "10:00 a 12:00","PREU"));
    EXAM2012.add(new Events("Matematicas", "12 de Noviembre", "10:00", "EXAM"));
    EXAM2012.add(new Events("Matematicas", "17 de Diciembre", "10:00", "EXAM"));
    EXAM2012.add(new Events("Fisica", "13 de Noviembre", "10:00", "EXAM"));
    EXAM2012.add(new Events("Fisica", "18 de Diciembre", "10:00", "EXAM"));
    EXAM2012.add(new Events("Quimica", "14 de Noviembre", "10:00", "EXAM"));
    EXAM2012.add(new Events("Quimica", "19 de Diciembre", "10:00", "EXAM"));
    EXAM2012.add(new Events("Comunicacion", "14 de Diciembre", "9:00", "EXAM"));

    PAA2013.add(new Events("8 de Enero", "09:00", "PAA"));
    PAA2013.add(new Events("8 de Enero", "15:00", "PAA"));
    PAA2013.add(new Events("22 de Enero", "09:00", "PAA"));
    PAA2013.add(new Events("22 de Enero", "15:00", "PAA"));
    ELASH2013.add(new Events("18 de Enero", "8:30", "ELASH"));
    PREU2013.add(new Events("Matematicas(Grupo 1)", "7 al 30 de Enero", "7:45 a 12:00", "PREU"));
    PREU2013.add(new Events("Matematicas(Grupo 2)", "7 al 30 de Enero", "14:30 a 18:45", "PREU"));
    PREU2013.add(new Events("Fisica", "7 al 30 de Enero", "7:45 a 9:45", "PREU"));
    PREU2013.add(new Events("Quimica", "7 al 30 de Enero", "10:00 a 12:00", "PREU"));
    EXAM2013.add(new Events("Matematicas", "7 de Enero", "10:00", "EXAM"));
    EXAM2013.add(new Events("Matematicas", "24 de Enero", "10:00", "EXAM"));
    EXAM2013.add(new Events("Fisica", "8 de Enero", "10:00", "EXAM"));
    EXAM2013.add(new Events("Fisica", "25 de Enero", "10:00", "EXAM"));
    EXAM2013.add(new Events("Quimica", "9 de Enero", "10:00", "EXAM"));
    EXAM2013.add(new Events("Quimica", "28 de Enero", "10:00", "EXAM"));
    
    THELIST.add(new Events("2012",true,"YEAR"));
    THELIST.add(new Events("Prueba de Aptitud Academica (PAA)", true, "SEC"));
    THELIST.addAll(PAA2012);
    THELIST.add(new Events("ELASH", true, "SEC"));
    THELIST.addAll(ELASH2012);
    THELIST.add(new Events("Curso Preuniversitario", true, "SEC"));
    THELIST.addAll(PREU2012);
    THELIST.add(new Events("Examenes de Conocimiento", true, "SEC"));
    THELIST.addAll(EXAM2012);
    THELIST.add(new Events("2013", true, "YEAR"));
    THELIST.add(new Events("Prueba de Aptitud Academica (PAA)", true, "SEC"));
    THELIST.addAll(PAA2013);
    THELIST.add(new Events("ELASH", true, "SEC"));
    THELIST.addAll(ELASH2013);
    THELIST.add(new Events("Curso Preuniversitario", true, "SEC"));
    THELIST.addAll(PREU2013);
    THELIST.add(new Events("Examenes de Conocimiento", true, "SEC"));
    THELIST.addAll(EXAM2013);
}

    
	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return THELIST.size();
	}

	@Override
	public Object getItem(int position) {
		// TODO Auto-generated method stub
		return THELIST.get(position).toString();
	}

	@Override
	public long getItemId(int position) {
		// TODO Auto-generated method stub
		return position;
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		// TODO Auto-generated method stub
        View view;
        Events ev = THELIST.get(position);
        view = createItem(parent.getContext(), parent.getWidth(), ev);
        return view;
	}
    private View createItem(Context context, int width, Events ev)
    {
        TableRow row = new TableRow(context);
        row.setVerticalGravity(android.view.Gravity.CENTER_VERTICAL);
        int rowWidth = (width / 10);
        if (ev.IsHeader)
            row.addView(createHeader(context,ev),rowWidth*10,50);
        else if (ev.Type == "PAA" || ev.Type == "ELASH")
        {
            row.addView(createColumn(context, ev.Date), rowWidth * 8, 40);
            row.addView(createHour(context, ev.Hour), rowWidth * 2, 40);
        }
        else
        {
            row.addView(createDoubleColumn(context, ev.Event,ev.Date), rowWidth * 8, 80);
            if (ev.Type == "PREU")
                row.addView(createDoubleHour(context, ev.Hour), rowWidth * 2, 80);
            else
                row.addView(createHour(context, ev.Hour), rowWidth * 2, 80);
        }
        return row;
    }

    private View createHeader(Context context, Events ev)
    {
        TextView view = new TextView(context);
        if (ev.Type=="YEAR")
        {
            view.setBackgroundColor(android.graphics.Color.parseColor("#3B3477"));
            view.setText(ev.Event);
            view.setTextColor(android.graphics.Color.WHITE);
            view.setGravity(Gravity.CENTER);
        }
        else
        {
            view.setBackgroundColor(android.graphics.Color.parseColor("#F9B129"));
            view.setText(ev.Event);
            view.setTextColor(android.graphics.Color.parseColor("#3B3477"));
            view.setGravity(Gravity.CENTER);
        }
        //#F9B129 amarillo
        //#3B3477 azul
        return view;
    }

    private View createDoubleColumn(Context context, String ev, String da)
    {
        TextView view = new TextView(context);
        view.setPadding(20, 0, 0, 0);
        view.setBackgroundColor(android.graphics.Color.WHITE);
        view.setText(ev+"\n"+da);
        view.setTextColor(android.graphics.Color.parseColor("#3B3477"));
        return view;
    }


    private View createColumn(Context context, String ev)
    {
        TextView view = new TextView(context);
        view.setPadding(20, 0, 0, 0);
        view.setBackgroundColor(android.graphics.Color.WHITE);
        view.setText(ev);
        view.setTextColor(android.graphics.Color.parseColor("#3B3477"));
        return view;
    }

    private View createDoubleHour(Context context, String ev)
    {
        TextView view = new TextView(context);
        view.setPadding(0, 0, 20, 0);
        view.setBackgroundColor(android.graphics.Color.WHITE);
        String[] spl = ev.split("a");
        view.setText(spl[0].trim()+"\na"+spl[1]);
        view.setTextColor(android.graphics.Color.parseColor("#3B3477"));
        view.setGravity(Gravity.RIGHT);
        return view;
    }

    private View createHour(Context context, String ev)
    {
        TextView view = new TextView(context);
        view.setPadding(0, 0, 20, 0);
        view.setBackgroundColor(android.graphics.Color.WHITE);
        view.setText(ev);
        view.setTextColor(android.graphics.Color.parseColor("#3B3477"));
        view.setGravity(Gravity.CENTER_VERTICAL);
        view.setGravity(Gravity.RIGHT);
        return view;
    }

}
