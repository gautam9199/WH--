package manager;

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

import com.example.android.warehouse.R;
import com.example.android.warehouse.activity.LoginActivity;
import com.example.android.warehouse.activity.OwnerMain;

/**
 * Created by DELL on 2/25/2018.
 */

public class Home1Fragment extends Fragment {

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_home1,null);
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);
        view.findViewById(R.id.add).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
//                Fragment  fragment=new AddFragment();
//                FragmentManager fragmentManager=getActivity().getSupportFragmentManager();
//                FragmentTransaction ft=fragmentManager.beginTransaction();
//                ft.replace(R.id.screen_area1,fragment);
//                ft.commit();
                SharedPreferences mPrefs = getActivity().getSharedPreferences("IDvalue", 0);
                SharedPreferences.Editor editor = mPrefs.edit();
                editor.putString("mm","b" );
                editor.commit();
                Intent myIntent = new Intent(getActivity(), ManagerActivity.class);
                startActivity(myIntent);

            }
        });

        view.findViewById(R.id.remove).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                SharedPreferences mPrefs = getActivity().getSharedPreferences("IDvalue", 0);
                SharedPreferences.Editor editor = mPrefs.edit();
                editor.putString("mm","c" );
                editor.commit();
                Intent myIntent = new Intent(getActivity(), ManagerActivity.class);
                startActivity(myIntent);

            }
        });

        view.findViewById(R.id.search).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                SharedPreferences mPrefs = getActivity().getSharedPreferences("IDvalue", 0);
                SharedPreferences.Editor editor = mPrefs.edit();
                editor.putString("mm","d" );
                editor.commit();
                Intent myIntent = new Intent(getActivity(), ManagerActivity.class);
                startActivity(myIntent);

            }
        });
    }
}
