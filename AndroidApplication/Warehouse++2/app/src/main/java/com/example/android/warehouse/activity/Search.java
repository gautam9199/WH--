package com.example.android.warehouse.activity;

/**
 * Created by DELL on 3/29/2018.
 */

public class Search {

    private String pid,lid,quan;
    private int img;

    public Search(String pid,String lid,String quan) {
        // TODO Auto-generated constructor stub
        this.pid=pid;
        this.lid=lid;
        this.quan=quan;
    }

    public String getPid() {
        return pid;
    }
    public void setPid(String pid) {
        this.pid = pid;
    }

    public String getLid() {
        return lid;
    }
    public void setLid(String lid) {
        this.lid = lid;
    }

    public String getQuan() {
        return quan;
    }
    public void setQuan(String quan) {
        this.quan = quan;
    }


}
