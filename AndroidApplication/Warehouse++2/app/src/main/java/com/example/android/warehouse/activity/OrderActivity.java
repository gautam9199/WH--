package com.example.android.warehouse.activity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.SearchView;

import com.example.android.warehouse.R;

import java.util.ArrayList;

public class OrderActivity extends AppCompatActivity {
    ConnectionClass connectionClass;
    ListView lv;
    SearchView sv;


    String[] coid2,dtime2,comname2,cname2,pq2;
    //String[] comname={"Juan Mata","ac","bcd","d"};
    int sizem=0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_order);

        Bundle extras = getIntent().getExtras();
        String coid3[] = extras.getStringArray("ocid1");
        String odtime3[] = extras.getStringArray("odtime1");
        String comname3[] = extras.getStringArray("ocomname1");
        String cname3[] = extras.getStringArray("ocname1");
        String pq3[] = extras.getStringArray("opq");

        for(int i=0;i<coid3.length;i++)
        {
            if(coid3[i]!=null) {
                sizem++;
            }
        }
        coid2=new String[sizem];
        dtime2=new String[sizem];
        comname2=new String[sizem];
        cname2=new String[sizem];
        pq2=new String[sizem];

        for(int i=0;i<coid3.length;i++)
        {
            if(coid3[i]!=null) {
                coid2[i]=coid3[i];
                dtime2[i]=odtime3[i];
                comname2[i]=comname3[i];
                cname2[i]=cname3[i];
                pq2[i]=pq3[i];
            }
        }

        lv=(ListView) findViewById(R.id.listView2o);
        sv=(SearchView) findViewById(R.id.searchView2o);

        //ADASPTER
        final Adapter_order adapter=new Adapter_order(this, getorders());
        lv.setAdapter(adapter);

        sv.setOnQueryTextListener(new SearchView.OnQueryTextListener() {

            @Override
            public boolean onQueryTextSubmit(String arg0) {
                // TODO Auto-genewebd method stub
                return false;
            }

            @Override
            public boolean onQueryTextChange(String query) {
                // TODO Auto-genewebd method stub

                adapter.getFilter().filter(query);

                return false;
            }
        });

    }

    @Override
    public void onBackPressed() {
        SharedPreferences mPrefs = getSharedPreferences("IDvalue", 0);
        SharedPreferences.Editor editor = mPrefs.edit();
        editor.putString("mm","ee" );
        editor.commit();
        Intent myIntent = new Intent(OrderActivity.this, OwnerMain.class);
        startActivity(myIntent);
    }

    private ArrayList<Order> getorders()
    {
        ArrayList<Order> orders=new ArrayList<Order>();
       Order p;

        for(int i=0;i<coid2.length;i++)
        {
            p=new Order(coid2[i],dtime2[i],comname2[i],cname2[i],pq2[i]);
            orders.add(p);
        }

        return orders;
    }

}



