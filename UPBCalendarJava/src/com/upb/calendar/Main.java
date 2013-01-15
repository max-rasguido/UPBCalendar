package com.upb.calendar;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.widget.ListView;;

public class Main extends Activity {

	ListView Eventlist;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(android.view.Window.FEATURE_NO_TITLE);
		setContentView(R.layout.main);
		Eventlist = (ListView)findViewById(R.id.EventList);
        EventAdapter ad = new EventAdapter();
        Eventlist.setAdapter(ad);

	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

}
