using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Text;
using Android.Text.Style;

namespace UPBCalendar
{
    public class EventAdapter : BaseAdapter
    {

        public bool IsAlarmEmpty = false;

        public List<Events> PAA2012 = new List<Events>();
        public List<Events> PAA2013 = new List<Events>();
        public List<Events> ELASH2012 = new List<Events>();
        public List<Events> ELASH2013 = new List<Events>();
        public List<Events> PREU2012 = new List<Events>();
        public List<Events> PREU2013 = new List<Events>();
        public List<Events> EXAM2012 = new List<Events>();
        public List<Events> EXAM2013 = new List<Events>();
        public List<Events> THELIST = new List<Events>();

        public EventAdapter()
            : base()
        {
            Initialize();
        }


        private void Initialize()
        {
            PAA2012.Add(new Events("7 de Noviembre","09:00","PAA"));
            PAA2012.Add(new Events("7 de Noviembre", "15:00", "PAA"));
            PAA2012.Add(new Events("28 de Noviembre", "09:00", "PAA"));
            PAA2012.Add(new Events("28 de Noviembre", "15:00", "PAA"));
            PAA2012.Add(new Events("12 de Diciembre", "15:00", "PAA"));
            ELASH2012.Add(new Events("7 de Noviembre", "9:00", "ELASH"));
            PREU2012.Add(new Events("Matematicas(Grupo 1)", "19 de Noviembre al 17 de Diciembre", "7:45 a 12:00", "PREU"));
            PREU2012.Add(new Events("Matematicas(Grupo 2)", "19 de Noviembre al 17 de Diciembre", "7:45 a 12:00", "PREU"));
            PREU2012.Add(new Events("Matematicas(Grupo 3)", "19 de Noviembre al 17 de Diciembre", "14:30 a 18:45", "PREU"));
            PREU2012.Add(new Events("Quimica", "19 de Noviembre al 17 de Diciembre", "10:00 a 12:00","PREU"));
            EXAM2012.Add(new Events("Matematicas", "12 de Noviembre", "10:00", "EXAM"));
            EXAM2012.Add(new Events("Matematicas", "17 de Diciembre", "10:00", "EXAM"));
            EXAM2012.Add(new Events("Fisica", "13 de Noviembre", "10:00", "EXAM"));
            EXAM2012.Add(new Events("Fisica", "18 de Diciembre", "10:00", "EXAM"));
            EXAM2012.Add(new Events("Quimica", "14 de Noviembre", "10:00", "EXAM"));
            EXAM2012.Add(new Events("Quimica", "19 de Diciembre", "10:00", "EXAM"));
            EXAM2012.Add(new Events("Comunicacion", "14 de Diciembre", "9:00", "EXAM"));

            PAA2013.Add(new Events("8 de Enero", "09:00", "PAA"));
            PAA2013.Add(new Events("8 de Enero", "15:00", "PAA"));
            PAA2013.Add(new Events("22 de Enero", "09:00", "PAA"));
            PAA2013.Add(new Events("22 de Enero", "15:00", "PAA"));
            ELASH2013.Add(new Events("18 de Enero", "8:30", "ELASH"));
            PREU2013.Add(new Events("Matematicas(Grupo 1)", "7 al 30 de Enero", "7:45 a 12:00", "PREU"));
            PREU2013.Add(new Events("Matematicas(Grupo 2)", "7 al 30 de Enero", "14:30 a 18:45", "PREU"));
            PREU2013.Add(new Events("Fisica", "7 al 30 de Enero", "7:45 a 9:45", "PREU"));
            PREU2013.Add(new Events("Quimica", "7 al 30 de Enero", "10:00 a 12:00", "PREU"));
            EXAM2013.Add(new Events("Matematicas", "7 de Enero", "10:00", "EXAM"));
            EXAM2013.Add(new Events("Matematicas", "24 de Enero", "10:00", "EXAM"));
            EXAM2013.Add(new Events("Fisica", "8 de Enero", "10:00", "EXAM"));
            EXAM2013.Add(new Events("Fisica", "25 de Enero", "10:00", "EXAM"));
            EXAM2013.Add(new Events("Quimica", "9 de Enero", "10:00", "EXAM"));
            EXAM2013.Add(new Events("Quimica", "28 de Enero", "10:00", "EXAM"));
            
            THELIST.Add(new Events("2012",true,"YEAR"));
            THELIST.Add(new Events("Prueba de Aptitud Academica (PAA)", true, "SEC"));
            THELIST.AddRange(PAA2012);
            THELIST.Add(new Events("ELASH", true, "SEC"));
            THELIST.AddRange(ELASH2012);
            THELIST.Add(new Events("Curso Preuniversitario", true, "SEC"));
            THELIST.AddRange(PREU2012);
            THELIST.Add(new Events("Examenes de Conocimiento", true, "SEC"));
            THELIST.AddRange(EXAM2012);
            THELIST.Add(new Events("2013", true, "YEAR"));
            THELIST.Add(new Events("Prueba de Aptitud Academica (PAA)", true, "SEC"));
            THELIST.AddRange(PAA2013);
            THELIST.Add(new Events("ELASH", true, "SEC"));
            THELIST.AddRange(ELASH2013);
            THELIST.Add(new Events("Curso Preuniversitario", true, "SEC"));
            THELIST.AddRange(PREU2013);
            THELIST.Add(new Events("Examenes de Conocimiento", true, "SEC"));
            THELIST.AddRange(EXAM2013);

            


        }


