#include <iostream>
#include<conio.h>
#include<stdlib.h>
#include<fstream>
using namespace std;
class class1
{
    public:

 class1();
void display();
void dhaka();
void coxs_bazar();
void chittagong();
void rajshahi();
void schedule();
void book();
void sylhet();
void menu();
void reg();
void details();
void bookd();
void emp();
void eregs();

    protected:
void login();
void registration();
void maain();
};
class1::class1()
{
  cout<<"";

 }


 void class1::schedule()
  {system("CLS");
int go;
int choice;
int dest;
int src;
int w;
 cout<<""<<endl;
        cout<<""<<endl;


        cout<<"                                           Air Line Schedule          "<<endl;
        cout<<"                                       =========================      "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;

cout<<"\t                              1. Flight Schedule of DHAKA "<<endl;
cout<<"\t                              2. Flight Schedule of CITTAGONG"<<endl;
cout<<"\t                              3. Flight Schedule of RAJSHASHI"<<endl;
cout<<"\t                              4. Flight Schedule of SYLHET"<<endl;

cout<<"\t Choose your Option from 1-to-4:"<<endl;
cout<< " Enter Source :" ;
cin>>src;
cout <<" Enter destination :";
cin >> dest;

{
  if(src==1 && dest==2 || src==2 && dest==1)
{system("CLS");
cout << " Flights Found" <<endl;
cout << "Airline:            \tDeparture:\tArrival:\tPrice:  \t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<"PRESS 0 FOR GO BACK :";
cin>>w;
while(w==0)
{
    menu();
}



}

else if(src==2 && dest==3 || src==3 && dest==2)
{system("CLS");
cout << " Flights Found" <<endl;
cout << "Airline:            \tDeparture:\tArrival:\tPrice:\t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<"PRESS 0 FOR GO BACK :";
cin>>w;
while(w==0)
{
    menu();
}
}

else if(src==3 && dest==4 || src==4 && dest==3)
{system("CLS");
cout << " Flights Found" <<endl;
cout << "Airline:             \tDeparture:\tArrival:\tPrice:\t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<"PRESS 0 FOR GO BACK :";
cin>>w;
while(w==0)
{
    menu();
}
}
else if(src==3 && dest==1 || src==1 && dest==3)
{system("CLS");
cout << " Flights Found" <<endl;
cout << "Airline:             \tDeparture:\tArrival:\tPrice:\t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<"PRESS 0 FOR GO BACK :";
cin>>w;
while(w==0)
{
    menu();
}
}
else if(src==4 && dest==1 || src==1 && dest==4)
{system("CLS");
cout << " Flights Found" <<endl;
cout << "Airline:             \tDeparture:\tArrival:\tPrice:\t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<"PRESS 0 FOR GO BACK :";
cin>>w;
while(w==0)
{
    menu();
}
}
else if(src==4 && dest==2 || src==2 && dest==4)
{system("CLS");
cout << " Flights Found" <<endl;
cout << "Airline:             \tDeparture:\tArrival:\tPrice:\t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<"PRESS 0 FOR GO BACK :";
cin>>w;
while(w==0)
{
    menu();
}
}
}



}





   void class1::book()
    {
       system("CLS");
    int nid,phnNum;
 int a,b,t,n;
     int tic =60;
    int op;
    int by;
int choice;
int dest;
int src;
int w;
int ca,cn,cp,fc;
string time;
string cnm,pas;
    string lo;
   ofstream file;
   file.open("ticket.txt",ios::out|ios::app);
    cout<<""<<endl;
    cout<<""<<endl;
    cout<<"                                         BOOKING TICKET     "<<endl;
    cout<<"                                  =========================="<<endl;
    cout<<""<<endl;
    cout<<""<<endl;
    cout<<""<<endl;
    cout<<"                                 #Enter your current location :";
    cin>>lo;
     file<<lo<<endl;

      {system("CLS");

 cout<<""<<endl;
        cout<<""<<endl;


        cout<<"                                   WHERE YOU WANT TO GO        "<<endl;
        cout<<"                                =========================      "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;

cout<<"\t                              1. Flight Schedule of DHAKA "<<endl;
cout<<"\t                              2. Flight Schedule of CITTAGONG"<<endl;
cout<<"\t                              3. Flight Schedule of RAJSHASHI"<<endl;
cout<<"\t                              4. Flight Schedule of SYLHET"<<endl;

cout<<"                 Choose your Option from 1-to-4:";
cin>>dest;
      }
if(dest==1)
{system("CLS");
file<<"DHAKA";

  cout << " Flights Found" <<endl;
cout << "Airline:            \tDeparture:\tArrival:\tPrice:  \t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"             which flight you want to chose 1/2/3 :";
cin>>fc;
if(fc==1)
{
   file<< "BIMANBANGLADESH 08:00   11:05  BDT.5000 ";

}
else if(fc==2)
{
    file<<"NOVOAIR  14:00  17:00 BDT.5500 ";
}
else if(fc==3)
{
   file<<" USBANGLA  19:00   22:05  BDT.6000";
}
else
    {
       cout<<"you enter a wrong number";
       book();
    }
cout<<"             How many tickets you want to buy :";
cin>>by;
file<<by<<endl;
cin.get();
{system("CLS");

cout<<"                               PAYMENT         "<<endl;
cout<<"                         ====================    "<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"                         1.BIKSH"<<endl;
cout<<"                         2.CREDIT CARD"<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"             Chose anyone :";
cin>>ca;
}
 if(ca==1)
 {system("CLS");
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                            BIKSH         "<<endl;
        cout<<"                      =================   "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                 Personal Bkash no."<<endl<<"1.018********"<<endl<<"2.017********"<<endl;
        cout<<"                 refers number is "<<"7474"<<endl;
        cout<<"                 wait for the confirmation message"<<endl;
        cout<<" "<<endl;
                cout<<" "<<endl;
                        cout<<"   PRESS ENTER FOR GOING BACK"<<endl;
                      cin.get();
                      cin.get();
                      {
                           menu();
                      }

 }
  else if(ca==2)
  {system("CLS");
       cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                         CREDIT CARD        "<<endl;
        cout<<"                      =================     "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
         cout<<"                      Enter your credit cart number:"<<endl;
        cin>>cnm;
        cout<<"                      Enter the password:"<<endl;
        cin>>pas;

           cout<<"        PRESS ENTER FOR GOING BACK"<<endl;
                      cin.get();
                      cin.get();
                      {
                           menu();
                      }

  }
 else{
        cout<<"           Chose wrong number";
     }



}

else if(dest==2)
{system("CLS");
file<<"CHITTAGONG";
cout << " Flights Found" <<endl;
cout << "Airline:            \tDeparture:\tArrival:\tPrice:\t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"             which flight you want to chose 1/2/3 :";
cin>>fc;
if(fc==1)
{
   file<< "BIMANBANGLADESH 08:00   11:05  BDT.5000 ";

}
else if(fc==2)
{
    file<<"NOVOAIR  14:00  17:00 BDT.5500 ";
}
else if(fc==3)
{
   file<<" USBANGLA  19:00   22:05  BDT.6000";
}
else
    {
       cout<<"you enter a wrong number";
       book();
    }
cout<<"             How many tickets you want to buy :";
cin>>by;
file<<by<<endl;
cin.get();
{system("CLS");

}
cout<<"                               PAYMENT         "<<endl;
cout<<"                         ====================    "<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"                         1.BIKSH"<<endl;
cout<<"                         2.CREDIT CARD"<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"                Chose anyone :";
cin>>ca;
 if(ca==1)
 {system("CLS");
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                            BIKSH         "<<endl;
        cout<<"                      =================   "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                 Personal Bkash no."<<endl<<"1.018********"<<endl<<"2.017********"<<endl;
        cout<<"                 refers number is "<<"7474"<<endl;
        cout<<"                 wait for the confirmation message"<<endl;
        cout<<" "<<endl;
    cout<<"                    PRESS ENTER FOR GOING BACK"<<endl;
                      cin.get();
                      cin.get();
                      {
                           menu();
                      }
 }
  else if(ca==2)
  {system("CLS");
       cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                         CREDIT CARD        "<<endl;
        cout<<"                      =================     "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
         cout<<"                      Enter your credit cart number:"<<endl;
        cin>>cnm;
        cout<<"                      Enter the password:"<<endl;
        cin>>pas;



    cout<<" PRESS ENTER FOR GOING BACK"<<endl;
                      cin.get();
                      cin.get();
                      {
                           menu();
                      }
  }
 else{
        cout<<"Chose wrong number";
     }
}

else if(dest==3)
{system("CLS");
file<<"RAJSHAHI";
cout << " Flights Found" <<endl;
cout << "Airline:             \tDeparture:\tArrival:\tPrice:\t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"             which flight you want to chose 1/2/3 :";
cin>>fc;
if(fc==1)
{
   file<< "BIMANBANGLADESH 08:00   11:05  BDT.5000 ";

}
else if(fc==2)
{
    file<<"NOVOAIR  14:00  17:00 BDT.5500 ";
}
else if(fc==3)
{
   file<<" USBANGLA  19:00   22:05  BDT.6000";
}
else
    {
       cout<<"you enter a wrong number";
       book();
    }
cout<<"             How many tickets you want to buy :";
cin>>by;
file<<by<<endl;
cin.get();
{system("CLS");

}
cout<<"                               PAYMENT         "<<endl;
cout<<"                         ====================    "<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"                         1.BIKSH"<<endl;
cout<<"                         2.CRADIT CARD"<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"             Chose anyone :";
cin>>ca;
 if(ca==1)
 {system("CLS");
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                            BIKSH         "<<endl;
        cout<<"                      =================   "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                Personal Bkash no."<<endl<<"1.018********"<<endl<<"2.017********"<<endl;
        cout<<"                refers number is "<<"7474"<<endl;
        cout<<"                wait for the confirmation message"<<endl;
        cout<<" "<<endl;
    cout<<"                    PRESS ENTER FOR GOING BACK"<<endl;
                      cin.get();
                      cin.get();
                      {
                           menu();
                      }
 }
  else if(ca==2)
  {system("CLS");
       cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                         CREDIT CARD        "<<endl;
        cout<<"                      =================     "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
         cout<<"                      Enter your credit cart number:"<<endl;
        cin>>cnm;
        cout<<"                      Enter the password:"<<endl;
        cin>>pas;

    cout<<" PRESS ENTER FOR GOING BACK"<<endl;
                      cin.get();
                      cin.get();
                      {
                           menu();
                      }

  }
 else{
        cout<<"Chose wrong number";
     }
}
else if(dest==4)
{system("CLS");
file<<"sylhet";
cout << " Flights Found" <<endl;
cout << "Airline:             \tDeparture:\tArrival:\tPrice:\t\tCategory: "<<endl;
cout << "\1.BIMANBANGLADESH(1)\t08:00\t\t11:05\t\tBDT.5000\t\tRefundable"<<endl;
cout << "\2.NOVOAIR(2)        \t14:00\t\t17:05\t\tBDT.5500\t\tRefundable"<<endl;
cout << "\3.USBANGLA(3)       \t19:00\t\t22:05\t\tBDT.6000\t\tRefundable"<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"             which flight you want to chose 1/2/3 :";
cin>>fc;
if(fc==1)
{
   file<< "BIMANBANGLADESH 08:00   11:05  BDT.5000 ";

}
else if(fc==2)
{
    file<<"NOVOAIR  14:00  17:00 BDT.5500 ";
}
else if(fc==3)
{
   file<<" USBANGLA  19:00   22:05  BDT.6000";
}
else
    {
       cout<<"you enter a wrong number";
       book();
    }
cout<<"             How many tickets you want to buy :";
cin>>by;
file<<by<<endl;
cin.get();
{system("CLS");

}
cout<<"                               PAYMENT         "<<endl;
cout<<"                         ====================    "<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"                         1.BIKSH"<<endl;
cout<<"                         2.CRADIT CARD"<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"             Chose anyone :";
cin>>ca;
 if(ca==1)
 {system("CLS");
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                            BIKSH         "<<endl;
        cout<<"                      =================   "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                  Personal Bkash no."<<endl<<"1.018********"<<endl<<"2.017********"<<endl;
        cout<<"                  refers number is "<<"7474"<<endl;
        cout<<"                  wait for the confirmation message"<<endl;
        cout<<" "<<endl;
    cout<<"                     PRESS ENTER FOR GOING BACK"<<endl;
                      cin.get();
                      cin.get();
                      {
                           menu();
                      }
 }
  else if(ca==2)
  {system("CLS");
       cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                         CREDIT CARD        "<<endl;
        cout<<"                      =================     "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                      Enter your credit cart number:"<<endl;
        cin>>cnm;
        cout<<"                      Enter the password:"<<endl;
        cin>>pas;

{
    cout<<" PRESS ENTER FOR GOING BACK"<<endl;
                      cin.get();
                      cin.get();
                      {
                           menu();
                      }

  }
  }
}
 else{
        cout<<"Chose wrong number";
     }
}

