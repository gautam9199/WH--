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

public class SalesFragment extends Fragment {

    ConnectionClass connectionClass;
    String[] ocname=new String[50];
    String[] ocomname=new String[50];
    String[] odtime=new String[50];
    String[] opid=new String[50];
    String[] oco_id=new String[50];
   // String[]web=new String[50];

    int oaddressm=0;
    String coid,dtime,proquan,ocid,oocname,oocom="";
    int icoid,iocid;


    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_sales,null);
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);
        connectionClass = new ConnectionClass();//the class file

        Orderd doO = new Orderd(); // this is the Asynctask
        doO.execute("");
    }
    public class Orderd extends AsyncTask<String,String,String>
    {
        String msg = "";

        @Override
        protected String doInBackground(String... params) {
            try {

                Connection con = connectionClass.CONN();
                if (con == null) {
                    msg = "Error in connection with SQL server";
                } else {
                    Log.e("reched","reach");
                    String commands1 = "SELECT DISTINCT co_id From dbo.Order1";
                    Statement stmt1 = con.createStatement();
                    ResultSet rs1 = stmt1.executeQuery(commands1);
                    while (rs1.next()) {
                        Log.e("pro11",rs1.getString("co_id"));
                        coid=String.valueOf(rs1.getInt("co_id"));

                        icoid=rs1.getInt("co_id");

                        String commands2 = "SELECT * From dbo.Order1 where co_id='"+icoid+"' ";
                        Statement stmt2 = con.createStatement();
                        ResultSet rs2 = stmt2.executeQuery(commands2);
                        proquan="";
                        while(rs2.next())
                        {
                            Log.e("date",rs2.getString("date_time").toString());
                            dtime=rs2.getDate("date_time").toString();
                            ocid= String.valueOf(rs2.getInt("c_id"));
                            iocid=rs2.getInt("c_id");
                            Log.e("loc11",rs2.getString("p_id"));
                            proquan+=rs2.getString("p_id").toString().trim()+"---"+rs2.getString("quanity")+"\n";


                        }

                        String commands3 = "SELECT * From dbo.Customer where c_id='"+iocid+"'";
                        Statement stmt3 = con.createStatement();
                        ResultSet rs3 = stmt3.executeQuery(commands3);
                        if(rs3.next())
                        {
                            oocname=rs3.getString("c_name");
                            oocom=rs3.getString("company_name");
                        }

                        Log.e("date11",proquan);
                        Log.e("date22",oocname);
                        opid[oaddressm]=proquan;
                        odtime[oaddressm]=dtime;
                        ocname[oaddressm]=oocom;
                        ocomname[oaddressm]=oocname;
                        oco_id[oaddressm]=coid;
//                        quantity[size]=String.valueOf(rs3.getInt("total"));
//                        Log.e("quant11",String.valueOf(rs3.getInt("total")));
                        oaddressm++;


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

            Intent i = new Intent(getActivity(), OrderActivity.class);
            Bundle extras = new Bundle();
            extras.putStringArray("ocid1", oco_id);
            extras.putStringArray("odtime1", odtime);
            extras.putStringArray("ocomname1", ocomname);
            extras.putStringArray("ocname1", ocname);
            extras.putStringArray("opq", opid);
            i.putExtras(extras);
            startActivity(i);
            //0   ((Activity) getActivity()).overridePendingTransition(0,0);

        }

    }
}
