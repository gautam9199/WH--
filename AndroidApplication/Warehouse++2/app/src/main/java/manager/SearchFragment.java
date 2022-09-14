package manager;

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

import com.example.android.warehouse.R;
import com.example.android.warehouse.activity.ConnectionClass;
import com.example.android.warehouse.activity.SearchActivity;

import java.io.IOError;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 * Created by DELL on 2/25/2018.
 */

public class SearchFragment extends Fragment {

    ConnectionClass connectionClass;
    String[]  product = new String[50];
    String[]  location =new String[50];
    String[] quantity = new String[50];
    int size=0;
    String dpid,dloc,dquan="";

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_search,null);
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);
//        view.findViewById(R.id.test).setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                Intent i = new Intent(getActivity(), SearchActivity.class);
//                startActivity(i);
//            }
//        });
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
                    Log.e("reched","reach");
                    String commands1 = "SELECT DISTINCT p_id From dbo.qrGenerate where qr_scanned='yes' and qr_removed='no'";
                    Statement stmt1 = con.createStatement();
                    ResultSet rs1 = stmt1.executeQuery(commands1);
                    while (rs1.next()) {
                        Log.e("pro11",rs1.getString("p_id"));
                        dpid=rs1.getString("p_id");

                        String commands2 = "SELECT DISTINCT l_id From dbo.qrGenerate where p_id='"+dpid+"' and qr_scanned='yes' and qr_removed='no'";
                        Statement stmt2 = con.createStatement();
                        ResultSet rs2 = stmt2.executeQuery(commands2);
                        while(rs2.next())
                        {
                            Log.e("loc11",rs2.getString("l_id"));
                            dloc=rs2.getString("l_id");

                            String commands3 = "SELECT COUNT(Id) AS total From dbo.qrGenerate where p_id='"+dpid+"' and l_id='"+dloc+"'";
                            Statement stmt3 = con.createStatement();
                            ResultSet rs3 = stmt3.executeQuery(commands3);
                            while(rs3.next())
                            {
                                product[size]=dpid;
                                location[size]=dloc;
                                quantity[size]=String.valueOf(rs3.getInt("total"));
                                Log.e("quant11",String.valueOf(rs3.getInt("total")));
                                size++;

                            }
                        }

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

            Intent i = new Intent(getActivity(), SearchActivity.class);
            Bundle extras = new Bundle();

            extras.putStringArray("piid",product);
            extras.putStringArray("liid",location);
            extras.putStringArray("quann",quantity);
            i.putExtras(extras);
            startActivity(i);
               //((Activity) getActivity()).overridePendingTransition(0,0);

        }

    }


}
