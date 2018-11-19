package com.illsia.calleventsample;

import android.app.Activity;
import android.content.Context;
import android.os.Bundle;
import android.telephony.TelephonyManager;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.Button;
import android.widget.EditText;

public class MyActivity extends Activity {
    TelephonyManager manager;
    //PhoneStateReceiver.PhoneReceiver myPhoneStateListener;
    PhoneStateReceiver myPhoneStateReceiver;

    @Override
    public void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_my);

        //myPhoneStateListener = new PhoneStateReceiver.PhoneReceiver(this, this);
        //myPhoneStateListener = new PhoneStateReceiver.PhoneReceiver();

        myPhoneStateReceiver = new PhoneStateReceiver();

        manager = (TelephonyManager)
                getSystemService(Context.TELEPHONY_SERVICE);


        // エディットテキストのフォーカス移動の際にキーボードを隠す
        EditText et = (EditText) findViewById(R.id.editTextPhoneNumber);
        et.setOnFocusChangeListener(new View.OnFocusChangeListener() {

            @Override
            public void onFocusChange(View v, boolean hasFocus) {
                // EditTextのフォーカスが外れた場合
                if (hasFocus == false) {
                    // ソフトキーボードを非表示にする
                    InputMethodManager imm = (InputMethodManager)getSystemService(Context.INPUT_METHOD_SERVICE);
                    imm.hideSoftInputFromWindow(v.getWindowToken(), InputMethodManager.HIDE_NOT_ALWAYS);
                }
            }
        });

        // Settingボタンの処理
        Button button = (Button) findViewById(R.id.buttonSetting);
        // ボタンがクリックされた時に呼び出されるコールバックリスナーを登録します
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                // クリック時の処理
                // ボタンがクリックされた時に呼び出されます
                //Button button = (Button) v;

                // エディットテキスト取得
                EditText editText = (EditText) findViewById(R.id.editTextPhoneNumber);
                // エディットテキストのテキストを取得します
                String a = myPhoneStateReceiver.toString();

                //editText.setText("12345678");
            }
        });
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.my, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_settings) {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}
