package com.example.demo3;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class SecondActivity extends AppCompatActivity {

    public static final String EXTRA_REPLY = "deuxactivite.extra.REPLY";
    private EditText mReply;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        //reception du message de main
        Intent intent = getIntent();
        TextView textView = findViewById(R.id.text_message);
        String message = intent.getStringExtra(MainActivity.EXTRA_MESSAGE);
        textView.setText(message);

        mReply = findViewById(R.id.edit_text_reponse);

    }

    public void returnReply(View view){
        //recuperation de la reponse de l'utilisateur
        String reply = mReply.getText().toString();
        // Instanciation d'un nouvel intent
        Intent replyIntent = new Intent();
        replyIntent.putExtra(EXTRA_REPLY,reply);
        //mise e jour de l'etat de la reponse
        setResult(RESULT_OK, replyIntent);
        // on termine l'activité 2
        finish();
    }
}