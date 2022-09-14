package com.example.android.warehouse.activity;

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
import android.widget.Toast;

import com.example.android.warehouse.R;

import java.io.IOError;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 * Created by DELL on 2/25/2018.
 */

public class WarehouseFragment extends Fragment {

    ConnectionClass connectionClass;
    String[]cname=new String[50];
    String[]comname=new String[50];
    String[]pno=new String[50];
    String[]address=new String[50];
    String[]email=new String[50];
    String[]web=new String[50];

    int addressm=0;

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_warehouse,null);
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

                        String commands = "SELECT * From dbo.Customer";
                        Statement stmt = con.createStatement();
                        ResultSet rs = stmt.executeQuery(commands);
                        while (rs.next()) {
                            cname[addressm] = rs.getString("c_name");
                            comname[addressm] = rs.getString("company_name");
                            pno[addressm] = rs.getString("phone_no");
                            address[addressm] = rs.getString("address");

                            if(rs.getString("email").equals(""))
                            {
                                email[addressm] = "NA";
                            }
                            else {
                                email[addressm] = rs.getString("email");
                            }

                            if(rs.getString("website").equals(""))
                            {
                                web[addressm] = "NA";
                            }
                            else {
                                web[addressm] = rs.getString("website");
                            }
                        //    web[addressm] = rs.getString("website");
  
                            addressm++;
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
                Log.d("sgll", r);

                Intent i = new Intent(getActivity(), CustomerActivity.class);
                Bundle extras = new Bundle();
                extras.putStringArray("cname", cname);
                extras.putStringArray("comname", comname);
                extras.putStringArray("pno", pno);
                extras.putStringArray("address", address);
                extras.putStringArray("email", email);
                extras.putStringArray("web", web);
                i.putExtras(extras);
                startActivity(i);
                //0   ((Activity) getActivity()).overridePendingTransition(0,0);

            }

        }


    }

