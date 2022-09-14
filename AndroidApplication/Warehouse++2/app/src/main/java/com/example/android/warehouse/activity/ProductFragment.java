package com.example.android.warehouse.activity;

import android.app.Activity;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.util.AndroidRuntimeException;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListView;
import android.widget.SearchView;
import android.widget.Toast;

import com.example.android.warehouse.R;

import java.io.IOError;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

/**
 * Created by DELL on 2/25/2018.
 */

public class ProductFragment extends Fragment {

    ConnectionClass connectionClass;
    String[]pid=new String[50];
    String[]mNo=new String[50];
    String[]type=new String[50];
    String[]size=new String[50];
    String[]finish=new String[50];
    String[]rate=new String[50];
    String[]bsize=new String[50];
    String[]pbq=new String[50];
    String[]total=new String[50];

    int sizem=0;

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
       // setHasOptionsMenu(true);
        return inflater.inflate(R.layout.fragment_product, null);
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);

        connectionClass = new ConnectionClass();//the class file

       DoLogin doLogin = new DoLogin(); // this is the Asynctask
        doLogin.execute("");

    }
    public class DoLogin extends AsyncTask<String,String,String>
    {
        String msg = "";

        @Override
        protected String doInBackground(String... params) {
            try {

                Connection con = connectionClass.CONN();
                if (con == null) {
                    msg = "Error in connection with SQL server";
                } else {

                    String commands = "SELECT * From dbo.Product";
                    Statement stmt = con.createStatement();
                    ResultSet rs = stmt.executeQuery(commands);
                    while (rs.next()) {
                        pid[sizem] = rs.getString("p_id");
                        mNo[sizem] = rs.getString("model_no");
                        type[sizem] = rs.getString("type");
                        size[sizem] = rs.getString("size_id");
                        finish[sizem] = rs.getString("finish_id");
                        rate[sizem] = Integer.toString(rs.getInt("rate"));
                        bsize[sizem] = rs.getString("box_Size");
                        pbq[sizem] = Integer.toString(rs.getInt("per_box_quantity"));
                        total[sizem] = Integer.toString(rs.getInt("total_quantity"));
                        sizem++;
                        msg = "Retrieved Successfully";
                    }
                }
            }
            // Catching all the exceptions
            catch (SQLException ex)
            {
                msg = ex.getMessage().toString();
                Log.d("seotoolzz", msg);
            }
            catch (IOError ex)
            {
                // TODO: handle exception
                msg = ex.getMessage().toString();
                Log.d("seotoolzz", msg);
            }
            catch (AndroidRuntimeException ex)
            {
                msg = ex.getMessage().toString();
                Log.d("seotoolzz", msg);
            }
            catch (NullPointerException ex)
            {
                msg = ex.getMessage().toString();
                Log.d("seotoolzz", msg);
            }
            catch (Exception ex)
            {
                msg = ex.getMessage().toString();
                Log.d("seotoolzz", msg);
            }
            return msg;
        }

        @Override
        protected void onPreExecute() {
        }

        @Override
        protected void onPostExecute(String r) {
            Log.d("sg",r);

            Intent i = new Intent(getActivity(), ProductActivity.class);
            Bundle extras = new Bundle();
            extras.putStringArray("pid",pid);
            extras.putStringArray("mNo",mNo);
            extras.putStringArray("type",type);
            extras.putStringArray("size",size);
            extras.putStringArray("finish",finish);
            extras.putStringArray("rate",rate);
            extras.putStringArray("bsize",bsize);
            extras.putStringArray("pbq",pbq);
            extras.putStringArray("total",total);
            i.putExtras(extras);
            startActivity(i);
     //0   ((Activity) getActivity()).overridePendingTransition(0,0);

            }

        }


}

