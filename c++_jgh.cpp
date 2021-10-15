#include<stdio.h>
#include<Windows.h>
#include<process.h>
int number = 0;
int i = 0;
int j = 0;

unsigned _stdcall Thread_A(void* arg)
{
	for(i=0;i<100000000; i++)
	{
		number += 1000;
	}
}

int main() {
	_beginthreadex(NULL, 0, Thread_A, 0, 0, NULL);
	for (j = 0; j < 10000000000; j++)
	{
		number -= 1000;
	}
	Sleep(5000);
	printf("%d", number);

	return 0;
}