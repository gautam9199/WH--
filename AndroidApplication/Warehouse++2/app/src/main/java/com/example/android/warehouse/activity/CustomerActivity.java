package com.example.android.warehouse.activity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.SearchView;

import com.example.android.warehouse.R;

import java.util.ArrayList;

public class CustomerActivity extends AppCompatActivity {
    ConnectionClass connectionClass;
    ListView lv;
    SearchView sv;


    String[] cname,comname,pno,address,email,web;
    //String[] comname={"Juan Mata","ac","bcd","d"};
    int sizem=0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_customer);

        Bundle extras = getIntent().getExtras();
        String cname1[] = extras.getStringArray("cname");
        String comname1[] = extras.getStringArray("comname");
        String pno1[] = extras.getStringArray("pno");
        String address1[] = extras.getStringArray("address");
        String email1[] = extras.getStringArray("email");
        String web1[] = extras.getStringArray("web");


        for(int i=0;i<cname1.length;i++)
        {
            if(cname1[i]!=null) {
                sizem++;
            }
        }
        cname=new String[sizem];
        comname=new String[sizem];
        pno=new String[sizem];
        address=new String[sizem];
        email=new String[sizem];
        web=new String[sizem];

        for(int i=0;i<cname1.length;i++)
        {
            if(cname1[i]!=null) {
                cname[i]=cname1[i];
                comname[i]=comname1[i];
                pno[i]=pno1[i];
                address[i]=address1[i];
                email[i]=email1[i];
                web[i]=web1[i];
            }
        }

        lv=(ListView) findViewById(R.id.listView3s);
        sv=(SearchView) findViewById(R.id.searchView3s);

        //ADASPTER
        final Adapter_customer adapter=new Adapter_customer(this, getcustomers());
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
        Intent myIntent = new Intent(CustomerActivity.this, OwnerMain.class);
        startActivity(myIntent);
    }

    private ArrayList<Customer> getcustomers()
    {
        ArrayList<Customer> customers=new ArrayList<Customer>();
        Customer p;

        for(int i=0;i<cname.length;i++)
        {
            p=new Customer(cname[i],comname[i],pno[i],address[i],email[i],web[i]);
            customers.add(p);
        }

        return customers;
    }

}



