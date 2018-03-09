package com.example.frni.mybrowserworking;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.EditText;
import android.widget.TextView;

public class mybrowser extends AppCompatActivity {

    private WebView web;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mybrowser);

        web = (WebView)findViewById(R.id.webView);
        web.getSettings().setLoadsImagesAutomatically(true);
        web.getSettings().setAppCacheEnabled(true);
        web.getSettings().setJavaScriptEnabled(true);
        web.setWebViewClient(new WebViewClient() {
            @Override
            public void onPageFinished(WebView view, String url) {
                EditText edit =  (EditText)findViewById(R.id.editText);
                if(!edit.hasFocus()) {
                    edit.setText(web.getUrl(), TextView.BufferType.EDITABLE);
                }
            };
        });
        web.loadUrl("https:/google.dk");
    }
    public void changeurl(View vv){
        final EditText edit =  (EditText)findViewById(R.id.editText);
        web.loadUrl(edit.getText().toString());
        edit.clearFocus();
    }
}
