package com.example.listview;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.Arrays;
import java.util.List;


public class MainActivity extends AppCompatActivity {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ListView listView = (ListView)findViewById(R.id.listView);
        //Création des users
        UserAccount francois = new UserAccount("François","admin",true);
        UserAccount germain = new UserAccount("Germain","user");
        UserAccount cedric = new UserAccount("Cédric","guest",false);
        //Création de la liste
        UserAccount[] users = new UserAccount[]{francois,germain,cedric};
        //Création de l'adapter
        ArrayAdapter<UserAccount> arrayAdapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1,users);
        //Affectation de l'adapter

//        for(int i = 0; i < users.length; i++)
//        { listView.setItemChecked(i, users[i].isActive()); }

        listView.setAdapter(new CustomListAdapter(Arrays.asList(users), this));

    }



}