void class1::details()
    {
                    string nid,phnNum,reguser,regpass;
         ifstream output("database.txt");
         while(output>> reguser>>regpass >>nid>>phnNum)
         {
             cout<<""<<endl;
               cout<<""<<endl;
                 cout<<""<<endl;
        cout<<"                                   USER ID      :"<<reguser<<endl;
        cout<<"                                   PASSWORD     :"<<regpass<<endl;
        cout<<"                                   National id  :"<<nid<<endl;
        cout<<"                                   Phone number :"<<phnNum<<endl;


         }
         output.close();
            }

 void class1::bookd()
 {system("CLS");
      string lo,ds,tm,tim,tk,tck;
        cout<<"                                       USER DETAILS"<<endl;
        cout<<"                                    =================="<<endl;
    details();

     ifstream file1("ticket.txt",ios::in);
     while(file1>>lo>>ds>>tm >>tim >>tk >>tck)
     {   cout<<""<<endl;
      cout<<""<<endl;
       cout<<""<<endl;
        cout<<""<<endl;
         cout<<""<<endl;
         cout<<"                          BOOKING DETAILS"<<endl;
         cout<<"                        ==================="<<endl;
         cout<<""<<endl;
        cout<<""<<endl;
         cout<<"                       location     :"<<lo<<endl;
         cout<<"                       Destination  :"<<ds<<endl;
         cout<<"                       Departure    :"<<tm<< endl;
         cout<<"                       Arrival      :"<<tim<<endl;
         cout<<"                       Taka         :"<<tk<<endl;
         cout<<"                       Booked ticket:"<<tck<<endl;
     }

      file1.close();
 }

 void class1:: menu()
     { system("CLS");
  int go;
    int me;
    string lo;
      cout<<""<<endl;
      cout<<""<<endl;
      cout<<""<<endl;

        cout<<"                                             AIR BANGLA                 "<<endl;
        cout<<"                                   ==============================       "<<endl;
        cout<<""<<endl;


        cout<<"                               1. FLIGHT SCHEDULE "<<endl;
        cout<<"                               2. BOOK TICKET  "<<endl;
        cout<<"                               3. BOOKING DETAILS  "<<endl;
        cout<<"                               4. LOG OUT"<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<""<<endl;


        cout<<"                                                      Choose your Option from 1 to 4:";
        cin>>me;


    switch(me){
     case 1:
      schedule();
      break;

     case 2:
        book();

        break;
         case 3:

                bookd();


                     cout<<""<<endl;
        cout<<""<<endl;


              cout<<"                                                    type 0 for GOTO MainMenu :";
    cin>>go;
    if(go==0)
         {
        menu();
    }
        break;



    break;
     case 4:
        cout<<""<<endl;
                cout<<""<<endl;
                        cout<<"                                                   THANK YOU"<<endl;
             cout<<"------------------------------------------------------------------------------------------------------------------------"<<endl;
        break;
     default:
        cout<<"                   you choose a wrong option"<<endl;
        {
    cout<<"                       type 0 for GOTO MainMenu :";
    cin>>go;
    if(go==0)
    {
        menu();
    }
        }
    }
}
void class1::maain()
{ system("CLS");
        int choice;
         int ext;
        cout<<""<<endl;
           cout<<""<<endl;
         cout<<""<<endl;

        cout<<"                                      LOGIN AND REGESTRATION           "<<endl;
        cout<<"                               =====================================    "<<endl;


        cout<<""<<endl;
        cout<<""<<endl;

        cout<<"                              1.LOGIN"<<endl;
        cout<<"                              2.REGISTERTION"<<endl;
        cout<<"                              3.Exit"<<endl;
        cout<<""<<endl;
      cout<<""<<endl;
      cout<<""<<endl;
        cout<<"                                                      Choose your Option from 1 to 3 : ";
        cin>>choice;
        cout<<endl;
        switch(choice)
        {
                case 1:
                        login();
                        break;
                case 2:
                        registration();
                        break;
                case 3:

               cout<<"                    Enter 3 for confirm exit :";
               cin>>ext;
               if(ext==0)
    {
                maain();

    }
                else{ cout<<""<<endl;
                cout<<""<<endl;
                cout<<""<<endl;
                cout<<"                       press enter for log out"<<endl;
                cin.get();
                cin.get();
                {
                    maain();
                }
                }
                    break;
                default:
                        system("CLS");
                        cout<<"You enter wrong number"<<endl;
                        {
                            menu();
                        }
        }


}
void class1::eregs()
{ int er,pg;
     system("CLS");
          cout<<""<<endl;
            cout<<""<<endl;
                cout<<"                             Employer details "<<endl;
                cout<<"                             ================"<<endl;
                cout<<"                             1.REGISTRATION"<<endl;
                cout<<""<<endl;
                cout<<"                             2.DETAILS"<<endl;
                 cout<<""<<endl;
                  cout<<""<<endl;
                   cout<<""<<endl;
                    cout<<"                                    chose anyone :";
                    cin>>er;

            if(er==1)
                  {
                    string ereguser,eaddr,enid,ephnNum,slry;
        system("cls");
        cout<<"                                   REGISTRATION   "<<endl;
        cout<<"                                ==================="<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                                #Enter Name :";
        cin>>ereguser;
        cout<<"                                #Enter  NID Number :";
        cin>>enid;
        cout<<"                                #Enter  Address    :";
        cin>>eaddr;
        cout<<"                                #Enter  Phone Number :";
        cin>>ephnNum;
        cout<<"                                #Enter salary  :";
        cin>>slry;

        ofstream ereg("emply.txt",ios::app);
        ereg<<ereguser<<' '<<enid<<' '<<eaddr<<' '<<ephnNum<< ' '<<slry<<endl;

        cout<<"                       Registration Successful";

        ereg.close();

           cout<<"                  press 0: ";
                cin>>pg;
                while(pg==0)
                {
                    emp();
                }
            }






          else if(er==2)
             {system("CLS");
             string enam,ennb,eaddrs,ephnm,slr;

        cout<<"                                      DETIELS    "<<endl;
        cout<<"                                ==================="<<endl;
        ifstream eopen("emply.txt",ios::in);
       while(eopen>>enam>>ennb>>eaddrs>>ephnm>>slr)
             {
                    cout<<""<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                                 Name :"<<enam<<endl;
        cout<<"                                 NID Number :"<<ennb<<endl;
        cout<<"                                 Address    :"<<eaddrs<<endl;
        cout<<"                                 Phone Number :"<<ephnm<<endl;
        cout<<"                                 Monthly salary :"<<slr<<endl;
             }

           eopen.close();
              cout<<"                  press 0: ";
                cin>>pg;
                while(pg==0)
                {
                    emp();
                }

             }

            else {
            cout<<"                      You enter a wrong number";
               cout<<"                  press 0: ";
                cin>>pg;
                while(pg==0)
                {
                    emp();
                }
            }
}









