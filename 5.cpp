// |1.|1.1.|1.1.1.|1.2.|1.3.|1.3.1.|2.|2.1.|2.2.|2.2.1.|2.2.2.|3.|3.1.|3.2.|3.3.|3.3.1.|3.3.2.|4.|4.1.|4.1.1.|
//|1.|1.1.|1.1.1.|1.1.2.|1.2.|2.|2.1.|2.1.1.|
using namespace std;
#include <windows.h>
#include <stdio.h>
#include <iostream>
#include <locale.h>
#include <conio.h>
int main() {
    int NumI = 0;
    FILE *ff;
    setlocale(LC_ALL, "Russian");
    STARTUPINFO cif;
    ZeroMemory(&cif, sizeof(STARTUPINFO));
    PROCESS_INFORMATION pi, qi, wi;
    if (CreateProcess("C:\\Windows\\System32\\notepad.exe",NULL,NULL,NULL,FALSE,NULL,NULL,NULL,&cif,&qi)==TRUE) 
    {
        puts("Start process 1.");
        NumI++;
        Sleep(1000);
    }
    if (CreateProcess("C:\\Windows\\System32\\notepad.exe",NULL,NULL,NULL,FALSE,NULL,NULL,NULL,&cif,&qi)==TRUE) 
    {
        puts("Start process 2.");
        NumI += 1;
        Sleep(1000);
    }

    if (CreateProcess("C:\\Windows\\System32\\notepad.exe",NULL,NULL,NULL,FALSE,NULL,NULL,NULL,&cif,&qi)==TRUE) 
    {
        puts("Start process 1.1.");
        NumI += 2;
        Sleep(1000);
    }
    if (CreateProcess("C:\\Windows\\System32\\notepad.exe",NULL,NULL,NULL,FALSE,NULL,NULL,NULL,&cif,&qi)==TRUE) 
    {
        puts("Start process 1.2.");
        NumI += 2;
        Sleep(1000);
    }

    
    if (CreateProcess("C:\\Windows\\System32\\notepad.exe",NULL,NULL,NULL,FALSE,NULL,NULL,NULL,&cif,&qi)==TRUE) 
    {
        puts("Start process 2.1.");
        NumI += 2;
        Sleep(1000);
    }

     

	ff=fopen("f12.txt","wt");
    fprintf(ff,"1.2");
    fclose(ff); 

    TerminateProcess(pi.hProcess, NO_ERROR);
    puts("End process 1.2.");



    if (CreateProcess("C:\\Windows\\System32\\notepad.exe",NULL,NULL,NULL,FALSE,NULL,NULL,NULL,&cif,&qi)==TRUE) 
    {
        puts("Start process 1.1.1.");
        NumI += 3;
        Sleep(1000);
    }

    if (CreateProcess("C:\\Windows\\System32\\notepad.exe",NULL,NULL,NULL,FALSE,NULL,NULL,NULL,&cif,&qi)==TRUE) 
    {
        puts("Start process 1.1.2");
        NumI += 3;
        Sleep(1000);
    }

    if (CreateProcess("C:\\Windows\\System32\\notepad.exe",NULL,NULL,NULL,FALSE,NULL,NULL,NULL,&cif,&qi)==TRUE) 
    {
        puts("Start process 2.1.1.");
        NumI += 3;
        Sleep(1000);
    }
    //|1.|1.1.|1.1.1.|1.1.2.|1.2.|2.|2.1.|2.1.1.|
	ff=fopen("f111.txt","wt");
    fprintf(ff,"1.1.1");
    fclose(ff); 

    TerminateProcess(pi.hProcess, NO_ERROR);
    puts("End process 1.1.1.");

	ff=fopen("f112.txt","wt");
    fprintf(ff,"1.1.2");
    fclose(ff); 

    TerminateProcess(pi.hProcess, NO_ERROR);
    puts("End process 1.1.2.");

	ff=fopen("f211.txt","wt");
    fprintf(ff,"2.1.1");
    fclose(ff); 

    TerminateProcess(pi.hProcess, NO_ERROR);
    puts("End process 2.1.1.");
    //|1.|1.1.|1.1.1.|1.1.2.|1.2.|2.|2.1.|2.1.1.|
    
	ff=fopen("f11.txt","wt");
    fprintf(ff,"1.1 (1.1.1,1.1.2)");
    fclose(ff); 

    TerminateProcess(pi.hProcess, NO_ERROR);
    puts("End process 1.1.");

	
    ff=fopen("f21.txt","wt");
    fprintf(ff,"2.1 (2.1.1)");
    fclose(ff); 
    
    TerminateProcess(pi.hProcess, NO_ERROR);
    puts("End process 2.1.");
	//|1.|1.1.|1.1.1.|1.1.2.|1.2.|2.|2.1.|2.1.1.|    
    ff=fopen("f2.txt","wt");
    fprintf(ff,"2 (2.1 (2.1.1))");
    fclose(ff); 
    
    TerminateProcess(pi.hProcess, NO_ERROR);
    puts("End process 2.");

	ff=fopen("f1.txt","wt");
    fprintf(ff,"1(1.1 (1.1.1, 1.1.2), 1.2)");
    fclose(ff); 

    TerminateProcess(pi.hProcess, NO_ERROR);
    puts("End process 1.");


	ff=fopen("f0.txt","wt");
    fprintf(ff,"1(1.1 (1.1.1, 1.1.2), 1.2), 2 (2.1 (2.2.1))");
    fclose(ff); 

    cout << endl << "Result :" << NumI << endl;
    return 0;
}

