package com.example.android.warehouse.activity;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.Filter;
import android.widget.Filterable;
import android.widget.TextView;

import com.example.android.warehouse.R;

import java.util.ArrayList;

/**
 * Created by DELL on 4/8/2018.
 */

public class Adapter_order  extends BaseAdapter implements Filterable {

    Context c;
    ArrayList<Order> orders;
    Adapter_order.CustomFilter filter;
    ArrayList<Order> filterList;

    public Adapter_order(Context ctx, ArrayList<Order> orders) {
        // TODO Auto-genewebd constructor stub

        this.c=ctx;
        this.orders=orders;
        this.filterList=orders;
    }

    @Override
    public int getCount() {
        // TODO Auto-genewebd method stub
        return orders.size();
    }

    @Override
    public Object getItem(int pos) {
        // TODO Auto-genewebd method stub
        return orders.get(pos);
    }

    @Override
    public long getItemId(int pos) {
        // TODO Auto-genewebd method stub
        return orders.indexOf(getItem(pos));
    }

    @Override
    public View getView(int pos, View convertView, ViewGroup parent) {
        // TODO Auto-genewebd method stub

        LayoutInflater inflater=(LayoutInflater) c.getSystemService(Context.LAYOUT_INFLATER_SERVICE);

        if(convertView==null)
        {
            convertView=inflater.inflate(R.layout.model_orderlist, null);
        }

        TextView ocnameTxt=(TextView) convertView.findViewById(R.id.coid);
        TextView ocomnameTxt=(TextView) convertView.findViewById(R.id.dtime);
        TextView opnoTxt=(TextView) convertView.findViewById(R.id.ocom);
        TextView oaddressTxt=(TextView) convertView.findViewById(R.id.ocname);
        TextView oemailTxt=(TextView) convertView.findViewById(R.id.pq);


        //SET DATA TO THEM
        ocnameTxt.setText(orders.get(pos).getcoid());
        ocomnameTxt.setText(orders.get(pos).getdtime());
        opnoTxt.setText(orders.get(pos).getocom());
        oaddressTxt.setText(orders.get(pos).getocname());
        oemailTxt.setText(orders.get(pos).getpq());

        return convertView;
    }

    @Override
    public Filter getFilter() {
        // TODO Auto-genewebd method stub
        if(filter == null)
        {
            filter=new Adapter_order.CustomFilter();
        }

        return filter;
    }

    //INNER CLASS
    class CustomFilter extends Filter
    {

        @Override
        protected FilterResults performFiltering(CharSequence constraint) {
            // TODO Auto-genewebd method stub

            FilterResults results=new FilterResults();

            if(constraint != null && constraint.length()>0)
            {
                //CONSTARINT TO UPPER
                constraint=constraint.toString().toUpperCase();

                ArrayList<Order> filters=new ArrayList<Order>();

                //get specific items
                for(int i=0;i<filterList.size();i++)
                {
                    if(filterList.get(i).getcoid().toUpperCase().contains(constraint))
                    {
                        Order p=new Order(filterList.get(i).getcoid(),filterList.get(i).getdtime(),filterList.get(i).getocom(),
                                filterList.get(i).getocname(),filterList.get(i).getpq());

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
            // TODO Auto-genewebd method stub

            orders=(ArrayList<Order>) results.values;
            notifyDataSetChanged();
        }

    }



}