void class1::emp()
 { system("CLS");
      string adminName;
    string suser;
    string spass;
    char ch;
    int er,en,pg;

  cout<<""<<endl;
            cout<<""<<endl;
            cout<<"                              WELLCOME ADMIN "<<endl;
            cout<<"                             ================"<<endl;
            cout<<""<<endl;
            cout<<"                             1.User details"<<endl;
            cout<<"                             2.Employer  details"<<endl;
            cout<<"                             3.Exit"<<endl;

            cout<<""<<endl;
            cout<<""<<endl;
            cout<<"                                    Enter the number :";
            cin>>en;
   if(en==1)
            {system("CLS");
            cout<<"                                       USER DETAILS"<<endl;
            cout<<"                                      =============="<<endl;
                details();
                cout<<"                  press 0: ";
                cin>>pg;
                while(pg==0)
                {
                     emp();

                }

            }
            else if(en==2)
            {
              eregs();


            }
            else if(en==3)
                    {
              maain();
                    }
            else{

                 cout<<"                      You enter a wrong number";

                                                 cout<<"                  press 0: ";
                cin>>pg;
                while(pg==0)
                {
                     emp();

                }

            }


 }

void class1::login()
{       int y,i;
        int count;
        string user,u,p,pass;
        char ch;
        system("cls");
         cout<<""<<endl;
         cout<<""<<endl;


        cout<<"                                               LOGIN                  "<<endl;
        cout<<"                                    ===============================   "<<endl;


        cout<<""<<endl;

        cout<<"                                      1.User                           "<<endl;
        cout<<"                                      2.administration                 "<<endl;


         cout<<""<<endl;

          cout<<""<<endl;

          cout<<"                                    Choose your Option from 1 or 2:";
          cin>>i;
         {system("CLS");

          switch(i)
          {
          case 1:
         {
              cout<<""<<endl;
               cout<<""<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                                    USERE LOGIN   "<<endl;
        cout<<"                                  =============== "<<endl;
        cout<<""<<endl;
         cout<<""<<endl;
        cout<<"                                  USERNAME :";
        cin>>user;
        cout<<"                                  PASSWORD :";
          ch = _getch();
         while(ch!= 13)
         {
              pass.push_back(ch);
      cout << '*';
      ch = _getch();

         }
        ifstream input("database.txt");
        while(input>>u>>p)
        {
                if(u==user && p==pass)

                {
                        count=1;
                        system("cls");
                }
        }
        input.close();
        if(count==1)
        {       cout<<""<<endl;
                cout<<""<<endl;
                cout<<"                              LOGIN SUCESS "<<endl;
                cout<<""<<endl;
                cout<<"                              Hello "<<user<<endl;
                cin.get();
                    cout<<""<<endl;
        cout<<""<<endl;
        cout<<""<<endl;


        cout<<"                                       Your Last Visit History          "<<endl;
        cout<<"                                     =============================      "<<endl;
        cout<<""<<endl;


               cout<<"                          PRESS ENTER FOT NEXT PAGE:";
               cin.get();
               {
                   menu();
               }
        }
  else
        {
                cout<<"                Please check your username and password";
                cin.get();
                {
                    maain();
                }

        }
          }
          break;
        case 2:
            {

            cout<<"                    Administration Login ";
            reg();

            }

          cout<<""<<endl;

          cout<<""<<endl;
           break;
          default:
              {
              cout<<"                 you enter wrong number";
               maain();
              }
          }




        }

}
void class1::reg()
 { system("CLS");
    string adminName;
    string suser;
    string spass;
    char ch;
    int er;
    string adminpassword="";

     int prv;
           cout<<"                                Administration Login         "<<endl;
           cout<<"                               ======================        "<<endl;
           cout<<""<<endl;
           cout<<""<<endl;
           cout << "                            ADMIN enter your  name: ";
           cin >> adminName;
             cout<<""<<endl;
           cout << "                            ADMIN enter your user password: ";
         ch = _getch();
         while(ch!= 13)
         {
              adminpassword.push_back(ch);
      cout << '*';
      ch = _getch();
         }


        if (adminName == "admin" && adminpassword == "admin")
        {system("CLS");

          emp();

        }
        else
        {   cout<<""<<endl;
            cout << "                    Invalid login attempt. Please try again.\n" << '\n';
            cin.get();
            {
              reg();
            }
        }
    }


