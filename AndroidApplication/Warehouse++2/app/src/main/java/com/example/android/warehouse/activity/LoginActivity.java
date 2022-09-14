package com.example.android.warehouse.activity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.AsyncTask;
import android.preference.PreferenceManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.AndroidRuntimeException;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.Toast;

import java.io.IOError;
import java.security.acl.Owner;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import com.example.android.warehouse.R;

import manager.ManagerActivity;

public class LoginActivity extends AppCompatActivity {

    ConnectionClass connectionClass;
    EditText edtuserid,edtpass;
    Button btnlogin;
    ProgressBar pbbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        connectionClass = new ConnectionClass();//the class file
        edtuserid = (EditText) findViewById(R.id.uname);
        edtpass = (EditText) findViewById(R.id.pwd);
        btnlogin = (Button) findViewById(R.id.login_btn);
        pbbar = (ProgressBar) findViewById(R.id.progressBar);
        pbbar.setVisibility(View.GONE);

        btnlogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                DoLogin doLogin = new DoLogin(); // this is the Asynctask
                doLogin.execute("");

            }
        });
    }
    public class DoLogin extends AsyncTask<String,String,String>
    {
        String message = "";
        Boolean isSuccess = false;
        Boolean isSuccessM=false;

        String userid = edtuserid.getText().toString();
        String password = edtpass.getText().toString();

        @Override
        protected String doInBackground(String... params) {
            if(userid.trim().equals("")|| password.trim().equals(""))
                message = "Please enter User Id and Password";
            else
            {
                try {
                    Connection con = connectionClass.CONN();
                    if (con == null) {
                        message = "Error in connection with SQL server";
                    } else {
                        String query = "select * from dbo.Login where username='" + userid + "' and password='" + password + "'";
                        Statement stmt = con.createStatement();
                        ResultSet rs = stmt.executeQuery(query);

                        if(rs.next())
                        {
                            message = "Login Successfull " + userid;
                            if(rs.getString("userType").equals("Owner")){
                            isSuccess=true;
                            }
                            else if(rs.getString("userType").equals("Manager"))
                            {
                                isSuccessM=true;
                            }

                        }
                        else
                        {
                            message = "Invalid Credentials";
                            isSuccess = false;
                            isSuccessM=false;
                        }

                    }
                }
                catch (SQLException ex)
                {  isSuccess = false;
                    isSuccessM=false;
                    message = ex.getMessage().toString();
                    Log.d("seotoolzz", message);
                }
                catch (IOError ex)
                {  isSuccess = false;
                    isSuccessM=false;
                    // TODO: handle exception
                    message = ex.getMessage().toString();
                    Log.d("seotoolzz", message);
                }
                catch (AndroidRuntimeException ex)
                {   isSuccess = false;
                    isSuccessM=false;
                    message = ex.getMessage().toString();
                    Log.d("seotoolzz", message);
                }
                catch (NullPointerException ex)
                {   isSuccess = false;
                    isSuccessM=false;
                    message = ex.getMessage().toString();
                    Log.d("seotoolzz", message);
                }
                catch (Exception ex)
                {   isSuccess = false;
                    isSuccessM=false;
                    message = ex.getMessage().toString();
                    Log.d("seotoolzz", message);
                }
            }
            return message;
        }

        @Override
        protected void onPreExecute() {
            pbbar.setVisibility(View.VISIBLE);
        }

        @Override
        protected void onPostExecute(String r) {



            pbbar.setVisibility(View.GONE);
            Toast.makeText(LoginActivity.this, r, Toast.LENGTH_SHORT).show();

            if(isSuccess) {
                SharedPreferences mPrefs = getSharedPreferences("IDvalue", 0);
                SharedPreferences.Editor editor = mPrefs.edit();
                editor.putString("mm","aa" );
                editor.putString("user",edtuserid.getText().toString() );
                editor.putString("isLogin","true" );
                editor.commit();

                Toast.makeText(LoginActivity.this, r, Toast.LENGTH_SHORT).show();
                Intent myIntent = new Intent(LoginActivity.this, OwnerMain.class);
                LoginActivity.this.startActivity(myIntent);
            }
            if(isSuccessM) {
                SharedPreferences mPrefs = getSharedPreferences("IDvalue", 0);
                SharedPreferences.Editor editor = mPrefs.edit();
                editor.putString("mm","a" );
                editor.putString("user",edtuserid.getText().toString() );
                editor.putString("isLogin","true" );
                editor.commit();

                Toast.makeText(LoginActivity.this, r, Toast.LENGTH_SHORT).show();
                Intent myIntent = new Intent(LoginActivity.this, ManagerActivity.class);
                LoginActivity.this.startActivity(myIntent);
            }

        }

    }

}
