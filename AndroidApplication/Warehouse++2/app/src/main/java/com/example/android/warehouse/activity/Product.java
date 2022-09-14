package com.example.android.warehouse.activity;

/**
 * Created by DELL on 3/23/2018.
 */

public class Product {
    private String pid,mNo,type,size,finish,rate,bsize,pbq,total;
    private int img;

    public Product(String pid,String mNo,String type,String size,String finish,String rate,String bsize,String pbq,String total) {
        // TODO Auto-generated constructor stub
        this.pid=pid;
        this.mNo=mNo;
        this.type=type;
        this.size=size;
        this.finish=finish;
        this.rate=rate;
        this.bsize=bsize;
        this.pbq=pbq;
        this.total=total;
    }

    public String getPid() {
        return pid;
    }
    public void setPid(String pid) {
        this.pid = pid;
    }

    public String getMNo() {
        return mNo;
    }
    public void setMNo(String mNo) {
        this.mNo = mNo;
    }

    public String getType() {
        return type;
    }
    public void setType(String type) {
        this.type = type;
    }

    public String getSize() {
        return size;
    }
    public void setSize(String size) {
        this.size = size;
    }

    public String getFinish() {
        return finish;
    }
    public void setFinish(String finish) {
        this.finish = finish;
    }

    public String getRate() {
        return rate;
    }
    public void setRate(String rate) {this.rate = rate;}

    public String getBsize() {
        return bsize;
    }
    public void setBsize(String bsize) {
        this.bsize = bsize;
    }

    public String getPbq() {
        return pbq;
    }
    public void setPbq(String pbq) {
        this.pbq = pbq;
    }

    public String getTotal() {return total;}
    public void setTotal(String total) {this.total = total;}


}