void class1::registration()
{

        string reguser,regpass,nid,phnNum;
        system("cls");
        cout<<"                                   REGISTRATION   "<<endl;
        cout<<"                                ==================="<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"                                #Enter the User name :";
        cin>>reguser;
        cout<<"                                #Enter the password :";
        cin>>regpass;
        cout<<"                                #Enter your NID Number :";
        cin>>nid;
        cout<<"                                #Enter your Phone Number :";
        cin>>phnNum;

        ofstream reg("database.txt",ios::app);
        reg<<reguser<<' '<<regpass<<' '<<nid<<' '<<phnNum<<endl;
        system("cls");
        cout<<"                       \nRegistration Successful\n";
        maain();


}





void class1::display()
{
cout<<" "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<"                             *--------------------------------------------------------------------*"<<endl;
cout<<"                             |                                                                    |"<<endl;
cout<<"                             |                                                                    |"<<endl;
cout<<"                             |                         AIRLINE MANAGEMENT SYSTEM                  |"<<endl;
cout<<"                             |                                                                    |"<<endl;
cout<<"                             |                                                                    |"<<endl;
cout<<"                             *--------------------------------------------------------------------*"<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<"                           Online Air ticket management  system  reduces the scope of manual error and conveniently"<<endl;
cout<<"                                maintainsany  modifications,cancellations in the reservations. It not only"<<endl;
cout<<"                                    provide flight details but also creates a platform to book tickets"<<endl;
cout<<"                                      ,cancels or modifies ticket timings or dates and even informs"<<endl;
cout<<"                                                about the number of people on board! "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<"                [ Thanks to our respectful faculty MD. Nazmul sir ]        "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<"                 The persons who are works on it:                      "<<endl;
cout<<"                [ Md Rifat :<: 20-42574-1 ]                            "<<endl;
cout<<"                [ Anika Tabassum :<: 20-42562-1 ]                      "<<endl;
cout<<"                [ S.M. Tanvirul Islam :<: 20-42563-1 ]                 "<<endl;
cout<<"                [ Ashadu Jaman Shawon :<: 20-42611-1 ]                 "<<endl;
cout<<"  "<<endl;
cout<<"  "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;
cout<<" "<<endl;

cout<<"                                                                             PLEASE PRESS ENTER FOR NEXT PAGE :"<<endl;
cin.get();
{system("CLS");
    maain();
}

}
int main()
{
    class1 c1;
    c1.display();

    getch();

    return 0;
}
