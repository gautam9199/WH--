package com.example.android.warehouse.activity;

import android.Manifest;
import android.app.Activity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.pm.PackageManager;
import android.media.MediaPlayer;
import android.os.AsyncTask;
import android.support.v4.app.ActivityCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.AndroidRuntimeException;
import android.util.Log;
import android.util.SparseArray;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.example.android.warehouse.R;
import com.google.android.gms.vision.CameraSource;
import com.google.android.gms.vision.Detector;
import com.google.android.gms.vision.barcode.Barcode;
import com.google.android.gms.vision.barcode.BarcodeDetector;

import java.io.IOError;
import java.io.IOException;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import manager.ManagerActivity;

public class AddActivity extends AppCompatActivity  implements  Detector.Processor {


    private TextView textView;
    private SurfaceView surfaceView;
    private BarcodeDetector barcodeDetector;
    private CameraSource cameraSource;
    private Button addLoc; //first button
    private Button addQr,updateLoc,cancelUpdateLoc;
    Boolean locAdded = false;
    Boolean isChange = false;
    Boolean isFinish=false;
    Boolean callMethod=false;
    String loc;
    String arrs, currQr = "";
    int ulci=0;
    ArrayList<Object> qr = new ArrayList<Object>();
    ArrayList<Object> qrupdate = new ArrayList<Object>();
    ArrayList<Object> oldloc = new ArrayList<Object>();
    ConnectionClass connectionClass;
    // Session Manager Class

    public void addproduct() {
        textView = (TextView) this.findViewById(R.id.textView);
        surfaceView = (SurfaceView) this.findViewById(R.id.surfaceView);
        addLoc = (Button) this.findViewById(R.id.addLoc);
        addQr = (Button) this.findViewById(R.id.addQr);
        updateLoc=(Button) this.findViewById(R.id.updateLoc);
        cancelUpdateLoc=(Button) this.findViewById(R.id.cancelUpdateLoc);

        connectionClass = new ConnectionClass();//the class file

        barcodeDetector = new BarcodeDetector.Builder(this).setBarcodeFormats(Barcode.ALL_FORMATS).build();
        barcodeDetector.setProcessor(this);

        cameraSource = new CameraSource.Builder(getApplicationContext(), barcodeDetector).
                setRequestedPreviewSize(1024, 768).setAutoFocusEnabled(true)
                .build();

        final Activity activity = this;

        surfaceView.getHolder().addCallback(new SurfaceHolder.Callback() {
            @Override
            public void surfaceCreated(SurfaceHolder holder) {
                try {
                    if (ActivityCompat.checkSelfPermission(getApplicationContext(), Manifest.permission.CAMERA) != PackageManager.PERMISSION_GRANTED) {
                        ActivityCompat.requestPermissions(activity, new String[]{Manifest.permission.CAMERA}, 1024);
                        return;
                    }
                    cameraSource.start(surfaceView.getHolder());
                } catch (IOException ie) {
                    Log.e("Camera start problem", ie.getMessage());
                }
            }

            @Override
            public void surfaceChanged(SurfaceHolder holder, int format, int width, int height) {

            }

            @Override
            public void surfaceDestroyed(SurfaceHolder holder) {
                cameraSource.stop();
            }
        });

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add);
        addproduct();

