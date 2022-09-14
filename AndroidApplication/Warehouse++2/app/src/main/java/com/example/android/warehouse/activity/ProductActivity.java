package com.example.android.warehouse.activity;

import java.util.ArrayList;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.ListView;
import android.widget.SearchView;
import android.widget.SearchView.OnQueryTextListener;

import com.example.android.warehouse.R;

import manager.ManagerActivity;

public class ProductActivity extends AppCompatActivity {

    ConnectionClass connectionClass;
    ListView lv;
    SearchView sv;


    String[] pid,mNo,type,size,finish,rate,bsize,pbq,total;
    //String[] mNo={"Juan Mata","ac","bcd","d"};
       int sizem=0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_product);

        Bundle extras = getIntent().getExtras();
        String pid1[] = extras.getStringArray("pid");
        String mNo1[] = extras.getStringArray("mNo");
        String type1[] = extras.getStringArray("type");
        String size1[] = extras.getStringArray("size");
        String finish1[] = extras.getStringArray("finish");
        String rate1[] = extras.getStringArray("rate");
        String bsize1[] = extras.getStringArray("bsize");
        String pbq1[] = extras.getStringArray("pbq");
        String total1[] = extras.getStringArray("total");


        for(int i=0;i<pid1.length;i++)
        {
            if(pid1[i]!=null) {
                sizem++;
            }
        }
        pid=new String[sizem];
        mNo=new String[sizem];
        type=new String[sizem];
        size=new String[sizem];
        finish=new String[sizem];
        rate=new String[sizem];
        bsize=new String[sizem];
        pbq=new String[sizem];
        total=new String[sizem];

        for(int i=0;i<pid1.length;i++)
        {
            if(pid1[i]!=null) {
                pid[i]=pid1[i];
                mNo[i]=mNo1[i];
               type[i]=type1[i];
                size[i]=size1[i];
                finish[i]=finish1[i];
                rate[i]=rate1[i];
                bsize[i]=bsize1[i];
                pbq[i]=pbq1[i];
                total[i]=total1[i];
            }
        }

        lv=(ListView) findViewById(R.id.listView1);
        sv=(SearchView) findViewById(R.id.searchView1);

        //ADASPTER
        final Adapter_product adapter=new Adapter_product(this, getProducts());
        lv.setAdapter(adapter);

        sv.setOnQueryTextListener(new OnQueryTextListener() {

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
        editor.putString("mm","ee" );
        editor.commit();
        Intent myIntent = new Intent(ProductActivity.this, OwnerMain.class);
        startActivity(myIntent);
    }
    private ArrayList<Product> getProducts()
    {
        ArrayList<Product> products=new ArrayList<Product>();
        Product p;

        for(int i=0;i<pid.length;i++)
        {
            p=new Product(pid[i],mNo[i],type[i],size[i],finish[i],rate[i],bsize[i],pbq[i],total[i]);
            products.add(p);
        }

        return products;
    }

}



