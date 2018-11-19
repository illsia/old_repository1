package com.illsia.calleventsample;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.telephony.PhoneStateListener;
import android.telephony.SmsManager;
import android.telephony.TelephonyManager;
import android.widget.Toast;

import java.util.Calendar;


/**
 * Created by illsia on 14/12/10.
 */
public class PhoneStateReceiver extends BroadcastReceiver {
    TelephonyManager manager;
    PhoneReceiver myPhoneStateListener;
    static boolean alreadyListening = false;

    public void setPhoneNumberSendSMS(String value) {
        myPhoneStateListener.setPhoneNumberSendSMS(value);
    };


    @Override
    public void onReceive(Context context, Intent intent){
        myPhoneStateListener = new PhoneReceiver(context);
        manager = ((TelephonyManager) context.getSystemService(context.TELEPHONY_SERVICE));

        //---do not add the listener more than once---
        if (!alreadyListening){
            manager.listen(myPhoneStateListener,
                    PhoneStateListener.LISTEN_CALL_STATE);
            alreadyListening = true;
        }
    }

    public class PhoneReceiver extends PhoneStateListener{
        // SMSを送る電話番号を設定
        //  → 外出しにしたい。SQLiteに入れるとかかな？
        String myPhoneNumberSendSMS = "xxx-xxxx-xxxx";
        public void setPhoneNumberSendSMS(String value) {
            myPhoneNumberSendSMS = value;
        };


        Context context;
        public PhoneReceiver(Context context){
            this.context = context;
        }

        @Override
        public void onCallStateChanged(int state, String incomingNumber){
            super.onCallStateChanged(state, incomingNumber);
            switch(state){
                case TelephonyManager.CALL_STATE_IDLE:
                    //Toast.makeText(context, "idle", Toast.LENGTH_LONG).show();
                    break;

                case TelephonyManager.CALL_STATE_RINGING:
                    //Toast.makeText(context, "ringing", Toast.LENGTH_LONG).show();

                    // sleep
                    sleep(1000);
                    // send SMS
                    SmsManager smsManager = SmsManager.getDefault();
                    StringBuilder buf = new StringBuilder();
                    buf.append("[ringing] ");
                    if (incomingNumber == null || incomingNumber.length() == 0) {
                        buf.append("<非通知>");
                    } else {
                        buf.append(incomingNumber);
                    }
                    buf.append(" [");
                    buf.append(getCurrentTime());
                    buf.append("]");

                    try
                    {
                       smsManager.sendTextMessage(myPhoneNumberSendSMS, null, buf.toString(), null, null);
                    }catch(Exception e){
                        Toast.makeText(context, "SMS send error", Toast.LENGTH_LONG).show();
                    }

                    break;

                case TelephonyManager.CALL_STATE_OFFHOOK:
                    //Toast.makeText(context, "Offhook", Toast.LENGTH_LONG).show();
                    break;
            }
        }


        // 現在時刻を取得
        public String getCurrentTime() {
            StringBuilder buf = new StringBuilder();

            final Calendar calendar = Calendar.getInstance();

            final int year = calendar.get(Calendar.YEAR);
            final int month = calendar.get(Calendar.MONTH);
            final int day = calendar.get(Calendar.DAY_OF_MONTH);
            final int hour = calendar.get(Calendar.HOUR_OF_DAY);
            final int minute = calendar.get(Calendar.MINUTE);
            final int second = calendar.get(Calendar.SECOND);
            final int ms = calendar.get(Calendar.MILLISECOND);

            buf.append(year + "/" + (month + 1) + "/" + day + "/" + " " + hour + ":" + minute + ":" + second + "." + ms);
            return buf.toString();

        };

        //指定ミリ秒実行を止めるメソッド
        public synchronized void sleep(long msec)
        {
            try
            {
                wait(msec);
            }catch(InterruptedException e){}
        }
    }
}
