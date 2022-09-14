package com.example.android.warehouse.activity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.SearchView;

import com.example.android.warehouse.R;

import java.util.ArrayList;

import manager.ManagerActivity;

public class SearchActivity extends AppCompatActivity {
    ConnectionClass connectionClass;
    ListView lv;
    SearchView sv;


    String[] pid,lid,quan;
    //String[] mNo={"Juan Mata","ac","bcd","d"};
    int sizem=0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search);

        Bundle extras = getIntent().getExtras();
        String pid1[] = extras.getStringArray("piid");
        String lid1[] = extras.getStringArray("liid");
        String quan1[] = extras.getStringArray("quann");


        for(int i=0;i<pid1.length;i++)
        {
            if(pid1[i]!=null) {
                sizem++;
            }
        }
        pid=new String[sizem];
        lid=new String[sizem];
        quan=new String[sizem];


        for(int i=0;i<pid1.length;i++)
        {
            if(pid1[i]!=null) {
                pid[i]=pid1[i];
                lid[i]=lid1[i];
                quan[i]=quan1[i];

            }
        }

        lv=(ListView) findViewById(R.id.listView2s);
        sv=(SearchView) findViewById(R.id.searchView2s);

        //ADASPTER
        final Adapter_search adapter=new Adapter_search(this, getSearches());
        lv.setAdapter(adapter);

        sv.setOnQueryTextListener(new SearchView.OnQueryTextListener() {

            @Override
            public boolean onQueryTextSubmit(String arg0) {
                // TODO Auto-generated method stub
                return false;
            }

            @Override
            public boolean onQueryTextChange(String query) {
                // TODO Auto-generated method stub

                adapter.getFilter().filter(query);

                return false;
            }
        });



    }
    @Override
    public void onBackPressed() {
        SharedPreferences mPrefs = getSharedPreferences("IDvalue", 0);
        SharedPreferences.Editor editor = mPrefs.edit();
        editor.putString("mm","e" );
        editor.commit();
        Intent myIntent = new Intent(SearchActivity.this, ManagerActivity.class);
        startActivity(myIntent);
    }

    private ArrayList<Search> getSearches()
    {
        ArrayList<Search> searches=new ArrayList<Search>();
        Search p;

        for(int i=0;i<pid.length;i++)
        {
            p=new Search(pid[i],lid[i],quan[i]);
            searches.add(p);
        }

        return searches;
    }

}



