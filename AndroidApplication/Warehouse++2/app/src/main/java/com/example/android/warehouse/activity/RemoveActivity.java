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

public class RemoveActivity extends AppCompatActivity implements  Detector.Processor{

    private TextView textView;
    private SurfaceView surfaceView;
    private BarcodeDetector barcodeDetector;
    private CameraSource cameraSource;
    private Button removeBut; //first button

    ArrayList<Object> qr = new ArrayList<Object>();
    String arrs="";


    ConnectionClass connectionClass;

    public void removeProduct(){

        textView = (TextView) this.findViewById(R.id.textView);
        surfaceView = (SurfaceView) this.findViewById(R.id.surfaceView);
        removeBut = (Button) this.findViewById(R.id.removeBut);

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
        setContentView(R.layout.activity_remove);

        removeProduct();

        removeBut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                removeBut.setVisibility(View.GONE);

                for (int i = 0; i < qr.size(); i++) {
                    for (int j = i + 1; j < qr.size(); j++) {
                        if (qr.get(i).equals(qr.get(j))) {
                            qr.remove(j);
                            j--;
                        }
                    }
                }
                for (Object n : qr) {
                    arrs+="\n"+String.valueOf(n);
                }

                RemoveQrLoc doLogin = new RemoveQrLoc(); // this is the Asynctask
                doLogin.execute("");

                textView.post(new Runnable() {
                    @Override
                    public void run() {
                        textView.setText(arrs);
                    }
                });

            }
        });
    }


    @Override
    public void release() {

    }

    @Override
    public void receiveDetections(Detector.Detections detections) {
        final SparseArray<Barcode> barcodes = detections.getDetectedItems();
        MediaPlayer ring = MediaPlayer.create(RemoveActivity.this, R.raw.bleep);

            if (barcodes.size() != 0) {
                ring.start();
                qr.add(barcodes.valueAt(0).rawValue);

            }
    }
    private class RemoveQrLoc extends AsyncTask<String, Void, String>
    {
        String msg,qrid,qid =  "";
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
                    Log.e("reached", "reched");

                    for (Object qrs : qr) {
                       // qid=String.valueOf(qrs);
                        qid="q7";
                        String query = "update dbo.qrGenerate SET qr_removed='yes' WHERE q_id='" + qid + "'";
                        Statement stmt = con.createStatement();
                        int u = stmt.executeUpdate(query);
                        if (u > 0) {
                            Log.e("updated", "updated");
                            msg = "Removed Successfully";
                        } else {
                            msg = "Data not found";
                        }
                    }
                }
            }

            catch (SQLException ex)
            {
                msg = ex.getMessage().toString();
                Log.d("seotoolzz1", msg);
            }
            catch (IOError ex)
            {
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
            Log.d("msg",msg);
            removeBut.setVisibility(View.GONE);

            SharedPreferences mPrefs = getSharedPreferences("IDvalue", 0);
            SharedPreferences.Editor editor = mPrefs.edit();
            editor.putString("mm","c" );
            editor.commit();
            Intent myIntent = new Intent(RemoveActivity.this, ManagerActivity.class);
            //   myIntent.putExtra("key", value); //Optional parameters
            RemoveActivity.this.startActivity(myIntent);

        }
    }

}