        addLoc.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                locAdded = true;
                addLoc.setVisibility(View.GONE);
                addQr.setVisibility(View.VISIBLE);
                textView.post(new Runnable() {
                    @Override
                    public void run() {
                        textView.setText(loc);
                    }
                });
            }
        });
        addQr.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                addQr.setVisibility(View.GONE);

                for (int i = 0; i < qr.size(); i++) {
                    for (int j = i + 1; j < qr.size(); j++) {
                        if (qr.get(i).equals(qr.get(j))) {
                            qr.remove(j);
                            j--;
                        }
                    }
                }
                arrs="loc: "+loc;
                for (Object n : qr) {
                   arrs+="\n"+String.valueOf(n);
                }

                AddQrLoc doLogin = new AddQrLoc(); // this is the Asynctask
                doLogin.execute("");

                textView.post(new Runnable() {
                    @Override
                    public void run() {
                        textView.setText("");
                        textView.setText(arrs);


                    }
                });

            }
        });
        updateLoc.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Log.e("btclick","bt");
                    UpdateQrLoc doupdate = new  UpdateQrLoc(); // this is the Asynctask
                    doupdate.execute("");

                }
            });
        cancelUpdateLoc.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                updateLoc.setVisibility(View.GONE);
                cancelUpdateLoc.setVisibility(View.GONE);
                updateLocData();

            }
        });


    }

    public void updateLocData(){

      //  String ulci1=
        Log.e("ulci",String.valueOf(ulci));
        Log.e("size",String.valueOf(qrupdate.size()));
        if(ulci<qrupdate.size()) {

                updateLoc.setVisibility(View.VISIBLE);
                cancelUpdateLoc.setVisibility(View.VISIBLE);
                final String showMsg = "The qr id \"" + qrupdate.get(ulci).toString() + "\" is already added to " +
                        oldloc.get(ulci).toString() + "\n" + "Do you want to update its location to " + loc;

                currQr = qrupdate.get(ulci).toString();

                textView.post(new Runnable() {
                    @Override
                    public void run() {
                        textView.setText(showMsg);
                    }
                });
            ulci++;
        }
        else{
//            textView.post(new Runnable() {
//                @Override
//                public void run() {
//                    textView.setText("data to update over");
//                }
//            });

            SharedPreferences mPrefs = getSharedPreferences("IDvalue", 0);
            SharedPreferences.Editor editor = mPrefs.edit();
            editor.putString("mm","b" );
            editor.commit();
            Intent myIntent = new Intent(AddActivity.this, ManagerActivity.class);
            //   myIntent.putExtra("key", value); //Optional parameters
            AddActivity.this.startActivity(myIntent);

        }
    }


    @Override
    public void release() {

    }


    @Override
    public void receiveDetections(Detector.Detections detections) {
        final SparseArray<Barcode> barcodes = detections.getDetectedItems();
        MediaPlayer ring = MediaPlayer.create(AddActivity.this, R.raw.bleep);

        if (!locAdded) {
            if (barcodes.size() != 0) {
                ring.start();
                loc = barcodes.valueAt(0).rawValue;
            }
        } else {

            if (barcodes.size() != 0) {
                ring.start();
                  qr.add(barcodes.valueAt(0).rawValue);

            }
        }
    }


    private class AddQrLoc extends AsyncTask<String, Void, String>
    {
        String msg,qid,l_id11=  "";
        ResultSet rs;

        @Override
        protected void onPreExecute()
        {
        }

        @Override
        protected String doInBackground(String... params)
        {

            try {
                Connection con = connectionClass.CONN();
                if (con == null) {
                    msg = "Error in connection with SQL server";
                } else {
                    for (Object qrs : qr) {
                       qid=String.valueOf(qrs);
                        qid=qid.replaceAll("\\s","");
                        int qi=qid.lastIndexOf("q");
                        qid=qid.substring(qi,qid.length()-3);

                        if (!(qid.equals(""))) {
                            Log.e("qid", "q7");
                            String query1 = "select * from dbo.qrGenerate where q_id='" + qid + "'";
                            Statement stmt1 = con.createStatement();
                            rs = stmt1.executeQuery(query1);
                            if (rs.next()) {

                                 l_id11 = rs.getString("l_id").replaceAll("\\s", ""); //removing all white spaces
                                if (l_id11.equals("")) {

                                    String query2 = "update dbo.qrGenerate SET l_id='"+loc+"' , qr_scanned='yes' WHERE q_id='" + qid + "'";
                                    Statement stmt2 = con.createStatement();
                                    int u = stmt2.executeUpdate(query2);
                                    if (u > 0) {

                                        msg = "Updated Successfully";
                                    } else {
                                        msg = "Data not found";
                                    }
                                }
                                else{
                                    Log.e("else", "else");
                                    if (!(loc.equals(l_id11))) {
                                        Log.e("qid11", qid);
                                        Log.e("lid11", l_id11);
                                        qrupdate.add(qid);
                                        oldloc.add(l_id11);
                                        isChange = true;
                                        msg = "aajja";
                                    }
                                    else{

                                        msg="nj";
                                    }

                                }
                            }

                        }
                    }
                }
            }
            // Catching all the exceptions
            catch (SQLException ex)
            {
                msg = ex.getMessage().toString();
                Log.d("seotoolzz1", msg);
            }
            catch (IOError ex)
            {
                // TODO: handle exception
                msg = ex.getMessage().toString();
                Log.d("seotoolzz2", msg);
            }
            catch (AndroidRuntimeException ex)
            {
                msg = ex.getMessage().toString();
                Log.d("seotoolzz3", msg);
            }
            catch (NullPointerException ex)
            {
                msg = ex.getMessage().toString();
                Log.d("seotoolzz4", msg);
            }
            catch (Exception ex)
            {
                msg = ex.getMessage().toString();
                Log.d("seotoolzz5", msg);
            }
            return msg;
        }

        @Override
        protected void onPostExecute(String msg)
        {
            Log.e("msg",msg);

            if(isChange){
                    Log.e("errorrr","errorrr");
                Log.e("ulci",String.valueOf(ulci));
                Log.e("size",String.valueOf(qrupdate.size()));
                updateLocData();

            }
            else{
                try {
                    SharedPreferences mPrefs = getSharedPreferences("IDvalue", 0);
                    SharedPreferences.Editor editor = mPrefs.edit();
                    editor.putString("mm","b" );
                    editor.commit();
                    Intent myIntent = new Intent(AddActivity.this, ManagerActivity.class);
                    //   myIntent.putExtra("key", value); //Optional parameters
                   AddActivity.this.startActivity(myIntent);
                }

                catch (Exception ex)
                {
                    Log.e("Exce1",ex.getMessage().toString());
                }
            }

        }
    }


    private class UpdateQrLoc extends AsyncTask<String, Void, String>
    {
        String msg =  "";
        ResultSet rs;

        @Override
        protected void onPreExecute()
        {
        }

        @Override
        protected String doInBackground(String... params)
        {

            try {
                Connection con = connectionClass.CONN();
                if (con == null) {
                    msg = "Error in connection with SQL server";
                } else {
                        Log.e("reached","reched");
                      String query11 = "update dbo.qrGenerate SET l_id='"+loc+"' WHERE q_id='" + currQr + "'";
                      Statement stmt11 = con.createStatement();
                      int u = stmt11.executeUpdate(query11);
                      if (u > 0) {
                          Log.e("updated","updated");
                          msg = "Retrieved Successfully11";
                          } else {
                           msg = "Image not Found in the Database";
                           }
                }
            }
            // Catching all the exceptions
            catch (SQLException ex)
            {
                msg = ex.getMessage().toString();
                Log.e("seotoolzz1", msg);
            }
            catch (IOError ex)
            {
                // TODO: handle exception
                msg = ex.getMessage().toString();
                Log.e("seotoolzz2", msg);
            }
            catch (AndroidRuntimeException ex)
            {
                msg = ex.getMessage().toString();
                Log.e("seotoolzz3", msg);
            }
            catch (NullPointerException ex)
            {
                msg = ex.getMessage().toString();
                Log.e("seotoolzz4", msg);
            }
            catch (Exception ex)
            {
                msg = ex.getMessage().toString();
                Log.e("seotoolzz5", msg);
            }
            return msg;
        }

        @Override
        protected void onPostExecute(String msg)
        {
            Log.e("msg1",msg);
            updateLoc.setVisibility(View.GONE);
            cancelUpdateLoc.setVisibility(View.GONE);
            updateLocData();

        }
    }
}