        public override int Count
        {
            get
            {
                return THELIST.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return THELIST[position].ToString();
        }


        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view;
            Events ev = THELIST[position];
            view = createItem(parent.Context, parent.Width, ev);
            return view;
        }

        private View createItem(Context context, int width, Events ev)
        {
            TableRow row = new TableRow(context);
            row.SetVerticalGravity(GravityFlags.CenterVertical);
            int rowWidth = (width / 10);
            if (ev.IsHeader)
                row.AddView(createHeader(context,ev),rowWidth*10,50);
            else if (ev.Type == "PAA" || ev.Type == "ELASH")
            {
                row.AddView(createColumn(context, ev.Date), rowWidth * 8, 40);
                row.AddView(createHour(context, ev.Hour), rowWidth * 2, 40);
            }
            else
            {
                row.AddView(createDoubleColumn(context, ev.Event,ev.Date), rowWidth * 8, 80);
                if (ev.Type == "PREU")
                    row.AddView(createDoubleHour(context, ev.Hour), rowWidth * 2, 80);
                else
                    row.AddView(createHour(context, ev.Hour), rowWidth * 2, 80);
            }
            return row;
        }

        private View createHeader(Context context, Events ev)
        {
            TextView view = new TextView(context);
            if (ev.Type=="YEAR")
            {
                view.SetBackgroundColor(Android.Graphics.Color.ParseColor("#3B3477"));
                view.Text = ev.Event;
                view.SetTextColor(Android.Graphics.Color.White);
                view.Gravity = GravityFlags.Center;
            }
            else
            {
                view.SetBackgroundColor(Android.Graphics.Color.ParseColor("#F9B129"));
                view.Text = ev.Event;
                view.SetTextColor(Android.Graphics.Color.ParseColor("#3B3477"));
                view.Gravity = GravityFlags.Center;
            }
            //#F9B129 amarillo
            //#3B3477 azul
            return view;
        }

        private View createDoubleColumn(Context context, string ev, string da)
        {
            TextView view = new TextView(context);
            view.SetPadding(20, 0, 0, 0);
            view.SetBackgroundColor(Android.Graphics.Color.White);
            view.Text = ev+"\n"+da;
            view.SetTextColor(Android.Graphics.Color.ParseColor("#3B3477"));
            return view;
        }


        private View createColumn(Context context, string ev)
        {
            TextView view = new TextView(context);
            view.SetPadding(20, 0, 0, 0);
            view.SetBackgroundColor(Android.Graphics.Color.White);
            view.Text = ev;
            view.SetTextColor(Android.Graphics.Color.ParseColor("#3B3477"));
            return view;
        }

        private View createDoubleHour(Context context, string ev)
        {
            TextView view = new TextView(context);
            view.SetPadding(0, 0, 20, 0);
            view.SetBackgroundColor(Android.Graphics.Color.White);
            string[] spl = ev.Split('a');
            view.Text = spl[0].TrimEnd(' ')+"\na"+spl[1];
            view.SetTextColor(Android.Graphics.Color.ParseColor("#3B3477"));
            view.Gravity = GravityFlags.Right;
            return view;
        }

        private View createHour(Context context, string ev)
        {
            TextView view = new TextView(context);
            view.SetPadding(0, 0, 20, 0);
            view.SetBackgroundColor(Android.Graphics.Color.White);
            view.Text = ev;
            view.SetTextColor(Android.Graphics.Color.ParseColor("#3B3477"));
            view.Gravity = GravityFlags.CenterVertical;
            view.Gravity = GravityFlags.Right;
            return view;
        }



    }
}