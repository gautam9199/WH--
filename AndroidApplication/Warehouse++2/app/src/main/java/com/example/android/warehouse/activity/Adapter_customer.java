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
 * Created by DELL on 3/29/2018.
 */

public class Adapter_customer  extends BaseAdapter implements Filterable {
    Context c;
    ArrayList<Customer> customers;
    Adapter_customer.CustomFilter filter;
    ArrayList<Customer> filterList;

    public Adapter_customer(Context ctx, ArrayList<Customer> customers) {
        // TODO Auto-genewebd constructor stub

        this.c=ctx;
        this.customers=customers;
        this.filterList=customers;
    }

    @Override
    public int getCount() {
        // TODO Auto-genewebd method stub
        return customers.size();
    }

    @Override
    public Object getItem(int pos) {
        // TODO Auto-genewebd method stub
        return customers.get(pos);
    }

    @Override
    public long getItemId(int pos) {
        // TODO Auto-genewebd method stub
        return customers.indexOf(getItem(pos));
    }

    @Override
    public View getView(int pos, View convertView, ViewGroup parent) {
        // TODO Auto-genewebd method stub

        LayoutInflater inflater=(LayoutInflater) c.getSystemService(Context.LAYOUT_INFLATER_SERVICE);

        if(convertView==null)
        {
            convertView=inflater.inflate(R.layout.model_customerlist, null);
        }

        TextView cnameTxt=(TextView) convertView.findViewById(R.id.cname);
        TextView comnameTxt=(TextView) convertView.findViewById(R.id.comname);
        TextView pnoTxt=(TextView) convertView.findViewById(R.id.pno);
        TextView addressTxt=(TextView) convertView.findViewById(R.id.address);
        TextView emailTxt=(TextView) convertView.findViewById(R.id.email);
        TextView webTxt=(TextView) convertView.findViewById(R.id.web);


        //SET DATA TO THEM
        cnameTxt.setText(customers.get(pos).getcname());
        comnameTxt.setText(customers.get(pos).getcomname());
        pnoTxt.setText(customers.get(pos).getpno());
        addressTxt.setText(customers.get(pos).getaddress());
        emailTxt.setText(customers.get(pos).getemail());
        webTxt.setText(customers.get(pos).getweb());

        return convertView;
    }

    @Override
    public Filter getFilter() {
        // TODO Auto-genewebd method stub
        if(filter == null)
        {
            filter=new Adapter_customer.CustomFilter();
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

                ArrayList<Customer> filters=new ArrayList<Customer>();

                //get specific items
                for(int i=0;i<filterList.size();i++)
                {
                    if(filterList.get(i).getcname().toUpperCase().contains(constraint))
                    {
                        Customer p=new Customer(filterList.get(i).getcname(),filterList.get(i).getcomname(),filterList.get(i).getpno(),
                                filterList.get(i).getaddress(),filterList.get(i).getemail(),filterList.get(i).getweb());

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

            customers=(ArrayList<Customer>) results.values;
            notifyDataSetChanged();
        }

    }



}
