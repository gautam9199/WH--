package com.example.android.warehouse.activity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.AsyncTask;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentTransaction;
import android.util.AndroidRuntimeException;
import android.util.Log;
import android.view.View;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

import com.example.android.warehouse.R;

import java.io.IOError;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class OwnerMain extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {

    ConnectionClass connectionClass;

    //customer
    String[]cname=new String[50];
    String[]comname=new String[50];
    String[]pno=new String[50];
    String[]address=new String[50];
    String[]email=new String[50];
    String[]web=new String[50];
    int addressm=0;

    //product
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

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_owner_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        connectionClass = new ConnectionClass();
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.setDrawerListener(toggle);
        toggle.syncState();

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);

        SharedPreferences mPrefs = getSharedPreferences("IDvalue",0);
        String str = mPrefs.getString("mm", "");
        String user= mPrefs.getString("user", "");

        View hView =  navigationView.getHeaderView(0);
        TextView nav_user = (TextView)hView.findViewById(R.id.nav_user);
        nav_user.setText(user);

        if (str.equals("bb")){

            displaySelectedScreen(R.id.nav_war);
        }
        else if(str.equals("cc"))
        {
            displaySelectedScreen(R.id.nav_product);
        }
        else if(str.equals("dd"))
        {
            displaySelectedScreen(R.id.nav_sales);
        }
        else{
            displaySelectedScreen(R.id.nav_home);
        }
    }

    @Override
    public void onBackPressed() {
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.owner_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {

        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
//        if (id == R.id.action_settings) {
//            return true;
//        }

        return super.onOptionsItemSelected(item);
    }

    private void displaySelectedScreen(int id){
        Fragment fragment=null;

        if (id == R.id.nav_home) {
            fragment=new HomeFragment();

        } else if (id == R.id.nav_war) {
          //  fragment=new WarehouseFragment();
            DoCustomer doCus = new DoCustomer(); // this is the Asynctask
            doCus.execute("");

        } else if (id == R.id.nav_product) {
          //  fragment=new ProductFragment();
            DoProduct doPro = new DoProduct(); // this is the Asynctask
            doPro.execute("");

        } else if (id == R.id.nav_sales) {
            fragment=new SalesFragment();

        }  else if (id == R.id.nav_about_us) {
            fragment=new AboutUSFragment();

        }
        else if (id == R.id.nav_logout) {
//            SharedPreferences preferences = PreferenceManager.getDefaultSharedPreferences(OwnerMain.this);
//            SharedPreferences.Editor editor = preferences.edit();
            SharedPreferences mPrefs = getSharedPreferences("IDvalue", 0);
            SharedPreferences.Editor editor = mPrefs.edit();
            editor.clear();
            editor.commit();
            Intent i = new Intent(OwnerMain.this,LoginActivity.class);
            startActivity(i);

        }
        if(fragment!=null){

            FragmentManager fragmentManager=getSupportFragmentManager();
            FragmentTransaction ft=fragmentManager.beginTransaction();
            ft.replace(R.id.screen_area,fragment);
            ft.commit();
        }

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);

    }


    @SuppressWarnings("StatementWithEmptyBody")
    @Override
    public boolean onNavigationItemSelected(MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();

        displaySelectedScreen(id);

        return true;
    }

    public class DoCustomer extends AsyncTask<String,String,String>
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
            Intent i = new Intent(OwnerMain.this, CustomerActivity.class);
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

    public class DoProduct extends AsyncTask<String,String,String>
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

            Intent i = new Intent(OwnerMain.this, ProductActivity.class);
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
