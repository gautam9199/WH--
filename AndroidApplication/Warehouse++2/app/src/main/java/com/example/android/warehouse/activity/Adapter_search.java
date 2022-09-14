package com.example.android.warehouse.activity;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Filter;
import android.widget.Filterable;
import android.widget.TextView;
import android.widget.BaseAdapter;

import com.example.android.warehouse.R;

import java.util.ArrayList;

/**
 * Created by DELL on 3/29/2018.
 */

public class Adapter_search extends BaseAdapter implements Filterable {

    Context c;
    ArrayList<Search> searches;
    Adapter_search.CustomFilter filter;
    ArrayList<Search> filterList;

    public Adapter_search(Context ctx, ArrayList<Search> searches) {
        // TODO Auto-generated constructor stub

        this.c=ctx;
        this.searches=searches;
        this.filterList=searches;
    }

    @Override
    public int getCount() {
        // TODO Auto-generated method stub
        return searches.size();
    }

    @Override
    public Object getItem(int pos) {
        // TODO Auto-generated method stub
        return searches.get(pos);
    }

    @Override
    public long getItemId(int pos) {
        // TODO Auto-generated method stub
        return searches.indexOf(getItem(pos));
    }

    @Override
    public View getView(int pos, View convertView, ViewGroup parent) {
        // TODO Auto-generated method stub

        LayoutInflater inflater=(LayoutInflater) c.getSystemService(Context.LAYOUT_INFLATER_SERVICE);

        if(convertView==null)
        {
            convertView=inflater.inflate(R.layout.model_searchlist, null);
        }

        TextView pidTxt=(TextView) convertView.findViewById(R.id.pids);
        TextView lidTxt=(TextView) convertView.findViewById(R.id.lids);
        TextView quanTxt=(TextView) convertView.findViewById(R.id.quans);

        //SET DATA TO THEM
        pidTxt.setText(searches.get(pos).getPid());
        lidTxt.setText(searches.get(pos).getLid());
        quanTxt.setText(searches.get(pos).getQuan());

        return convertView;
    }

    @Override
    public Filter getFilter() {
        // TODO Auto-generated method stub
        if(filter == null)
        {
            filter=new Adapter_search.CustomFilter();
        }

        return filter;
    }

    //INNER CLASS
    class CustomFilter extends Filter
    {

        @Override
        protected FilterResults performFiltering(CharSequence constraint) {
            // TODO Auto-generated method stub

            FilterResults results=new FilterResults();

            if(constraint != null && constraint.length()>0)
            {
                //CONSTARINT TO UPPER
                constraint=constraint.toString().toUpperCase();

                ArrayList<Search> filters=new ArrayList<Search>();

                //get specific items
                for(int i=0;i<filterList.size();i++)
                {
                    if(filterList.get(i).getPid().toUpperCase().contains(constraint) || filterList.get(i).getLid().toUpperCase().contains(constraint))
                    {
                        Search p=new Search(filterList.get(i).getPid(),filterList.get(i).getLid(),filterList.get(i).getQuan());

                        filters.add(p);
                    }
                }

                results.count=filters.size();
                results.values=filters;

            }else
            {
                results.count=filterList.size();
                results.values=filterList;

            }

            return results;
        }

        @Override
        protected void publishResults(CharSequence constraint, FilterResults results) {
            // TODO Auto-generated method stub

            searches=(ArrayList<Search>) results.values;
            notifyDataSetChanged();
        }

    }



}
