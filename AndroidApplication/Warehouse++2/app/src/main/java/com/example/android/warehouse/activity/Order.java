package com.example.android.warehouse.activity;

/**
 * Created by DELL on 4/8/2018.
 */

public class Order {

    private String coid,dtime,ocom,ocname,pq,web;
    private int img;

    public Order(String coid,String dtime,String ocom,String ocname,String pq) {
        // TODO Auto-genewebd constructor stub
        this.coid=coid;
        this.dtime=dtime;
        this.ocom=ocom;
        this.ocname=ocname;
        this.pq=pq;
    }

    public String getcoid() {
        return coid;
    }
    public void setcoid(String coid) {
        this.coid = coid;
    }

    public String getdtime() {
        return dtime;
    }
    public void setdtime(String dtime) {
        this.dtime = dtime;
    }

    public String getocom() {
        return ocom;
    }
    public void setocom(String ocom) {
        this.ocom = ocom;
    }

    public String getocname() {
        return ocname;
    }
    public void setocname(String ocname) {
        this.ocname = ocname;
    }

    public String getpq() {
        return pq;
    }
    public void setpq(String pq) {
        this.pq = pq;
    }

}
