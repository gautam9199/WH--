package com.example.android.warehouse.activity;

/**
 * Created by DELL on 3/22/2018.
 */

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

public class Adapter_product extends BaseAdapter implements Filterable{

    Context c;
    ArrayList<Product> products;
    CustomFilter filter;
    ArrayList<Product> filterList;

    public Adapter_product(Context ctx, ArrayList<Product> products) {
        // TODO Auto-generated constructor stub

        this.c=ctx;
        this.products=products;
        this.filterList=products;
    }

    @Override
    public int getCount() {
        // TODO Auto-generated method stub
        return products.size();
    }

    @Override
    public Object getItem(int pos) {
        // TODO Auto-generated method stub
        return products.get(pos);
    }

    @Override
    public long getItemId(int pos) {
        // TODO Auto-generated method stub
        return products.indexOf(getItem(pos));
    }

    @Override
    public View getView(int pos, View convertView, ViewGroup parent) {
        // TODO Auto-generated method stub

        LayoutInflater inflater=(LayoutInflater) c.getSystemService(Context.LAYOUT_INFLATER_SERVICE);

        if(convertView==null)
        {
            convertView=inflater.inflate(R.layout.model_productlist, null);
        }

        TextView pidTxt=(TextView) convertView.findViewById(R.id.pid);
        TextView mNoTxt=(TextView) convertView.findViewById(R.id.mNo);
        TextView typeTxt=(TextView) convertView.findViewById(R.id.type);
        TextView sizeTxt=(TextView) convertView.findViewById(R.id.size);
        TextView finishTxt=(TextView) convertView.findViewById(R.id.fin);
        TextView rateTxt=(TextView) convertView.findViewById(R.id.rate);
        TextView bsizeTxt=(TextView) convertView.findViewById(R.id.bsize);
        TextView pbqTxt=(TextView) convertView.findViewById(R.id.pbq);
        TextView totalTxt=(TextView) convertView.findViewById(R.id.total);

        //SET DATA TO THEM
        pidTxt.setText(products.get(pos).getPid());
        mNoTxt.setText(products.get(pos).getMNo());
       typeTxt.setText(products.get(pos).getType());
        sizeTxt.setText(products.get(pos).getSize());
        finishTxt.setText(products.get(pos).getFinish());
        rateTxt.setText(products.get(pos).getRate());
        bsizeTxt.setText(products.get(pos).getBsize());
        pbqTxt.setText(products.get(pos).getPbq());
        totalTxt.setText(products.get(pos).getTotal());

        return convertView;
    }

    @Override
    public Filter getFilter() {
        // TODO Auto-generated method stub
        if(filter == null)
        {
            filter=new CustomFilter();
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

                ArrayList<Product> filters=new ArrayList<Product>();

                //get specific items
                for(int i=0;i<filterList.size();i++)
                {
                    if(filterList.get(i).getPid().toUpperCase().contains(constraint))
                    {
                        Product p=new Product(filterList.get(i).getPid(),filterList.get(i).getMNo(),filterList.get(i).getType(),
                                filterList.get(i).getSize(),filterList.get(i).getFinish(),filterList.get(i).getRate(),filterList.get(i).getBsize(),
                                filterList.get(i).getPbq(),filterList.get(i).getTotal());

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

            products=(ArrayList<Product>) results.values;
            notifyDataSetChanged();
        }

    }

}