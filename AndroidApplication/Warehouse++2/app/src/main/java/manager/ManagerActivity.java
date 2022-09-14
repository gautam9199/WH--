package manager;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.AsyncTask;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentTransaction;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.AndroidRuntimeException;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.TextView;

import com.example.android.warehouse.R;
import com.example.android.warehouse.activity.AboutUSFragment;
import com.example.android.warehouse.activity.ConnectionClass;
import com.example.android.warehouse.activity.LoginActivity;
import com.example.android.warehouse.activity.OwnerMain;
import com.example.android.warehouse.activity.ProductFragment;
import com.example.android.warehouse.activity.SearchActivity;
import com.example.android.warehouse.activity.SettingsFragment;
import com.example.android.warehouse.activity.WarehouseFragment;

import java.io.IOError;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class ManagerActivity extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {

//   public Boolean isAdd=false;
    ConnectionClass connectionClass;

    //search fragment
    String[]  product = new String[50];
    String[]  location =new String[50];
    String[] quantity = new String[50];
    int size=0;
    String dpid,dloc,dquan="";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_manager);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.setDrawerListener(toggle);
        toggle.syncState();

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);

        connectionClass = new ConnectionClass();

        SharedPreferences mPrefs = getSharedPreferences("IDvalue",0);
        String str = mPrefs.getString("mm", "");
        String user= mPrefs.getString("user", "");

        View hView =  navigationView.getHeaderView(0);
        TextView nav_user = (TextView)hView.findViewById(R.id.nav_user);
        nav_user.setText(user);


        if (str.equals("b")){

            displaySelectedScreen1(R.id.nav_add);
        }
        else if(str.equals("c"))
        {
            displaySelectedScreen1(R.id.nav_Remove);
        }
        else if(str.equals("d"))
        {
            displaySelectedScreen1(R.id.nav_search);
        }
        else{
            displaySelectedScreen1(R.id.nav_home1);
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
        getMenuInflater().inflate(R.menu.manager, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
//        if (id == R.id.action_settings) {
//            return true;
//        }

        return super.onOptionsItemSelected(item);
    }

    public void displaySelectedScreen1(int id){

        Fragment fragment=null;

        if (id == R.id.nav_home1) {
            fragment=new Home1Fragment();

        } else if (id == R.id.nav_add) {
            fragment=new AddFragment();

        } else if (id == R.id.nav_Remove) {
            fragment=new RemoveFragment();

        } else if (id == R.id.nav_search) {
           // fragment=new SearchFragment();
            DoSearch doSearch = new DoSearch(); // this is the Asynctask
            doSearch.execute("");
        }

        else if (id == R.id.nav_about_us) {
            fragment=new AboutUSFragment();
        }else if (id == R.id.nav_logout1) {
//            SharedPreferences preferences = PreferenceManager.getDefaultSharedPreferences(ManagerActivity.this);
//            SharedPreferences.Editor editor = preferences.edit();
            SharedPreferences mPrefs = getSharedPreferences("IDvalue", 0);
            SharedPreferences.Editor editor = mPrefs.edit();
            editor.clear();
            editor.commit();
            Intent i = new Intent(ManagerActivity.this,LoginActivity.class);
            startActivity(i);

        }
        if(fragment!=null){

            FragmentManager fragmentManager=getSupportFragmentManager();
            FragmentTransaction ft=fragmentManager.beginTransaction();
            ft.replace(R.id.screen_area1,fragment);
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

        displaySelectedScreen1(id);

        return true;
    }

    public class DoSearch extends AsyncTask<String,String,String>
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

            Intent i = new Intent(ManagerActivity.this, SearchActivity.class);
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
