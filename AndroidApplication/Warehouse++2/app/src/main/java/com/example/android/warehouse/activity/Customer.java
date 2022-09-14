package com.example.android.warehouse.activity;

/**
 * Created by DELL on 3/29/2018.
 */

public class Customer {
    private String cname,comname,pno,address,email,web;
    private int img;

    public Customer(String cname,String comname,String pno,String address,String email,String web) {
        // TODO Auto-genewebd constructor stub
        this.cname=cname;
        this.comname=comname;
        this.pno=pno;
        this.address=address;
        this.email=email;
        this.web=web;
    }

    public String getcname() {
        return cname;
    }
    public void setcname(String cname) {
        this.cname = cname;
    }

    public String getcomname() {
        return comname;
    }
    public void setcomname(String comname) {
        this.comname = comname;
    }

    public String getpno() {
        return pno;
    }
    public void setpno(String pno) {
        this.pno = pno;
    }

    public String getaddress() {
        return address;
    }
    public void setaddress(String address) {
        this.address = address;
    }

    public String getemail() {
        return email;
    }
    public void setemail(String email) {
        this.email = email;
    }

    public String getweb() {
        return web;
    }
    public void setweb(String web) {this.web = web;}


}
