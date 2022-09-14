package com.example.android.warehouse.activity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentTransaction;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import com.example.android.warehouse.R;

import manager.ManagerActivity;

/**
 * Created by DELL on 2/25/2018.
 */

public class HomeFragment extends Fragment {


    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_home,null);
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);
        view.findViewById(R.id.product).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                SharedPreferences mPrefs = getActivity().getSharedPreferences("IDvalue", 0);
                SharedPreferences.Editor editor = mPrefs.edit();
                editor.putString("mm","cc" );
                editor.commit();
                Intent myIntent = new Intent(getActivity(), OwnerMain.class);
                startActivity(myIntent);
            }
        });
        view.findViewById(R.id.war).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                SharedPreferences mPrefs = getActivity().getSharedPreferences("IDvalue", 0);
                SharedPreferences.Editor editor = mPrefs.edit();
                editor.putString("mm","bb" );
                editor.commit();
                Intent myIntent = new Intent(getActivity(), OwnerMain.class);
                startActivity(myIntent);
            }
        });
        view.findViewById(R.id.sales).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                SharedPreferences mPrefs = getActivity().getSharedPreferences("IDvalue", 0);
                SharedPreferences.Editor editor = mPrefs.edit();
                editor.putString("mm","dd" );
                editor.commit();
                Intent myIntent = new Intent(getActivity(), OwnerMain.class);
                startActivity(myIntent);
            }
        });
    }


}
